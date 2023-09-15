                           //a,b,c,d,e,f,g,dp
const unsigned int led[8] = {2,3,4,5,6,7,8,9};
const unsigned int digit[4] = {10,11,12,13};
const unsigned int num[10][8] = {
  {1,1,1,1,1,1,0,0}, // 0
  {0,1,1,0,0,0,0,0}, // 1
  {1,1,0,1,1,0,1,0}, // 2
  {1,1,1,1,0,0,1,0}, // 3
  {0,1,1,0,0,1,1,0}, // 4
  {1,0,1,1,0,1,1,0}, // 5
  {1,0,1,1,1,1,1,0}, // 6
  {1,1,1,0,0,0,0,0}, // 7
  {1,1,1,1,1,1,0,0}, // 8
  {1,1,1,1,0,1,1,0}  // 9
};

void display_fnd(int n){
  for(int i=0; i<8; i++)
    digitalWrite(led[i], !num[n][i]);
}

void display_clear(void){
  for(int i=0; i<8; i++){
    digitalWrite(led[i], LOW);
  }
  delay(1);
}

void setup() {
  // put your setup code here, to run once:
  for(int i=0; i<8; i++){
    pinMode(led[i], OUTPUT);
  }
  for(int i=0; i<4; i++){
    pinMode(digit[i], OUTPUT);
    digitalWrite(digit[i], LOW);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(digit[0], HIGH);
  display_fnd(1);
  delay(1);
  digitalWrite(digit[0], LOW);
  display_clear();

  digitalWrite(digit[1], HIGH);
  display_fnd(2);
  delay(1);
  digitalWrite(digit[1], LOW);
  display_clear();

  digitalWrite(digit[2], HIGH);
  display_fnd(3);
  delay(1);
  digitalWrite(digit[2], LOW);
  display_clear();

  digitalWrite(digit[3], HIGH);
  display_fnd(4);
  delay(1);
  digitalWrite(digit[3], LOW);
  display_clear();
}
