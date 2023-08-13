#include <Servo.h>

Servo myServoMotor;
int i;
int x, y;

void setup() {
  // put your setup code here, to run once:
  myServoMotor.attach(7);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  //servoMotor290DegreeMovement();
  //servoMotor90DegreeMovement();
  //servoMotor180DegreeMovement();
  //userInput();
  myServoMotor.write(30);
  delay(1000);
  myServoMotor.write(180);
  delay(1500);
}

void userInput()
{
  Serial.println("What number do you want to square?");
  while(Serial.available() == 0)
  {
    
  }
  x = Serial.parseInt();
  y = x_square(x);
  Serial.println(x);
  Serial.print("Square is = ");
  Serial.println(y);
}

int x_square(int x)
{
  int answer;
  answer = x * x;
  return answer;
}

void servoMotor90DegreeMovement(){
  for(i=0; i<90; i+=5)
  {
    myServoMotor.write(i);
    Serial.println(i);
    delay(150);
  }
  for(i=90; i>=0; i-=5)
  {
    myServoMotor.write(i);
    Serial.println(i);
    delay(150);
  }
}

void servoMotor180DegreeMovement(){
  for(i=0; i<180; i+=5)
  {
    myServoMotor.write(i);
    Serial.println(i);
    delay(150);
  }
  for(i=180; i>=0; i-=5)
  {
    myServoMotor.write(i);
    Serial.println(i);
    delay(150);
  }
}

void servoMotor290DegreeMovement(){
  for(i=0; i<290; i+=10)
  {
    myServoMotor.write(i);
    Serial.println(i);
    delay(150);
  }
  for(i=290; i>=0; i-=10)
  {
    myServoMotor.write(i);
    Serial.println(i);
    delay(150);
  }
}
