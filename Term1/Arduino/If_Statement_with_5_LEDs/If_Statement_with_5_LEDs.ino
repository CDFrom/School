int redLED = 10;
int blueLED = 8;
int greenLED =6;
int yellowLED = 3;
int whiteLED = 2;

String colorLED;

void setup() {
  // put your setup code here, to run once:
  pinMode(redLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  pinMode(greenLED, OUTPUT);
  pinMode(yellowLED, OUTPUT);
  pinMode(whiteLED, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("Enter color ");
  while(Serial.available() == 0){

  }

  colorLED = Serial.readStringUntil('\n');
  Serial.println(colorLED);
  if(colorLED == "red" || colorLED == "Red"){
    digitalWrite(redLED, HIGH);
    digitalWrite(blueLED, LOW);
    digitalWrite(greenLED, LOW);
    digitalWrite(yellowLED, LOW);
    digitalWrite(whiteLED, LOW);
  }
  if(colorLED == "blue" || colorLED == "Blue"){
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, HIGH);
    digitalWrite(greenLED, LOW);
    digitalWrite(yellowLED, LOW);
    digitalWrite(whiteLED, LOW);
  }
  if(colorLED == "green" || colorLED == "Green"){
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, LOW);
    digitalWrite(greenLED, HIGH);
    digitalWrite(yellowLED, LOW);
    digitalWrite(whiteLED, LOW);
  }
  if(colorLED == "yellow" || colorLED == "Yellow"){
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, LOW);
    digitalWrite(greenLED, LOW);
    digitalWrite(yellowLED, HIGH);
    digitalWrite(whiteLED, LOW);
  }
  if(colorLED == "white" || colorLED == "White"){
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, LOW);
    digitalWrite(greenLED, LOW);
    digitalWrite(yellowLED, LOW);
    digitalWrite(whiteLED, HIGH);
  }
  if(colorLED != "red" && colorLED != "Red" && colorLED != "blue" && colorLED != "Blue" && colorLED != "green" && colorLED != "Green" && colorLED != "yellow" && colorLED != "Yellow" && colorLED != "white" && colorLED != "White"){
    Serial.println("Color does not exist in this range.");
    digitalWrite(redLED, LOW);
    digitalWrite(blueLED, LOW);
    digitalWrite(greenLED, LOW);
    digitalWrite(yellowLED, LOW);
    digitalWrite(whiteLED, LOW);
  }
}
