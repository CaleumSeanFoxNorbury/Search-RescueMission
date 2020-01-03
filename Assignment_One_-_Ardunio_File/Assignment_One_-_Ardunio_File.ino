#include<Zumo32U4.h>

#include<Wire.h>

#include"TurnSensor.h"
#include"ProxSensor.h"
#include"LineSensor.h"

//setting instances 
Zumo32U4ProximitySensors proxSensors; //proximity sensor 
Zumo32U4Motors motors;
Zumo32U4LineSensors lineSensors;
L3G gyro; //gyro scope

#define QTR_THRESHOLD     1000  // microseconds
#define NUM_SENSORS 3
unsigned int lineSensorValues[NUM_SENSORS];

void setup() {
  //port initaliser 
  Serial1.begin(9600);
  Serial.begin(9600);
  //turn sensor setup
  turnSensorSetup();
  delay(500);
  turnSensorReset();
  //MOVE ALL INITALIZERS INTO THE HEADERS--------- 
  //prox sensor setup
  proxSensors.initThreeSensors(); //initalise the three sensors(left, right, front-leftm front-right)
  lineSensors.initThreeSensors();
  //----------------------------------------------
}

void loop() {
  //reading 
  int incomingByte = 0; 
  lineSensors.read(lineSensorValues);
  incomingByte = Serial1.read();
  //update, initialise or delcared functions/variables
  turnSensorUpdate();
  int32_t angle = getAngle();
  //TESTING | PLACE UNDER EVENT ACTION ONCE DONE 
  Course();
    
  //event actions
  if (Serial1.available() > 0) {
   incomingByte = Serial1.read();
   //displayIncomingByteWorth(incomingByte); //say what i got | testing 

   //test function
   if(incomingByte == 116){ //key: t || testing
     Serial1.print("Caleum");
   }
   if(incomingByte == 103){ //key: g
      Go();
    }
   if(incomingByte == 115){ //key: s
      Stop();
    }
   if(incomingByte == 98){ //Key: b
      Backwards();
    }
   if(incomingByte == 108){ //Key: l 
      TurnLeft();
    }
   if(incomingByte == 114){ //key: r
    TurnRight();
   }
   if(incomingByte == 56){ //key: 8 Functionality: 180degree turn
      UTurn();
    }
   if(incomingByte == 99){ //key: c Will start course operation 
     Course();
    }
  }
}

