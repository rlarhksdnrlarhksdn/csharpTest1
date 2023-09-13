const int LED[4] = {11,10,9,6};
const int LED_1 = 11;

void setup() {
  // put your setup code here, to run once:
}

void loop() {
  // put your main code here, to run repeatedly:
  for(int i=0; i<4; i++){  
    for(int t_high=0; t_high<256; t_high++){
      analogWrite(LED[i], t_high);
      delay(2);
    }
    analogWrite(LED[i], 0);
  }
}
