#include <Wire.h>

#include "ProxSensor.h"

int left_sensor = 0;
int center_left_sensor = 0;
int center_right_sensor = 0;
int right_sensor = 0;

void PrxSensorRead(){
  proxSensors.read();
}

void ReadInProxSensors(){
  left_sensor = proxSensors.countsLeftWithLeftLeds();
  center_left_sensor = proxSensors.countsFrontWithLeftLeds();
  center_right_sensor = proxSensors.countsFrontWithRightLeds();
  right_sensor = proxSensors.countsRightWithRightLeds();
}

void DisplayReading(){ //will be send data to gui
  Serial1.println("Left sensor: ");
  Serial1.println(left_sensor);
  Serial1.println("Right sensor: ");
  Serial1.println(right_sensor);
  Serial1.println("Front-Left sensor: ");
  Serial1.println(center_left_sensor);
  Serial1.println("Front-Right sensor: ");
  Serial1.println(center_left_sensor);
  delay(500);
}
