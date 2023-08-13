int yellowLED = 13;
int redRGBLED = 10;
int greenRGBLED = 9;
int blueRGBLED = 8;
int redLED = 4;
int blueLED = 3;
int greenLED = 2;

int brightness;

void setup() {
  // put your setup code here, to run once:
  pinMode(yellowLED, OUTPUT);
  pinMode(redRGBLED, OUTPUT);
  pinMode(greenRGBLED, OUTPUT);
  pinMode(blueRGBLED, OUTPUT);
  pinMode(redLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  pinMode(greenLED, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  /*for(brightness = 0; brightness <= 255; brightness += 5)
  {
    analogWrite(yellowLED, brightness);
    Serial.println(brightness);
    delay(30);
  }
  for(brightness = 255; brightness>=0; brightness -= 1)
  {
    analogWrite(yellowLED, brightness);
    Serial.println(brightness);
    delay(50);
  }
  
  brightness = 0;
  
  while(brightness<=255)
  {
    analogWrite(blueLED, brightness);
    delay(30);
    brightness+=5;
  }

  brightness = 255;
  
  while(brightness>=0)
  {
    analogWrite(blueLED, brightness);
    delay(30);
    brightness-=1;
  }*/
  for(brightness=0; brightness<=255; brightness+=5)
  {
    analogWrite(redRGBLED, brightness);
    delay(30);
  }
  for(brightness=0; brightness<=255; brightness+=5)
  {
    analogWrite(greenRGBLED, brightness);
    delay(30);
  }
  for(brightness=0; brightness<=255; brightness+=5)
  {
    analogWrite(blueRGBLED, brightness);
    delay(30);
  }
  for(brightness=255; brightness>=0; brightness-=5)
  {
    analogWrite(redRGBLED, brightness);
    delay(30);
  }
  for(brightness=255; brightness>=0; brightness-=5)
  {
    analogWrite(greenRGBLED, brightness);
    delay(30);
  }
  for(brightness=255; brightness>=0; brightness-=5)
  {
    analogWrite(blueRGBLED, brightness);
    delay(30);
  }
}
