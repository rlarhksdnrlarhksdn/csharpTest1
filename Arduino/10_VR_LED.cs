#define unit  5.0/1024.0  // ADC값 1의 전압

const int LED[4] = {3,5,6,9};
const int analogPin = A0;
char f_str[20];
char buf[100];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  for(int i=0; i<4; i++){
    pinMode(LED[i], OUTPUT);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  int VR_val = analogRead(analogPin);
  float Volt2 = VR_val*unit;
  float R2 = Volt2*10000 / (5.0-Volt2);
  dtostrf(R2, 4, 4, f_str);
  sprintf(buf, "%d, %s", VR_val, f_str);
  Serial.println(buf);

  unsigned long val = map(VR_val,740,1000,0,255);
  analogWrite(LED[0], val);
}
