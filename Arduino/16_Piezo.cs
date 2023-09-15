
const int BUZZER = 10;
const int Yin = A1;
const int oct_4[8] = {262,294,329,349,392,440,494,523};
int cnt=0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  // tone(BUZZER, 262);
  // delay(3000);
  // noTone(BUZZER);
}

void loop() {
  // put your main code here, to run repeatedly:
  int yVal = analogRead(Yin);
  Serial.println(yVal);

  if(yVal < 100){
    cnt++;
    if(cnt == 8) cnt = 0;
    tone(BUZZER, oct_4[cnt]);
    delay(300);
  }
  else if( (yVal > 400) && (yVal < 600)){
    noTone(BUZZER);
  }
  else if( yVal > 900){
    cnt--;
    if(cnt == -1) cnt = 7;
    tone(BUZZER, oct_4[cnt]);
    delay(300);
  }
}
