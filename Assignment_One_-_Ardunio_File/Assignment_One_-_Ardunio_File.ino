#include<Zumo32U4.h>
#include<Wire.h>

#include"RC-Controls.h"
#include"TurnSensor.h"
#include"ProxSensor.h"
#include"Course.h"

//setting instances of hardware/features
Zumo32U4ProximitySensors proxSensors;       //proximity sensors
Zumo32U4LineSensors lineSensors;            //line sensors
L3G gyro;                                   //gyro 

void setup() {
  //port initaliser 
  Serial1.begin(9600);
  Serial.begin(9600);
  
  //sensors initalise and setup
  turnSensorSetup();
  delay(500);
  turnSensorReset();
  proxSensors.initThreeSensors(); //initalise the three sensors(left, right, front-leftm front-right)
  lineSensors.initThreeSensors();
}

void loop() {
  //Readings and declarations
  int incomingByte = 0; 
  //update, initialise or delcared functions/variables
  turnSensorUpdate();
  int32_t angle = getAngle();
  
  //event actions
  if(Serial1.available() > 0) {
    incomingByte = Serial1.read();
    //displayIncomingByteWorth(incomingByte); //say what i got | Testing 

    //test function
    if(incomingByte == 116){ //key: t || Testing
      Serial1.println("q");   
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

//displaying incoming bytes worth | TESTING
void displayIncomingByteWorth(int Incomingbyte){
    Serial1.println("I received: ");
    Serial1.println(Incomingbyte, DEC);
    Serial1.println(" ");
}
