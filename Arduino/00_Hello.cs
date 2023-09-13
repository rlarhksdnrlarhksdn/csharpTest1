
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);

  Serial.println("Hello PC^^");
  Serial.println(78, DEC);
  Serial.println(78, HEX);
  Serial.println(78, BIN);
  Serial.println(78, OCT);

  Serial.println(1.23456, 0);
  Serial.println(1.23456, 2);
  Serial.println(1.23456, 4);
  Serial.println('N');
}

void loop() {
  // put your main code here, to run repeatedly:

}
