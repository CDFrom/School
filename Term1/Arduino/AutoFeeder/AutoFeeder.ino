#include <Servo.h>
#include <Key.h>
#include <Keypad.h>
#include <LiquidCrystal.h>
#include <Wire.h>
#include <RTClib.h>

//Pin Setup
int water = A0;
int foodLow = 2;
int foodGood = 3;
int trigPin = 4;
int echoPin = 5;
int rsPin = 8;
int enablePin = 9;
int data4Pin = 10;
int data5Pin = 11;
int data6Pin = 12;
int data7Pin = 13;
int waterGood = 40;
int button = 41;
int waterLow = 42;
int waterPower = 52; //To control when power activates the water sensor

//Keypad setup
const byte Rows = 4;
const byte Cols = 4;
char daysOfWeek[7][12] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
char monthsOfYear[12][12] = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

char keypadArray[Rows][Cols] = {
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

byte rowPins[Rows] = {22, 24, 26, 28};
byte colPins[Cols] = {30, 32, 34, 36};

//Other initializations
int autoFeedHour = 5;
int autoFeedMinute = 30;
int numOfFeed = 1;

Servo feeder;
RTC_DS1307 rtc;
LiquidCrystal lcd(rsPin, enablePin, data4Pin, data5Pin, data6Pin, data7Pin);
Keypad myKeyPad = Keypad(makeKeymap(keypadArray), rowPins, colPins, Rows, Cols);

void setup () {
  pinMode(button, INPUT);
  pinMode(waterPower, OUTPUT);
  digitalWrite(waterPower, LOW);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  pinMode(foodGood, OUTPUT);
  pinMode(foodLow, OUTPUT);
  pinMode(waterGood, OUTPUT);
  pinMode(waterLow, OUTPUT);
  checkFoodLevel();
  checkWaterLevel();
  lcd.begin(16, 2);
  rtc.begin();
  feeder.attach(7);
  feeder.write(0);
  //rtc.adjust(DateTime(F(__DATE__), F(__TIME__))); //Run once to set clock based on computer time then should be fine
}

void loop () {
  DateTime now = rtc.now();
  showTime(now);

  char x = myKeyPad.getKey();
  if (x == 'A') setTime(now);
  if (x == 'B') setAutoFeed();
  if (x == 'C') setNumOfFeed();
  if (x == 'D'){
    checkFoodLevel();
    checkWaterLevel();
  }

  if (now.hour() % 12 == autoFeedHour && now.minute() == autoFeedMinute && now.second() == 0) {
    for (int i = 0; i < numOfFeed; i++) {
      feed();
    }
  }

  int buttonValue = digitalRead(button);
  if (buttonValue == LOW) {
    feed();
  }

  if (now.minute() == 0 && now.second() == 0){
    checkFoodLevel();
    checkWaterLevel();
  }
}

void showTime(DateTime now) {
  String str = "PM";
  if (now.hour() < 12) str = "AM";
  lcd.setCursor(0, 0);
  lcd.print(" Time: ");
  if (now.hour() == 0) {
    lcd.print("12");
  } else if (now.hour() < 10) {
    lcd.print(" ");
    lcd.print(now.hour(), DEC);
  } else if (now.hour() > 12) {
    if (now.hour() < 21) lcd.print(" ");
    if (now.hour() % 12 == 0) lcd.print("12");
    else lcd.print(now.hour() % 12);
  } else {
    lcd.print(now.hour(), DEC);
  }
  lcd.print(':');
  if (now.minute() < 10) {
    lcd.print(0);
    lcd.print(now.minute(), DEC);
  } else {
    lcd.print(now.minute(), DEC);
  }
  lcd.print(" ");
  lcd.print(str);
  lcd.print(" ");
  lcd.setCursor(0, 1);
  lcd.print(daysOfWeek[now.dayOfTheWeek()]);
  lcd.print(". ");
  lcd.print(now.day(), DEC);
  lcd.print('/');
  lcd.print(monthsOfYear[now.month() - 1]);
  lcd.print("/");
  lcd.print(now.year(), DEC);
}

void setTime(DateTime now) {
  lcd.clear();
  for (int i = 0; i < 5;) {
    if (i == 0) {
      lcd.setCursor(0, 0);
      lcd.print("Set Year:  Sel:#");
      lcd.setCursor(0, 1);
      lcd.print(" Next:*  Exit:D ");
      char choice = myKeyPad.getKey();
      if (choice == '#') {
        setYear(now);
        return;
      }
      else if (choice == 'D') break;
      else if (choice == '*') {
        i++;
      }
      continue;
    }
    if (i == 1) {
      lcd.setCursor(0, 0);
      lcd.print("Set Month: Sel:#");
      lcd.setCursor(0, 1);
      lcd.print(" Next:*  Exit:D ");
      char choice = myKeyPad.getKey();
      if (choice == '#') {
        setMonth(now);
        return;
      }
      else if (choice == 'D') break;
      else if (choice == '*') {
        i++;
      }
      continue;
    }
    if (i == 2) {
      lcd.setCursor(0, 0);
      lcd.print("Set Day:   Sel:#");
      lcd.setCursor(0, 1);
      lcd.print(" Next:*  Exit:D ");
      char choice = myKeyPad.getKey();
      if (choice == '#') {
        setDay(now);
        return;
      }
      else if (choice == 'D') break;
      else if (choice == '*') {
        i++;
      }
      continue;
    }
    if (i == 3) {
      lcd.setCursor(0, 0);
      lcd.print("Set Hour:  Sel:#");
      lcd.setCursor(0, 1);
      lcd.print(" Next:*  Exit:D ");
      char choice = myKeyPad.getKey();
      if (choice == '#') {
        setHour(now);
        return;
      }
      else if (choice == 'D') break;
      else if (choice == '*') {
        i++;
      }
      continue;
    }
    if (i == 4) {
      lcd.setCursor(0, 0);
      lcd.print("SetMinute: Sel:#");
      lcd.setCursor(0, 1);
      lcd.print(" Next:*  Exit:D ");
      char choice = myKeyPad.getKey();
      if (choice == '#') {
        setMinute(now);
        return;
      }
      else if (choice == 'D') break;
      else if (choice == '*') {
        i = 0;
      }
      continue;
    }
  }
}

void setYear(DateTime now) {
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Give Value and #");
  lcd.setCursor(0, 0);
  lcd.print("Year: 20");
  String input = "20";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '*') setYear(now);
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      i++;
    }
  }
  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    rtc.adjust(DateTime(input.toInt(), now.month(), now.day(), now.hour(), now.minute(), now.second()));
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("    Saving...   ");
    delay(1500);
  }
  if (option == 'D') return;
  if (option == '*') setYear(now);
}