//--RC CONTROLLS 
void Go(){
  motors.setSpeeds(100, 100);
}
void Stop(){
  motors.setSpeeds(0, 0);
}
void Backwards(){
  motors.setSpeeds(-100, -100);
}
void TurnLeft(){
  turnSensorReset();
  int angle =0; 
  do{
    motors.setSpeeds(-100, 100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != 90);
  Stop();
}
void TurnRight(){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(100, -100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != -90);
  Stop();
}
void UTurn(){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(100, -100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != -179);
  Stop();
}
//------------------------------------------------------


//displaying incoming bytes worth
void displayIncomingByteWorth(int Incomingbyte){
    Serial1.println("I received: ");
    Serial1.println(Incomingbyte, DEC);
    Serial1.println(" ");
}

//turning sensor ------------------------------------------
//catculates the degrees turned since the last gyro reset
int32_t getAngle(){
  return (((int32_t)turnAngle >> 16)* 360) >> 16; 
}

void Course(){
    //Start course | Go
    Go();
    //first corner of the course | COURSE
    if((lineSensorValues[2] > QTR_THRESHOLD) && (lineSensorValues[0] > QTR_THRESHOLD)){ //if center sensor detects black line |sensor 1
        reachedImpass();
        turnChoice();
        delay(500);
        Go();
     } 
     else if(lineSensorValues[0] > QTR_THRESHOLD){ //left sensor detects line | sensor 0
         motors.setSpeeds(100, 0);
         delay(250);
         motors.setSpeeds(100, 100);
     }else if(lineSensorValues[2] > QTR_THRESHOLD){ //if right sensor detects black line| sensor 2
           motors.setSpeeds(0,  100);
           delay(250);
           motors.setSpeeds(100, 100);
    }
  //if zumo gets reading 
  if(Serial1.available() > 0){
    int order = Serial1.read();
    motors.setSpeeds(0, 0);
    Serial1.println("Please select a function to process: ");
    Serial1.println("L) Search room on the left");
    Serial1.println("R) Search room on the right");
    while(Serial1.available() == 0){
      //wait until user reacts
    }
    if(Serial1.available() > 0){
      int choice = Serial1.read();
      if(choice == 108){
       //searc room on the left
       Serial1.println("Searching room on the left");
       while(Serial1.available() == 0){
        //wait until user reacts
       }
      }else if(choice == 114){
        //serach room on the right
        Serial1.print("Searching room on the right");
        while(Serial1.available() == 0){
        //wait until user reacts
        }
      } 
    }
  }
  //TODO::what action does the zumo need to respond too? | search room | two types of rooms and directions zumo needs to take 
}

void reachedImpass(){
      motors.setSpeeds(0, 0);
     delay(250);
     motors.setSpeeds(-100, -100);
     delay(500);
     motors.setSpeeds(0, 0);
     delay(250);
     Serial1.println("Corner");
}

void turnChoice(){
    Serial1.println("Left[l] or Right[r]?");
    while(Serial1.available() == 0){
      //wait until user reacts
    }
    if(Serial1.available() > 0){
     int choice = Serial1.read();
     if(choice == 108){ //if left turn
       TurnLeft();
     }else if(choice == 114){ //if right turn 
        TurnRight();
     } 
    }

    Serial1.println("completed");
}

/*
  
lineSensor.initThreeSensors(); //initalising the three sensors for the line movement
lineSensor.emittersOn(); //for line sensor

Zumo32U4ProximitySensors proxSensors; //proximity sensor 
Zumo32U4LineSensors lineSensor; //line sensor

//Line sensor array(for all stored values)
unsigned int lineSensorsValues[3];

    
  //--Line Sensor-------------------------------------------------------
  lineSensor.read(lineSensorsValues);
  //--------------------------------------------------------------------
  //--Proximity sensor---------------------------------------------------
   proxSensors.read(); //read in values

  int left_sensor = proxSensors.countsLeftWithLeftLeds();
  int center_left_sensor = proxSensors.countsFrontWithLeftLeds();
  int center_right_sensor = proxSensors.countsFrontWithRightLeds();
  int right_sensor = proxSensors.countsRightWithRightLeds();
  //---------------------------------------------------------------------
  */
    /*
    //--prox sensor reading----------------------------
    Serial1.println("Left sensor: ");
    Serial1.println(left_sensor);
    Serial1.println("Right sensor: ");
    Serial1.println(right_sensor);
    Serial1.println("Front-Left sensor: ");
    Serial1.println(center_left_sensor);
    Serial1.println("Front-Right sensor: ");
    Serial1.println(center_left_sensor);
    //------------------------------------------------
    //--Line Sensor-----------------------------------
    Serial1.println("Line sensor reading: ");
    Serial1.println(lineSensorsValues[0]/10);
    Serial1.println(lineSensorsValues[1]/10);
    Serial1.println(lineSensorsValues[2]/10);
    //------------------------------------------------
    */

  /*
  turnSensorReset();
  int angle =0;
  
  do{
    motors.setSpeeds(100, -100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != 10);
  Stop();
  
}
//-------------------------------------------------------------------------
void TurnToDegrees(int degrees){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(-100, 100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle < degrees);
  Stop();
}



//////////////////////

bool Zumo32U4ProximitySensors::readBasic(uint8_t sensorNumber)
{
    if (sensorNumber >= numSensors) { return 0; }
    return !digitalReadSafe(dataArray[sensorNumber].pin, 1);
}


//FIRST LINE UP CODE(EDITED)
#include<Zumo32U4.h>

#include<Wire.h>

#include"TurnSensor.h"
#include"ProxSensor.h"
#include"LineSensor.h"

//setting instances 
Zumo32U4ProximitySensors proxSensors; //proximity sensor 
Zumo32U4Motors motors;
Zumo32U4LineSensors lineSensors;
L3G gyro; //gyro scope

#define QTR_THRESHOLD     1000  // microseconds
#define NUM_SENSORS 3
unsigned int lineSensorValues[NUM_SENSORS];

void setup() {
  //port initaliser 
  Serial1.begin(9600);
  Serial.begin(9600);
  //turn sensor setup
  turnSensorSetup();
  delay(500);
  turnSensorReset();
  //MOVE ALL INITALIZERS INTO THE HEADERS--------- 
  //prox sensor setup
  proxSensors.initThreeSensors(); //initalise the three sensors(left, right, front-leftm front-right)
  lineSensors.initThreeSensors();
  //----------------------------------------------
}

void loop() {
  //reading 
  int incomingByte = 0; 
  lineSensors.read(lineSensorValues);

  incomingByte = Serial1.read();
  //update, initialise or delcared functions/variables
  turnSensorUpdate();

  Course(incomingByte);
  //constant display angle of the robot
  //turn sensor display - needs to be on GUI
  int32_t angle = getAngle();
//  Serial1.print("angle of sensor: ");
//  Serial1.println(angle);
     
//  //First value
//  Serial1.print("Line Sensor One Value: ");
//  Serial1.println(lineSensorValues[0] / 10);
//  Serial1.println(" ");
//  //Second value
//  Serial1.print("Line Sensor Two Value: ");
//  Serial1.println(lineSensorValues[1] / 10);
//  Serial1.println(" ");
//  //Third value
//  Serial1.print("Line Sensor Three Value: ");
//  Serial1.println(lineSensorValues[2] / 10);
//  Serial1.println(" ");
  
  //PROX SENSOR READINGS 
//  PrxSensorRead();
//  ReadInProxSensors(); 
  //DisplayReading();

  //event actions
  if (Serial1.available() > 0) {
   incomingByte = Serial1.read();
   //displayIncomingByteWorth(incomingByte); //say what i got

   //test function
   if(incomingByte == 116){ //key: t || testing
     Serial1.print("Caleum");
   }
   if(incomingByte == 103){ //key: g
      Go();
    }
   if(incomingByte == 115){ //key: s
      Stop();
    }
   if(incomingByte == 98){ //Key: b
      Backwards();
    }
   if(incomingByte == 108){ //Key: l 
      TurnLeft();
    }
   if(incomingByte == 114){ //key: r
    TurnRight();
   }
   if(incomingByte == 56){ //key: 8 Functionality: 180degree turn
      UTurn();
    }
   if(incomingByte == 99){ //key: c Will start course operation 
     Course(incomingByte);
    }
  }
}

//--RC CONTROLLS 
void Go(){
  motors.setSpeeds(100, 100);
}
void Stop(){
  motors.setSpeeds(0, 0);
}
void Backwards(){
  motors.setSpeeds(-100, -100);
}
void TurnLeft(){
  turnSensorReset();
  int angle =0; 
  do{
    motors.setSpeeds(-100, 100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != 90);
  Stop();
}
void TurnRight(){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(100, -100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != -90);
  Stop();
}
void UTurn(){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(100, -100);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != -179);
  Stop();
}
//------------------------------------------------------

//displaying incoming bytes worth
void displayIncomingByteWorth(int Incomingbyte){
    Serial1.println("I received: ");
    Serial1.println(Incomingbyte, DEC);
    Serial1.println(" ");
}

//turning sensor ------------------------------------------
//catculates the degrees turned since the last gyro reset
int32_t getAngle(){
  return (((int32_t)turnAngle >> 16)* 360) >> 16; 
}

void Course(int incomingByte){
  //Start course | Go
  Go();
  //first corner of the course | COURSE
 if((lineSensorValues[2] > QTR_THRESHOLD) && (lineSensorValues[0] > QTR_THRESHOLD)){ //if center sensor detects black line |sensor 1
     motors.setSpeeds(0, 0);
     delay(250);
     motors.setSpeeds(-100, -100);
     delay(500);
     motors.setSpeeds(0, 0);
     delay(250);
     Serial1.print("Corner");
     
     if(incomingByte == 108){ //if left turn
       TurnLeft();
     }else if(incomingByte == 114){ //if right turn 
        TurnRight();
     }
     
     delay(500);
     motors.setSpeeds(100, 100);
  } 
  else if(lineSensorValues[0] > QTR_THRESHOLD){ //left sensor detects line | sensor 0
      motors.setSpeeds(100, 0);
      delay(250);
      motors.setSpeeds(100, 100);
  }else if(lineSensorValues[2] > QTR_THRESHOLD){ //if right sensor detects black line| sensor 2
        motors.setSpeeds(0,  100);
        delay(250);
        motors.setSpeeds(100, 100);
  }
}

*/
