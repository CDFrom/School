int blueLED = 8;
int numberOfBlink;
String msg = "How many times do you want the LED to blink?";

void setup() {
  // put your setup code here, to run once:
  pinMode(blueLED, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println(msg);
  while(Serial.available() == 0){
    
  }
  numberOfBlink = Serial.parseInt();
  for (int i = 1; i <= numberOfBlink; i++){
    digitalWrite(blueLED, HIGH);
    delay(1000);
    digitalWrite(blueLED, LOW);
    delay(1000);
  }
}
