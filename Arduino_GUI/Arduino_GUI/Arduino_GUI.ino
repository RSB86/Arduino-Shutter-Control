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

  //Setup Outputs
  pinMode(13,OUTPUT);
  pinMode(M1_FWD,OUTPUT);
  pinMode(M1_REV,OUTPUT);

  //Setup Serial comms
  Serial.begin(57600);
}

void loop() {
  if (digitalRead(M1_REV_LIMIT))
  {
    digitalWrite(13,HIGH);
  }
  else
  {
    digitalWrite(13,LOW);
  }
  delay(10);
}

void serialEvent()
{
  String serial_input = Serial.readString();
  if (serial_input == "Connect")
  {
      while (!Serial.availableForWrite())
      {
      }
      Serial.println("Connection Successful");
      //Serial.flush();
  }
  else if (serial_input = "GetFeedback")
  {
    SendFeedback();    
  }
    else if (serial_input == "M_1_0")
    {
      digitalWrite(13,HIGH);
    }
      else if (serial_input == "M_1_1")
      {
        digitalWrite(13,LOW);
      }
  serial_input = "";
}


void SendFeedback()
{
  String msg; //Format: FB_MotorNumber_FWDLimt_REVLimit
  int i;
  for (i=1; i <= NUM_MOTORS; i++)
  {
    msg = msg + "FB_";
    msg = msg + i + "_";
    msg = msg + digitalRead(M1_FWD_LIMIT)+ "_"+ digitalRead(M1_REV_LIMIT);
    //Serial.flush();
  }  
  Serial.println(msg);
}
