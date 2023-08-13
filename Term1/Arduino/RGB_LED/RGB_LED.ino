int redRGBLed = 12;
int blueRGBLed = 9;
int greenRGBLed = 10;
String colorLED;

void setup() {
  // put your setup code here, to run once:
  pinMode(redRGBLed, OUTPUT);
  pinMode(blueRGBLed, OUTPUT);
  pinMode(greenRGBLed, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("Enter color: ");
  while(Serial.available() == 0){
    
  }
  colorLED = Serial.readStringUntil('\n');
  Serial.println(colorLED);
  if(colorLED == "red" || colorLED == "Red"){
    Serial.print("*****************");
    Serial.println(colorLED);
    digitalWrite(redRGBLed, HIGH);
    digitalWrite(blueRGBLed, LOW);
    digitalWrite(greenRGBLed, LOW);
  }
  if(colorLED == "blue" || colorLED == "Blue"){
    digitalWrite(redRGBLed, LOW);
    digitalWrite(blueRGBLed, HIGH);
    digitalWrite(greenRGBLed, LOW);
  }
  if(colorLED == "green" || colorLED == "Green"){
    digitalWrite(redRGBLed, LOW);
    digitalWrite(blueRGBLed, LOW);
    digitalWrite(greenRGBLed, HIGH);
  }
  else
  if(colorLED == "orange" || colorLED == "Orange"){
    digitalWrite(redRGBLed, 255);
    digitalWrite(blueRGBLed, LOW);
    digitalWrite(greenRGBLed, 165);
  }
  
}
