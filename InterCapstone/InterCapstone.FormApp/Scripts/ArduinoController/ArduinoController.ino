#include <Servo.h>

//Setup message bytes

byte inputByte_0;

byte inputByte_1;

byte inputByte_2;

byte inputByte_3;

byte inputByte_4;

byte inputByte_5;

byte inputByte_6;

byte inputByte_7;

byte inputByte_8;

byte inputByte_9;

Servo ServoOne;

//Setup

void setup() {
  Serial.begin(9600); 
  pinMode(3, OUTPUT);
  ServoOne.attach(9);
  Serial.begin(9600);
  digitalWrite(3, HIGH);//
  delay(250);//
  digitalWrite(3, LOW);//
  delay(250);//
}

//Main Loop

void loop() {

  //Read Buffer
  if (Serial.available() == 10) 
  {
    //Read buffer
    inputByte_0 = Serial.read();
    delay(100);    
    inputByte_1 = Serial.read();
    delay(100);      
    inputByte_2 = Serial.read();
    delay(100);      
    inputByte_3 = Serial.read();
    delay(100);
    inputByte_4 = Serial.read(); 
    delay(100);
    inputByte_5 = Serial.read();  
    delay(100);
    inputByte_6 = Serial.read(); 
    delay(100);
    inputByte_7 = Serial.read();
    delay(100);
    inputByte_8 = Serial.read(); 
    delay(100);
    inputByte_9 = Serial.read();  
  }
  //Check for start of Message
  if(inputByte_0 == 16)
  {       
       //Detect Command type
       switch (inputByte_1) 
       {
          case 127:
             //Set PIN and value
             switch (inputByte_2)
            {
              //PIN HIGH OR LOW
              case 4:
                if(inputByte_3 == 255)
                {
                  digitalWrite(inputByte_4, HIGH); 
                  break;
                }
                else
                {
                  digitalWrite(inputByte_4, LOW); 
                  break;
                }
                break;
              //OPEN DOOR
              case 5:
              //Servo One
                if(inputByte_3 == 9){
                  //ServoOne OPEN 16,127,5,9,1
                  if(inputByte_4 == 1){
                    for (int i = 10; i <= 180; i += 1){
                      ServoOne.write(i);
                      delay(15);
                    }
                  }
                  //ServoOne CLOSE 16,127,5,9,2
                  if(inputByte_4 == 2){
                    for (int i = 180; i >= 10; i -= 1){
                        ServoOne.write(i);
                        delay(15);
                      }
                  }
                }
                  break;
              default:
                break;
            } 
            break;
          case 128:
            //Say hello
            Serial.print("CONNECTED");
            break;
        } 
        //Let the PC know we are ready for more data
        if(inputByte_1 != 128){
          Serial.print("READY TO RECEIVE");
        }
        
         //Clear Message bytes
        inputByte_0 = 0;
        inputByte_1 = 0;
        inputByte_2 = 0;
        inputByte_3 = 0;
        inputByte_4 = 0;
        inputByte_5 = 0;
        inputByte_6 = 0;
        inputByte_7 = 0;
        inputByte_8 = 0;
        inputByte_9 = 0;
  }
}
