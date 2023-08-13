void setup() {
  // put your setup code here, to run once:
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(2, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:

  int buttonValue = digitalRead(2);

  if(buttonValue == LOW)
  {
    digitalWrite(13, HIGH);
    delay(500);
    digitalWrite(12, HIGH);
    delay(500);
    digitalWrite(11, HIGH);
    delay(500);  
  }
  else
  {
    digitalWrite(12, LOW);
    delay(500);
    digitalWrite(11, LOW);
    delay(500);
    digitalWrite(13, LOW);
    delay(500);
  }
}