void setMonth(DateTime now) {
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Give Value and #");
  lcd.setCursor(0, 0);
  lcd.print("Month: ");
  String input = "";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '#') break;
    if (digit == '*') setMonth(now);
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      i++;
    }
  }
  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    if (input.toInt() > 12) {
      notAllowed();
      return;
    }
    rtc.adjust(DateTime(now.year(), input.toInt(), now.day(), now.hour(), now.minute(), now.second()));
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("    Saving...   ");
    delay(1500);
  }
  if (option == 'D') return;
  if (option == '*') setMonth(now);
}

void setDay(DateTime now) {
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Give Value and #");
  lcd.setCursor(0, 0);
  lcd.print("Day: ");
  String input = "";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '#') break;
    if (digit == '*') setDay(now);
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      i++;
    }
  }
  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    if (input.toInt() > 31) {
      notAllowed();
      return;
    }
    rtc.adjust(DateTime(now.year(), now.month(), input.toInt(), now.hour(), now.minute(), now.second()));
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("    Saving...   ");
    delay(1500);
  }
  if (option == 'D') return;
  if (option == '*') setDay(now);
}

void setHour(DateTime now) {
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Give Value and #");
  lcd.setCursor(0, 0);
  lcd.print("Hour: ");
  String input = "";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '#') break;
    if (digit == '*') setHour(now);
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      i++;
    }
  }
  if (input.toInt() > 23) {
    notAllowed();
    return;
  }
  if (input.toInt() <= 12) {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("   AM  or  PM   ");
    lcd.setCursor(0, 1);
    lcd.print(" AM = A  PM = B ");
    char AP = myKeyPad.getKey();
    while (!AP) AP = myKeyPad.getKey();
    if (AP == 'A') {
      if (input.toInt() == 12) input = "0";
      rtc.adjust(DateTime(now.year(), now.month(), now.day(), input.toInt(), now.minute(), now.second()));
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("    Saving...   ");
      delay(1500);
      return;
    }
    if (AP == 'B') {
      input = input.toInt() + 12;
      if (input.toInt() == 24) input = "12";
      rtc.adjust(DateTime(now.year(), now.month(), now.day(), input.toInt(), now.minute(), now.second()));
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("    Saving...   ");
      delay(1500);
      return;
    }
  }

  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    rtc.adjust(DateTime(now.year(), now.month(), now.day(), input.toInt(), now.minute(), now.second()));
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("    Saving...   ");
    delay(1500);
  }
  if (option == 'D') return;
  if (option == '*') setDay(now);
}

