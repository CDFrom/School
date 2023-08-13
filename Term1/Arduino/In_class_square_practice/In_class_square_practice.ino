int nums;
int temp;
float average;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  float sum = 0;
  Serial.println("Enter how many numbers will be entered:");
  while(Serial.available() == 0)
  {
    
  }
  nums = Serial.parseInt();
  for(int i=1; i<=nums; i++)
  {
    Serial.println("Enter number: ");
    while(Serial.available() == 0)
    {
      
    }
    temp = Serial.parseInt();
    sum += temp;
  }
  average = sum / nums;
  Serial.print("The average of the numbers is: ");
  Serial.println(average);
}
