//Number of motors
#define NUM_MOTORS 5

//Input pin definition
#define M1_FWD_LIMIT 2
#define M1_REV_LIMIT 3
#define M2_FWD_LIMIT 4
#define M2_REV_LIMIT 5
#define M3_FWD_LIMIT 6
#define M3_REV_LIMIT 7
#define M4_FWD_LIMIT 8
#define M4_REV_LIMIT 9
#define M5_FWD_LIMIT 10
#define M5_REV_LIMIT 11

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

bool waitingToSendData;
unsigned long currentTime;
bool pcConnected = 0;


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
  /* INSERT CODE TO STOP MOTOR WHEN RUNNING */
  /* ************************************** */

  
  delay(10); //Remove after including motor code
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
  /* INSERT CODE TO START MOTOR WHEN RUNNING */
  /* *************************************** */
  
  }
}


//Function to create messag with Inputs feedback
void SendFeedback()
{
  String msg; //Format: FB_MotorNumber_FWDLimt_REVLimit_FWDOutput_REVOutput
  int i;
  for (i=1; i <= NUM_MOTORS; i++)
  {
    msg = msg + "FB_";
    msg = msg + i + "_";
    msg = msg + digitalRead(i*2)+ "_"+ digitalRead(i*2+1);
    msg = msg + "_" + digitalRead(i*2+20)+ "_"+ digitalRead(i*2+21);
    //Serial.flush();
  }  
  Serial.println(msg);
}
