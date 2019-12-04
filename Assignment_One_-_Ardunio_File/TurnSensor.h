#pragma once
#include <Zumo32U4.h>

const int32_t turnAngle90 = 0x20000000 * 2;

const int32_t turnAngle1 = (0x20000000 + 22) / 45;

void turnSensorSetup();
void turnSensorReset();
void turnSensorUpdate();
extern uint32_t turnAngle;
extern int16_t turnRate;

extern L3G gyro;
