#pragma once
#include <Zumo32U4.h>
#include <Wire.h>

#include"TurnSensor.h"

//variable and hardware instances
extern uint32_t turnAngle;
extern Zumo32U4Motors motors;                      //motors 

//RC functions 
void Go();
void Stop();
void Backwards();
void TurnLeft();
void TurnRight();
void UTurn();

int32_t getAngle();
