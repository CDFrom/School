#include <DHT.h>
#include <DHT_U.h>
#include <LiquidCrystal.h>
#define Type DHT11

int TempHumiditySensorPin = 2;
int redLED = 4;
int blueLED = 5;
int rsPin = 8;
int enablePin = 9;
int data4Pin = 10;
int data5Pin = 11;
int data6Pin = 12;
int data7Pin = 13;

LiquidCrystal lcd(rsPin, enablePin, data4Pin, data5Pin, data6Pin, data7Pin);
DHT HumidityTemp(TempHumiditySensorPin, Type);

void setup() {
  // put your setup code here, to run once:
  pinMode(redLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  lcd.begin(16,2);
  HumidityTemp.begin();
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  float humidity = HumidityTemp.readHumidity();
  float temp = HumidityTemp.readTemperature();
  
  lcd.setCursor(0, 0);
  lcd.print("Temp: ");
  lcd.print(temp);
  lcd.setCursor(0, 1);
  lcd.print("Humidity: ");
  lcd.print(humidity);

  Serial.print("Humidity is: ");
  Serial.println(humidity);
  Serial.print("Temperature is: ");
  Serial.println(temp);

  if(temp>23)
  {
    digitalWrite(redLED, HIGH);
  }
  else{
    digitalWrite(redLED, LOW);
  }

  if(humidity>=28)
  {
    digitalWrite(blueLED, HIGH);
  }
  else{
    digitalWrite(blueLED,LOW);
  }

  delay(5000);
}
