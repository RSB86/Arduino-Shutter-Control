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

  if (digitalRead(12) == HIGH)
  {
    Serial.write("M1_Left_Low");
  }
  else
  {
    Serial.write("M1_Left_High");
  }
  
}
