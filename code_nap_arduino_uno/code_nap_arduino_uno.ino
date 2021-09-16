int incomingByte = 0;   // dùng để lưu giá trị được gửi
int led = 13 ;
int relay2 = 5;
int relay3 = 6 ;
unsigned long time;

void setup()
{
  Serial.begin(9600);     // mở serial với baudrate 9600
  pinMode(led, OUTPUT);
  pinMode(relay2, OUTPUT);
  pinMode(relay3, OUTPUT);
  time = millis();

}

void loop() {
  if ( (unsigned long) (millis() - time) > 1000)
    {
     int value = analogRead(A0);
    value = map(value, 0, 1023, 0, 255);
    Serial.println(value);
    time = millis();
    }
    
  // nếu còn có thể đọc được
  if (Serial.available() > 0)
  {
    // đọc chữ liệu
    incomingByte = Serial.read();

    // trả về những gì nhận được

    // relay1
    if (incomingByte == 65)
    {
      digitalWrite(led, HIGH);
    }
    if (incomingByte == 66)
    {
      digitalWrite(led, LOW);
    }
    //relay2
    if (incomingByte == 67)
    {
      digitalWrite(relay2, HIGH);
    }
    if (incomingByte == 68)
    {
      digitalWrite(relay2, LOW);
    }
    // relay3
    if (incomingByte == 69)
    {
      digitalWrite(relay3, HIGH);
    }
    if (incomingByte == 70)
    {
      digitalWrite(relay3, LOW);
    }

  }
}
