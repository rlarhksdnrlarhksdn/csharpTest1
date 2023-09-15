#define Volt  5.0/1024.0

const int analogPin = A0;
char buf[100];
char f_str[20];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
  int analogValue = analogRead(analogPin);
  dtostrf(Volt*analogValue, 4, 4, f_str);
  sprintf(buf, "%d, %s V", analogValue, f_str);
  Serial.println(buf);
}
