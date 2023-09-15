const int Xin = A0;
const int Yin = A1;
const int KEYin = 3;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(KEYin, INPUT_PULLUP); // pull-up 사용
}

void loop() {
  // put your main code here, to run repeatedly:
  int xVal = analogRead(Xin);
  int yVal = analogRead(Yin);
  int buttonVal = digitalRead(KEYin);

  Serial.print("X = ");
  Serial.println(xVal, DEC);

  Serial.print("Y = ");
  Serial.println(yVal, DEC);

  Serial.print("Button is ");
  if(buttonVal == HIGH){
    Serial.println("not pressed");
  }else{
    Serial.println("pressed");
  }
  delay(300);
}










