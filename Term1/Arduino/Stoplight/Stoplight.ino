int redLED = 13;
int greenLED = 12;
int blueLED = 11;
int s40 = 40000;
int s30 = 30000;
int s3 = 3000;


void setup() {
  // put your setup code here, to run once:
  pinMode(redLED, OUTPUT); //Turn on for 40 seconds then turn off for 33 seconds
  pinMode(greenLED, OUTPUT); //Turn on for 30 seconds then turn off for 43 seconds
  pinMode(blueLED, OUTPUT); //Turn on for 3 seconds turn off for 40 seconds and 30 seconds
}

void loop() {
  // put your main code here, to run repeatedly:
    digitalWrite(redLED, HIGH);
    delay(40000);
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, HIGH);
    delay(3000);  
    digitalWrite(blueLED, LOW);
    digitalWrite(greenLED, HIGH);
    delay(30000);
    digitalWrite(greenLED, LOW);
    digitalWrite(blueLED, HIGH);
    delay(3000);  
    digitalWrite(blueLED, LOW);
}
