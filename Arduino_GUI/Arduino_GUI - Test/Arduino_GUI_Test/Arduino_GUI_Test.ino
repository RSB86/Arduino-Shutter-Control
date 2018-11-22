//Number of motors
#define NUM_MOTORS 5

//Input pin definition
#define M1_FWD_LIMIT 10
#define M1_REV_LIMIT 11
#define M2_FWD_LIMIT 2
#define M2_REV_LIMIT 3
#define M3_FWD_LIMIT 4
#define M3_REV_LIMIT 5
#define M4_FWD_LIMIT 6
#define M4_REV_LIMIT 7
#define M5_FWD_LIMIT 8
#define M5_REV_LIMIT 9

//Output pin defintion
#define M1_FWD 22
#define M1_REV 23
#define M2_FWD 24
#define M2_REV 25
#define M3_FWD 26
#define M3_REV 27
#define M4_FWD 28
#define M4_REV 29
#define M5_FWD 30
#define M5_REV 31

unsigned long Clock_Started1_FWD = 0;//motor 1
unsigned long Time_elapsed1_FWD = 0;
unsigned long Clock_Started2_FWD = 0;//motor 2
unsigned long Time_elapsed2_FWD = 0;
unsigned long Clock_Started3_FWD = 0;//motor 3
unsigned long Time_elapsed3_FWD = 0;
unsigned long Clock_Started4_FWD = 0;//motor 4
unsigned long Time_elapsed4_FWD = 0;
unsigned long Clock_Started5_FWD = 0;//motor 5
unsigned long Time_elapsed5_FWD = 0;

unsigned long Clock_Started1_REV = 0;//motor 1
unsigned long Time_elapsed1_REV = 0;
unsigned long Clock_Started2_REV = 0;//motor 2
unsigned long Time_elapsed2_REV = 0;
unsigned long Clock_Started3_REV = 0;//motor 3
unsigned long Time_elapsed3_REV = 0;
unsigned long Clock_Started4_REV = 0;//motor 4
unsigned long Time_elapsed4_REV = 0;
unsigned long Clock_Started5_REV = 0;//motor 5
unsigned long Time_elapsed5_REV = 0;

int M1_FWD_Running = 0;//motor 1
int M1_REV_Running = 0;
int M2_FWD_Running = 0;//motor 2
int M2_REV_Running = 0;
int M3_FWD_Running = 0;//motor 3
int M3_REV_Running = 0;
int M4_FWD_Running = 0;//motor 4
int M4_REV_Running = 0;
int M5_FWD_Running = 0;//motor 5
int M5_REV_Running = 0;

void setup() {
  // put your setup code here, to run once:
  //Setup INPUTS
  pinMode(M1_FWD_LIMIT,INPUT_PULLUP);
  pinMode(M1_REV_LIMIT,INPUT_PULLUP);
  pinMode(M2_FWD_LIMIT,INPUT_PULLUP);
  pinMode(M2_REV_LIMIT,INPUT_PULLUP);
  pinMode(M3_FWD_LIMIT,INPUT_PULLUP);
  pinMode(M3_REV_LIMIT,INPUT_PULLUP);
  pinMode(M4_FWD_LIMIT,INPUT_PULLUP);
  pinMode(M4_REV_LIMIT,INPUT_PULLUP);
  pinMode(M5_FWD_LIMIT,INPUT_PULLUP);
  pinMode(M5_REV_LIMIT,INPUT_PULLUP);

  //Setup Outputs
  pinMode(13,OUTPUT);
  pinMode(M1_FWD,OUTPUT);
  pinMode(M1_REV,OUTPUT);
  pinMode(M2_FWD,OUTPUT);
  pinMode(M2_REV,OUTPUT);
  pinMode(M3_FWD,OUTPUT);
  pinMode(M3_REV,OUTPUT);
  pinMode(M4_FWD,OUTPUT);
  pinMode(M4_REV,OUTPUT);
  pinMode(M5_FWD,OUTPUT);
  pinMode(M5_REV,OUTPUT);

  //Setup Serial comms
  Serial.begin(57600);
  Serial.setTimeout(50);
}

