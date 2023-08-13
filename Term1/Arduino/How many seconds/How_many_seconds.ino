int blueLED = 8;
int greenLED = 7;
int sec;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(blueLED, OUTPUT);
  pinMode(greenLED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("How many seconds should the blue LED be on?");
  while(Serial.available() == 0){
    digitalWrite(greenLED, HIGH);
  }
  sec = Serial.parseInt();
  for (int i = 1; i <= sec; i++){
    digitalWrite(greenLED, LOW);
    digitalWrite(blueLED, HIGH);
    delay(sec*1000);
    digitalWrite(blueLED, LOW);
  }
}
