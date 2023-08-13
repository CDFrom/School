#include <LiquidCrystal.h>
#include <Adafruit_Keypad.h>
#include <Adafruit_Keypad_Ringbuffer.h>
#include <Key.h>
#include <Keypad.h>

const byte Rows = 4;
const byte Columns = 4;

int redLED = 2;
int greenLED = 4;
int rsPin = 8;
int enablePin = 9;
int data4Pin = 10;
int data5Pin = 11;
int data6Pin = 12;
int data7Pin = 13;

char keypadArray[Rows][Columns] = {
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

byte rowPins[Rows] = {22, 24, 26, 28};
byte columnPins[Columns] = {30, 32, 34, 36};

LiquidCrystal lcd(rsPin, enablePin, data4Pin, data5Pin, data6Pin, data7Pin);
Keypad KeyPadRed = Keypad(makeKeymap(keypadArray), rowPins, columnPins, Rows, Columns);
Adafruit_Keypad customKeypad = Adafruit_Keypad(makeKeymap(keypadArray), rowPins, columnPins, Rows, Columns);

String password = "2021";
String userInput;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  customKeypad.begin();
  lcd.begin(16,2);
  pinMode(redLED, OUTPUT);
  pinMode(greenLED, OUTPUT);
  Serial.println("If you want to clear press *");
  Serial.println("If you want to submit press #");
  Serial.print("Please enter your password: ");
}

void loop() {
  // put your main code here, to run repeatedly:
  //  char x = KeyPadRed.getKey();
  //
  //  if(x){
  //    Serial.println(x);
  //  }

  customKeypad.tick();

  digitalWrite(greenLED, LOW);
  digitalWrite(redLED, HIGH);

  while (customKeypad.available()) {
    keypadEvent e = customKeypad.read();
    char keypadChar = (char)e.bit.KEY;
    if (e.bit.EVENT == KEY_JUST_PRESSED)
    {
      if (keypadChar == '*')
      {
        userInput = "";
        Serial.println("\nUser cleared the input.");
        lcd.setCursor(0,0);
        lcd.print("Input has been");
        lcd.setCursor(0,1);
        lcd.print("cleared.");
        delay(1000);
        lcd.clear();
        Serial.println();
        Serial.print("Please enter your password: ");
      }
      else
      {
        if(keypadChar == '#')
        {
          if(userInput == password)
          {
            Serial.println("\nThe entered password is correct!");
            digitalWrite(redLED, LOW);
            digitalWrite(greenLED, HIGH);
            lcd.setCursor(0,0);
            lcd.print("Password is");
            lcd.setCursor(0,1);
            lcd.print("Correct");
            delay(6000); //6000 for testing 60000 for normal use
            lcd.clear();
            Serial.println();
            Serial.print("Please enter your password: ");
            
          }
          else
          {
            Serial.println("\nThe entered password is incorrect. Please try again.");
            digitalWrite(greenLED, LOW);
            digitalWrite(redLED, HIGH);
            lcd.setCursor(0,0);
            lcd.print("Password is");
            lcd.setCursor(0,1);
            lcd.print("Incorrect");
            delay(1000);
            lcd.clear();
            Serial.println();
            Serial.print("Please enter your password: ");
          }
          userInput = "";
        }
        else
        {
          userInput += keypadChar;
          Serial.print(keypadChar);
        }
      }
    }
  }

}
