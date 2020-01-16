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
  //update, initialise or delcared functions/variables
  turnSensorUpdate();
  int32_t angle = getAngle();
  //event actions
  if(Serial1.available() > 0) {
   incomingByte = Serial1.read();
   //displayIncomingByteWorth(incomingByte); //say what i got | testing 

   //test function
   if(incomingByte == 116){ //key: t || testing
     Serial1.println("Testing");   
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
     //user feedback | showing course has started
     Serial1.println("Starting Course");
     Serial1.println(" ");
     Course();
    }
  }
}

//--RC CONTROLLS-------------------
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
  int angle = 0; 
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

//displaying incoming bytes worth | TESTING
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
  while(Serial1.read() != 115){    
    Go();
      lineSensors.read(lineSensorValues); 
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
    }
    searchRoomDesicion();  
}

void reachedImpass(){
      motors.setSpeeds(0, 0); 
     delay(250);
     motors.setSpeeds(-100, -100);
     delay(500);
     motors.setSpeeds(0, 0);
     delay(250);
     Serial1.println("Reached Corner");
}

void turnChoice(){
    Serial1.println("Turn Left[l] | Right[r] | U-Turn[8] | Return Home[h]");
    while(Serial1.available() == 0){
      //wait until user reacts
    }
    if(Serial1.available() > 0){
     int choice = Serial1.read();
     if(choice == 108){ //if left turn
       TurnLeft();
     }else if(choice == 114){ //if right turn 
        TurnRight();
     } else if(choice == 56){ 
        //uturn 
        UTurn();
    } else if(choice == 104){
      //head home...
      Serial1.print("Returning home");
      delay(500);
    }
   }
   Serial1.println("completed");
}

void searchingLeftRoom(){
  TurnLeft();
  Go();
  delay(1000);
  Stop();
  PrxSensorRead();
  ReadInProxSensors();
  DisplayReading();
  Serial1.println(" ");
  Serial1.println("Please send 'c' for completed task and [c]carry on"); 
  while(Serial1.read() != 99){
      //wait and display readings...
      PrxSensorRead();
      ReadInProxSensors();
      DisplayReading();
      Serial1.println(" ");
      delay(500);
  }
  delay(500);
  Backwards();
  delay(1000);
  Stop();
  TurnRight();
  delay(500);
  Go();
  Course();
}

void searchingRightRoom(){
  TurnRight();
  Go();
  delay(1000);
  Stop();
  PrxSensorRead();
  ReadInProxSensors();
  DisplayReading();
  Serial1.println(" ");
  Serial1.println("Please send 'c' for completed task and [c]carry on"); 
  while(Serial1.read() != 99){
      //wait and display readings...
      PrxSensorRead();
      ReadInProxSensors();
      DisplayReading();
      Serial1.println(" ");
      delay(500);
  }
  Serial1.println("Action completed!");
  delay(500);
  Backwards();
  delay(1000);
  Stop();
  TurnLeft();
  delay(500);
  Go();
  Course();
}

void searchRoomDesicion(){
  Stop();
  Serial1.println("Please select a function to process: ");
  Serial1.println("L) Search room on the left");
  Serial1.println("R) Search room on the right");
  Serial1.println(" ");
  do{
    while(Serial1.read() == 114){
      //search right room
      Serial1.println("Searching room on the right");
      searchingRightRoom();
    }
    //wait...
  }while(Serial1.read() != 108);
  //search left room
  Serial1.println("Searching room on the left");
  searchingLeftRoom();
}

void headHome(){
  while(Serial1.read() != 115){    
    Go();
      lineSensors.read(lineSensorValues); 
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
    }
    //got to the T-junction
    while(Serial1.read() != 108){
    if(Serial1.read() == 114){
      //take a right turn
      TurnRight();
      headHome();
    }
    //wait...
  }
  //turn left
  TurnLeft();
  headHome();
}
