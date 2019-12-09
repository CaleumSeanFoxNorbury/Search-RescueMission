#pragma once
#include <Zumo32U4.h>

void PrxSensorRead();
void DisplayReading();
void ReadInProxSensors();

extern int left_sensor;
extern int center_left_sensor;
extern int center_right_sensor;
extern int right_sensor;

extern Zumo32U4ProximitySensors proxSensors;