void loop() {

  /* ************************************** */
  
  if (M1_REV_Running ){
    Time_elapsed1_REV = millis() - Clock_Started1_REV;
    if (digitalRead(M1_REV_LIMIT) == LOW || Time_elapsed1_REV > 10000)
    {
      digitalWrite(M1_FWD,LOW); // turn motor off
      digitalWrite(M1_REV,LOW);
      M1_REV_Running = LOW;
    }
  }
  
  if (M1_FWD_Running ){
    Time_elapsed1_FWD = millis() - Clock_Started1_FWD;
    if (digitalRead(M1_FWD_LIMIT) == LOW || Time_elapsed1_FWD > 10000)
    {
      digitalWrite(M1_FWD,LOW); // turn motor off
      digitalWrite(M1_REV,LOW);
      M1_FWD_Running = LOW;
    }
  }

  if (M2_REV_Running){
    Time_elapsed2_REV = millis() - Clock_Started2_REV;
    if (digitalRead(M2_REV_LIMIT) == LOW || Time_elapsed2_REV > 10000)
    {
      digitalWrite(M2_FWD,LOW); // turn motor off
      digitalWrite(M2_REV,LOW);
      M2_REV_Running = LOW;
    }
  }
    
  if (M2_FWD_Running){
    Time_elapsed2_FWD = millis() - Clock_Started2_FWD;
    if (digitalRead(M2_FWD_LIMIT) == LOW || Time_elapsed2_FWD > 10000)
    {
      digitalWrite(M2_FWD,LOW); // turn motor off
      digitalWrite(M2_REV,LOW);
      M2_FWD_Running = LOW;
    }
  }

  if (M3_REV_Running){
    Time_elapsed3_REV = millis() - Clock_Started3_REV;
    if (digitalRead(M3_REV_LIMIT) == LOW || Time_elapsed3_REV > 10000)
    {
      digitalWrite(M3_FWD,LOW); // turn motor off
      digitalWrite(M3_REV,LOW);
      M3_REV_Running = LOW;
    }
  }
    
  if (M3_FWD_Running){
    Time_elapsed3_FWD = millis() - Clock_Started3_FWD;
    if (digitalRead(M3_FWD_LIMIT) == LOW || Time_elapsed3_FWD > 10000)
    {
      digitalWrite(M3_FWD,LOW); // turn motor off
      digitalWrite(M3_REV,LOW);
      M3_FWD_Running = LOW;
    }
  }

  if (M4_REV_Running){
    Time_elapsed4_REV = millis() - Clock_Started4_REV;
    if (digitalRead(M4_REV_LIMIT) == LOW || Time_elapsed4_REV > 10000)
    {
      digitalWrite(M4_FWD,LOW); // turn motor off
      digitalWrite(M4_REV,LOW);
      M4_REV_Running = LOW;
    }
  }
    
  if (M4_FWD_Running){
    Time_elapsed4_FWD = millis() - Clock_Started4_FWD;
    if (digitalRead(M4_FWD_LIMIT) == LOW || Time_elapsed4_FWD > 10000)
    {
      digitalWrite(M4_FWD,LOW); // turn motor off
      digitalWrite(M4_REV,LOW);
      M4_FWD_Running = LOW;
    }
  }

  if (M5_REV_Running){
    Time_elapsed5_REV = millis() - Clock_Started5_REV;
    if (digitalRead(M5_REV_LIMIT) == LOW || Time_elapsed5_REV > 10000)
    {
      digitalWrite(M5_FWD,LOW); // turn motor off
      digitalWrite(M5_REV,LOW);
      M5_REV_Running = LOW;
    }
  }
      
  if (M5_FWD_Running){
    Time_elapsed5_FWD = millis() - Clock_Started5_FWD;
    if (digitalRead(M5_FWD_LIMIT) == LOW || Time_elapsed5_FWD > 10000)
    {
      digitalWrite(M5_FWD,LOW); // turn motor off
      digitalWrite(M5_REV,LOW);
      M5_FWD_Running = LOW;
    }
  }
  /* ************************************** */

  delay(20);
}

void serialEvent()
{
  String serial_input = Serial.readString();
  if (serial_input == "Connect")
  {
      Serial.println("Connection Successful");
  }
  else if (serial_input == "GetFeedback")
  {
    SendFeedback();    
  }
  else 
  {
    ParseMotorToRun (serial_input);
  }
    
  serial_input = "";
}

