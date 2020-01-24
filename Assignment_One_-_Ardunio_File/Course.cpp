#include "Course.h"

//Storage and declarations for line sensor used within course
#define QTR_THRESHOLD     750               // microseconds
#define NUM_SENSORS       3                 //declaring sensor count
unsigned int lineSensorValues[NUM_SENSORS]; //array for line sensor values

//starting of the course functionality
void Course(){
  while(Serial1.read() != 115){    
    Go();
      lineSensors.read(lineSensorValues); 
      //if left and right sensor get a black border reading then...
      if(((lineSensorValues[2] > QTR_THRESHOLD) && (lineSensorValues[0] > QTR_THRESHOLD)) || (lineSensorValues[1] > QTR_THRESHOLD)){ //if center sensor detects black line |sensor 1
        //reached impass function
        reachedImpass();
        //turn choice
        turnChoice();
        //delay half a second
        delay(500);
        Go();
      } 
      //if left sesnor gets a black reading...
      else if(lineSensorValues[0] > QTR_THRESHOLD){ //left sensor detects line | sensor 0
         //go right for 1/4 second
         motors.setSpeeds(75, 0);
         delay(250);
         motors.setSpeeds(75, 75);
      //if right sensor gets a black boarder reading...
      }else if(lineSensorValues[2] > QTR_THRESHOLD){ //if right sensor detects black line| sensor 2
           //go ;left for 1/4 second
           motors.setSpeeds(0,  75);
           delay(250);
           motors.setSpeeds(75, 75);
      }       
    }
    //if readings gets a c. Get room decision functionality 
    searchRoomDesicion();  
}

//when zumo reaches an impass
void reachedImpass(){
      motors.setSpeeds(0, 0); 
     delay(250);
     motors.setSpeeds(-75, -75);
     delay(500);
     motors.setSpeeds(0, 0);
     delay(250);
     Serial1.println("Reached Corner");
}

//getting the turn choice of the zumo after reaching impass
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
      headHome();
    }
   }
   Serial1.println("completed");
}

//searching left room
void searchingLeftRoom(){
  TurnLeft();
  Go();
  delay(750);
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
  delay(750);
  Stop();
  TurnRight();
  delay(500);
  Go();
  Course();
}

//searching right room
void searchingRightRoom(){
  TurnRight();
  Go();
  delay(750);
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
  delay(750);
  Stop();
  TurnLeft();
  delay(500);
  Go();
  Course();
}

//getting search room desicion
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

//head home function
void headHome(){
  UTurn();
  Go();
  while(Serial1.read() != 115){  
      lineSensors.read(lineSensorValues); 
      //if left sesnor gets a black reading...
      if(lineSensorValues[0] > QTR_THRESHOLD){ //left sensor detects line | sensor 0
         //go right for 1/4 second
         motors.setSpeeds(75, 0);
         delay(250);
         motors.setSpeeds(75, 75);
      //if right sensor gets a black boarder reading...
      }else if(lineSensorValues[2] > QTR_THRESHOLD){ //if right sensor detects black line| sensor 2
           //go ;left for 1/4 second
           motors.setSpeeds(0,  75);
           delay(250);
           motors.setSpeeds(75, 75);
      }        
  }     
  //got to the T-junction
  Stop();
  while(Serial1.read() != 108){
    if(Serial1.read() == 114){
      //take a right turn
      TurnRight();
      if(((lineSensorValues[2] > QTR_THRESHOLD) && (lineSensorValues[0] > QTR_THRESHOLD)) || (lineSensorValues[1] > QTR_THRESHOLD)){ //if center sensor detects black line |sensor 1
        //Turn left 
        TurnLeft();
        Go();
      }
      //if left sesnor gets a black reading...
      else if(lineSensorValues[0] > QTR_THRESHOLD){ //left sensor detects line | sensor 0
        //go right for 1/4 second
        motors.setSpeeds(75, 0);
        delay(250);
        motors.setSpeeds(75, 75);
        //if right sensor gets a black boarder reading...
        }else if(lineSensorValues[2] > QTR_THRESHOLD){ //if right sensor detects black line| sensor 2
          //go ;left for 1/4 second
          motors.setSpeeds(0,  75);
          delay(250);
          motors.setSpeeds(75, 75);
       }
    }
    //wait...
  }
  //turn left
  TurnLeft();
  if(((lineSensorValues[2] > QTR_THRESHOLD) && (lineSensorValues[0] > QTR_THRESHOLD)) || (lineSensorValues[1] > QTR_THRESHOLD)){ //if center sensor detects black line |sensor 1
    //Turn left 
    TurnLeft();
    Go();
  }
  //if left sesnor gets a black reading...
  else if(lineSensorValues[0] > QTR_THRESHOLD){ //left sensor detects line | sensor 0
    //go right for 1/4 second
    motors.setSpeeds(75, 0);
    delay(250);
    motors.setSpeeds(75, 75);
    //if right sensor gets a black boarder reading...
    }else if(lineSensorValues[2] > QTR_THRESHOLD){ //if right sensor detects black line| sensor 2
      //go ;left for 1/4 second
      motors.setSpeeds(0,  75);
      delay(250);
      motors.setSpeeds(75, 75);
   }   
}
