#include "RC-Controls.h"

//Go
void Go(){
  motors.setSpeeds(75, 75);
}

//Stop
void Stop(){
  motors.setSpeeds(0, 0);
}

//Reverse
void Backwards(){
  motors.setSpeeds(-75, -75);
}

//Turn left
void TurnLeft(){
  turnSensorReset();
  int angle = 0; 
  do{
    motors.setSpeeds(-75, 75);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != 90);
  Stop();
}

//Turn right
void TurnRight(){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(75, -75);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != -90);
  Stop();
}

//makes a u-turn using gyro functionality
void UTurn(){
  turnSensorReset();
  int angle =0;
  do{
    motors.setSpeeds(75, -75);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  }while(angle != -179);
  Stop();
}

int32_t getAngle() {
  // turnAngle is a variable defined in TurnSensor.cpp
  // This fancy math converts the number into degrees turned since the
  // last sensor reset.
  //  Available at: https://github.com/pvcraven/zumo_32u4_examples/blob/master/GyroSensorExample/GyroSensorExample.ino
  return (((int32_t)turnAngle >> 16) * 360) >> 16;
}
