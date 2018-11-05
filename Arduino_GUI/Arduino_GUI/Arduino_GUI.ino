bool waitingToSendData;
unsigned long currentTime;
bool pcConnected = 0;


void setup() {
  // put your setup code here, to run once:
  pinMode(13,OUTPUT);
  pinMode(12,INPUT_PULLUP);
  Serial.begin(57600);
}

void loop() {
  // put your main code here, to run repeatedly:
  String serial_input = Serial.readString();
  
  if (serial_input != "")
  {
    if (serial_input == "Connect")
    {
      Serial.write("Connection Successful");
      serial_input = "";
      Serial.flush();
      digitalWrite(13,!digitalRead(13));
    }
    else if (serial_input == "M1_Left")
    {
      digitalWrite(13,HIGH);
    }
    else if (serial_input == "M1_Right")
    {
      digitalWrite(13,LOW);
    }
  }

  if (!waitingToSendData)
  {
    currentTime = millis();
    waitingToSendData = HIGH;
  }
  if (pcConnected)
  {
      if (waitingToSendData)
      {
        if ((millis() - currentTime) > 2000)
        {
            if (digitalRead(12) == HIGH)
            {
              Serial.write("M1_Left_Low");
            }
            else
            {
              Serial.write("M1_Left_High");
            }
            waitingToSendData = LOW;
         }
      }
   }
}
