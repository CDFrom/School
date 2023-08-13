  int pump = 12;
  int fan = 10;
  int waterSensor = A15;
  int levelSetpoint = A0;
  int waterLevel = 0;
  int setpointValue = 0;
  
  void setup() {
    // put your setup code here, to run once:
    pinMode(pump, OUTPUT);
    pinMode(fan, OUTPUT);
    pinMode(waterSensor, INPUT);
    pinMode(levelSetpoint, INPUT);
    Serial.begin(9600);
  }
  
  void loop() {
    // put your main code here, to run repeatedly:
    waterLevel = (analogRead(waterSensor)-300)/3.0;
    setpointValue = analogRead(levelSetpoint)*(40/993.0)-1;
    Serial.print("The current water level is ");
    Serial.println(waterLevel);
    Serial.print("The current setpoint is ");
    Serial.println(setpointValue);
    if(waterLevel <= (setpointValue - 5)){
      digitalWrite(pump, HIGH);
      digitalWrite(fan, LOW);
    }
    else
    if(waterLevel >= (setpointValue + 5)){
      digitalWrite(fan, HIGH);
      digitalWrite(pump, LOW);
    }
    else{
      digitalWrite(pump, LOW);
      digitalWrite(fan, LOW);
    }
    delay(5000);
  }
