#pragma once
#include <Zumo32U4.h>
#include <Wire.h>

#include"RC-Controls.h"
#include"ProxSensor.h"

void Course();
void reachedImpass();
void turnChoice();
void searchingLeftRoom();
void searchingRightRoom();
void searchRoomDesicion();
void headHome();

extern Zumo32U4Motors motors;               //motors 
extern Zumo32U4LineSensors lineSensors;     //line sensors