void ParseMotorToRun(String msg)
{
  int firstUnderscore,secondUnderscore;
  String MotorNumberStr, DirectionStr;
  int MotorNumber, Direction;
  
  if (msg.startsWith("M"))
  {
    
    firstUnderscore = msg.indexOf('_');
    secondUnderscore = msg.lastIndexOf('_');
    MotorNumberStr = msg.substring(firstUnderscore+1,secondUnderscore);
    DirectionStr = msg.charAt(secondUnderscore+1);
    MotorNumber = MotorNumberStr.toInt();
    Direction = DirectionStr.toInt();
  }
  else
  {
    MotorNumber = 0;
    Direction = 0;
  }

  /* *************************************** */
if  (MotorNumber == 1 && Direction == 0) {
    Clock_Started1_FWD = millis() ; //start run time
    digitalWrite(M1_FWD, HIGH); //turn motor left
    digitalWrite(M1_REV, LOW); 
    Time_elapsed1_FWD = 0; 
    M1_FWD_Running = HIGH;

}
  if  (MotorNumber == 1 && Direction == 1) {
    Clock_Started1_REV = millis() ; //start run time
    digitalWrite(M1_FWD, LOW);
    digitalWrite(M1_REV, HIGH); //turn motor right
    Time_elapsed1_REV = 0;
    M1_REV_Running = HIGH; 

}
if  (MotorNumber == 2 && Direction == 0) {
    Clock_Started2_FWD = millis() ; //start run time
    digitalWrite(M2_FWD, HIGH); //turn motor left
    digitalWrite(M2_REV, LOW); 
    Time_elapsed2_FWD = 0; 
    M2_FWD_Running = HIGH;

}
  if  (MotorNumber == 2 && Direction == 1) {
    Clock_Started2_REV = millis() ; //start run time
    digitalWrite(M2_FWD, LOW);
    digitalWrite(M2_REV, HIGH); //turn motor right
    Time_elapsed2_REV = 0;
    M2_REV_Running = HIGH; 

}
if  (MotorNumber == 3 && Direction == 0) {
    Clock_Started3_FWD = millis() ; //start run time
    digitalWrite(M3_FWD, HIGH); //turn motor left
    digitalWrite(M3_REV, LOW); 
    Time_elapsed3_FWD = 0; 
    M3_FWD_Running = HIGH;

}
  if  (MotorNumber == 3 && Direction == 1) {
    Clock_Started3_REV = millis() ; //start run time
    digitalWrite(M3_FWD, LOW);
    digitalWrite(M3_REV, HIGH); //turn motor right
    Time_elapsed3_REV = 0;
    M3_REV_Running = HIGH; 

}
if  (MotorNumber == 4 && Direction == 0) {
    Clock_Started4_FWD = millis() ; //start run time
    digitalWrite(M4_FWD, HIGH); //turn motor left
    digitalWrite(M4_REV, LOW); 
    Time_elapsed4_FWD = 0; 
    M4_FWD_Running = HIGH;

}
  if  (MotorNumber == 4 && Direction == 1) {
    Clock_Started4_REV = millis() ; //start run time
    digitalWrite(M4_FWD, LOW);
    digitalWrite(M4_REV, HIGH); //turn motor right
    Time_elapsed4_REV = 0;
    M4_REV_Running = HIGH; 

}
if  (MotorNumber == 5 && Direction == 0) {
    Clock_Started5_FWD = millis() ; //start run time
    digitalWrite(M5_FWD, HIGH); //turn motor left
    digitalWrite(M5_REV, LOW); 
    Time_elapsed5_FWD = 0; 
    M5_FWD_Running = HIGH;

}
  if  (MotorNumber == 5 && Direction == 1) {
    Clock_Started5_REV = millis() ; //start run time
    digitalWrite(M5_FWD, LOW);
    digitalWrite(M5_REV, HIGH); //turn motor right
    Time_elapsed5_REV = 0;
    M5_REV_Running = HIGH; 

}
  /* *************************************** */
  
}



//Function to create messag with Inputs feedback
void SendFeedback()
{
  String msg=""; //Format: FB_MotorNumber_FWDLimt_REVLimit_FWDOutput_REVOutput
  int i;
  msg = msg + "FB_"; // construct message for motor 1 here because motor 1 in development board is connected to pins 10 and 11 instead of 2 and 3
  msg = msg + 1 + "_";
  msg = msg + !digitalRead(M1_FWD_LIMIT)+ "_"+ !digitalRead(M1_REV_LIMIT);
  msg = msg + "_" + digitalRead(M1_FWD)+ "_"+ digitalRead(M1_REV);
  for (i=1; i <= NUM_MOTORS; i++)
  {
    msg = msg + "FB_";
    msg = msg + (i+1) + "_";
    msg = msg + !digitalRead(i*2)+ "_"+ !digitalRead(i*2+1);
    msg = msg + "_" + digitalRead(i*2+22)+ "_"+ digitalRead(i*2+23);
    //Serial.flush();
  }  
  Serial.println(msg);
}
