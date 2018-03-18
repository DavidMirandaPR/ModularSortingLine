/*

 * Serial Port Monitor
 *
 * 
 */
 //Setup Constant Variables
 const int led_on = 1;
 const int led_off = 2;
//Setup Output

int ledPin_3 = 3;

//Setup message bytes

byte inputByte_0;

byte inputByte_1;

byte inputByte_2;

byte inputByte_3;

byte inputByte_4;

//Setup

void setup() {
  Serial.begin(9600); 
  pinMode(ledPin_3, OUTPUT);
  Serial.begin(9600);
  digitalWrite(ledPin_3, HIGH);//
  delay(250);//
  digitalWrite(ledPin_3, LOW);//
  delay(250);//
}

//Main Loop

void loop() {

  //Read Buffer
  if (Serial.available() == 5) 
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
  }
  //Check for start of Message
  if(inputByte_0 == 16)
  {       
    Serial.println("Looping"); 
    Serial.println(inputByte_0);
    Serial.println(inputByte_1);
    Serial.println(inputByte_2);
    Serial.println(inputByte_3);
    Serial.println(inputByte_4);
       //Detect Command type
       switch (inputByte_1) 
       {
          case 127:
             //Set PIN and value
             switch (inputByte_2)
            {
              case 4:
                if(inputByte_3 == 255)
                {
                  digitalWrite(inputByte_4, HIGH); 
                  break;
                }
                else
                {
                  digitalWrite(ledPin_3, LOW); 
                  break;
                }
              break;
            } 
            break;
          case 128:
            //Say hello
            Serial.print("HELLO FROM ARDUINO");
            break;
        } 
        //Clear Message bytes
        inputByte_0 = 0;
        inputByte_1 = 0;
        inputByte_2 = 0;
        inputByte_3 = 0;
        inputByte_4 = 0;
        //Let the PC know we are ready for more data
        Serial.print("-READY TO RECEIVE");
  }
}
