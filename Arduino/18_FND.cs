                           //a,b,c,d,e,f,g,dp
const unsigned int led[8] = {3,4,5,6,7,8,9,10};
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
    digitalWrite(led[i], num[n][i]);
}

void setup() {
  // put your setup code here, to run once:
  for(int i=0; i<8; i++){
    pinMode(led[i], OUTPUT);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  // 0~9
  for(int j=0; j<10; j++){
    display_fnd(j);
    delay(500);
  }
}
