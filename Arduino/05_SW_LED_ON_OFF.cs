const int SW = 2;
const int LED = 13;
int flag = 0;   // 0:OFF, 1:ON

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(SW, INPUT);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
}

void loop() {
  // put your main code here, to run repeatedly:
  int val = digitalRead(SW);
  if(val == 1){
    if(flag == 0){
      digitalWrite(LED, HIGH);
      flag = 1;
    }
    else{
      digitalWrite(LED, LOW);
      flag = 0;
    }
    delay(300);
  }
}
