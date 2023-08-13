#include <LiquidCrystal.h>

int trigPin = 2;
int echoPin = 3;
int pushButton = 5;
int rsPin = 8;
int enablePin = 9;
int data4Pin = 10;
int data5Pin = 11;
int data6Pin = 12;
int data7Pin = 13;

LiquidCrystal lcd(rsPin, enablePin, data4Pin, data5Pin, data6Pin, data7Pin);

void setup() {
  // put your setup code here, to run once:
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  pinMode(pushButton, INPUT);
  lcd.begin(16,2);
}

void loop() {
  // put your main code here, to run repeatedly:
  int buttonValue = digitalRead(pushButton);
  if(buttonValue == LOW)
  {  
    digitalWrite(trigPin, LOW);
    delayMicroseconds(10);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(20);
    digitalWrite(trigPin, LOW);
    
    long duration = pulseIn(echoPin, HIGH);

    long cm = duration / 2 / 29.1;

    lcd.setCursor(0, 0);
    lcd.print("Distance in cm: ");
    lcd.setCursor(0, 1);
    lcd.print(cm);
    delay(500);
    lcd.clear();
  }
}