void setMinute(DateTime now) {
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Give Value and #");
  lcd.setCursor(0, 0);
  lcd.print("Minute: ");
  String input = "";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '#') break;
    if (digit == '*') setMinute(now);
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      i++;
    }
  }
  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    if (input.toInt() > 59) {
      notAllowed();
      return;
    }
    rtc.adjust(DateTime(now.year(), now.month(), now.day(), now.hour(), input.toInt(), now.second()));
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("    Saving...   ");
    delay(1500);
  }
  if (option == 'D') return;
  if (option == '*') setMinute(now);
}

void notAllowed() {
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("  NOT  ALLOWED  ");
  delay(1500);
}

void feed() {
  feeder.write(70);
  delay(1000);
  feeder.write(0);
  delay(150);
}

void setAutoFeed() {
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Set hour to feed");
  lcd.setCursor(0, 1);
  lcd.print("Then press #: ");
  String input = "";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '#') break;
    if (digit == '*') setAutoFeed();
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      if(input.toInt()>1) i = i+2;
      i++;
    }
  }
  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    if (input.toInt() > 12) {
      notAllowed();
      return;
    }
    if (input.toInt() == 12) autoFeedHour = 0;
    else autoFeedHour = input.toInt();
  }
  if (option == 'D') return;
  if (option == '*') setAutoFeed();

  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Set min to feed");
  lcd.setCursor(0, 1);
  lcd.print("Then press #: ");
  input = "";
  for (int i = 0; i < 2;) {
    char digit = myKeyPad.getKey();
    if (digit == 'D') return;
    if (digit == '#') break;
    if (digit == '*') setAutoFeed();
    if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
      lcd.print(digit);
      input = input + digit;
      i++;
    }
  }
  option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') {
    if (input.toInt() > 59) {
      notAllowed();
      return;
    }
    autoFeedMinute = input.toInt();
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("    Saving...   ");
    delay(1500);
  }
  if (option == 'D') return;
  if (option == '*') setAutoFeed();
}

void setNumOfFeed() {
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print(" How many times ");
  lcd.setCursor(0, 1);
  lcd.print("to pour(<10):  ");
  char digit = myKeyPad.getKey();
  while (!digit) digit = myKeyPad.getKey();
  if (digit == 'D') return;
  if (digit == '*') setNumOfFeed();
  if (digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9' || digit == '0') {
    lcd.print(digit);
  }
  String input = String(digit);
  char option = myKeyPad.getKey();
  while (!option) option = myKeyPad.getKey();
  if (option == '#') numOfFeed = input.toInt();
  if (option == 'D') return;
  if (option == '*') setNumOfFeed();
}

void checkFoodLevel() {
  digitalWrite(trigPin, LOW);
  delayMicroseconds(10);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(20);
  digitalWrite(trigPin, LOW);

  long distance = pulseIn(echoPin, HIGH);
  distance = distance/2/29.1;
  if(distance>15){
    digitalWrite(foodLow, HIGH);
    digitalWrite(foodGood, LOW);
  }else{
    digitalWrite(foodGood, HIGH);
    digitalWrite(foodLow, LOW);
  }
}

void checkWaterLevel() {
  digitalWrite(waterPower, HIGH);
  delay(10);
  int level = analogRead(water);
  digitalWrite(waterPower, LOW);
  if(level<100){
    digitalWrite(waterLow, HIGH);
    digitalWrite(waterGood, LOW);
  }else{
    digitalWrite(waterGood, HIGH);
    digitalWrite(waterLow, LOW);
  }
}
