#include <Servo.h>
#include <LiquidCrystal.h>

Servo sM;

int redLED = 2;
int blueLED = 4;
int rsPin = 8;
int enablePin = 9;
int data4Pin = 10;
int data5Pin = 11;
int data6Pin = 12;
int data7Pin = 13;

int lightValue;

LiquidCrystal lcd(rsPin, enablePin, data4Pin, data5Pin, data6Pin, data7Pin);

void setup()
{
  pinMode(A1, INPUT);
  pinMode(redLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  lcd.begin(16,2);
  sM.attach(6);
  Serial.begin(9600);
}

void loop()
{
  lightValue = analogRead(A1);
  Serial.println(lightValue);
  delay(500);
  lcd.setCursor(0, 0);

  if(lightValue>400)
  {
    digitalWrite(redLED, HIGH);
    digitalWrite(blueLED, LOW);
    lcd.clear();
    lcd.print("Light is too");
    lcd.setCursor(0, 1);
    lcd.print("bright.");
    sM.write(90);
  }
  else
  {
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, HIGH);
    lcd.clear();
    lcd.print("Please turn");
    lcd.setCursor(0, 1);
    lcd.print("light on.");
    sM.write(0);
  }
  
}
