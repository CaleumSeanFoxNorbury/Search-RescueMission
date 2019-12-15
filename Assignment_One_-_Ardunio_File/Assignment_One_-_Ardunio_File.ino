#include<Zumo32U4.h>
#include<Wire.h>

#include"TurnSensor.h"
#include"ProxSensor.h"

//setting instances 
Zumo32U4ProximitySensors proxSensors; //proximity sensor 
Zumo32U4Motors motors;
Zumo32U4LineSensors lineSensors;
L3G gyro; //gyro scope
 
void setup() {
  //port initaliser 
  Serial1.begin(9600);
  Serial.begin(9600);
  //turn sensor setup
  turnSensorSetup();
  delay(500);
  turnSensorReset(); 
  //prox sensor setup
  proxSensors.initThreeSensors(); //initalise the three sensors(left, right, front-leftm front-right)
}

void loop() {
  //declaring variables
  int incomingByte = 0; 
  
  //constant display angle of the robot
  //turn sensor display - needs to be on GUI
  //turnSensorUpdate();
  int32_t angle = getAngle();

  Serial1.print("angle of sensor: ");
  Serial1.println(angle);
 
  //PROX SENSOR READINGS 
  PrxSensorRead();
  ReadInProxSensors(); 
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
  }
}

void Go(){
  motors.setSpeeds(100, 100);
}
void Stop(){
  motors.setSpeeds(0, 0);
}
void Backwards(){
  motors.setSpeeds(-100, -100);
}
//Turning--------------------------------------------------------------
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
    //--Line sensor reading----------------------------
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
*/
