void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  int k = 67;

  Serial.print("k's register value is: ");
  Serial.println(k);
  Serial.print("k's location value is: ");
  Serial.println((long)&k, DEC);
  Serial.println();

  int *myPointerk;
  myPointerk = &k;

  Serial.print("myPointerk's register value is: ");
  Serial.println((long)myPointerk);
  Serial.print("myPointerk's location value is: ");
  Serial.println((long)&myPointerk, DEC);
  Serial.println();

  *myPointerk = 128;

  Serial.println("---------------------------------------------");
  Serial.println("Updating myPointerk's value from 67 to 128.");
  Serial.println("---------------------------------------------");
  Serial.println();

  Serial.print("myPointerk's register value is: ");
  Serial.println((long)myPointerk);
  Serial.print("myPointerk's location value is: ");
  Serial.println((long)&myPointerk, DEC);
  Serial.println();
  
  Serial.print("k's register value is: ");
  Serial.println(k);
  Serial.print("k's location value is: ");
  Serial.println((long)&k, DEC);
  Serial.println();
}

void loop() {
  // put your main code here, to run repeatedly:
  
}
