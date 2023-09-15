const int SW_0 = 2, SW_1 = 3;
const int LED_0 = 10, LED_1 = 11;
int flag_0 = 0, flag_1 = 0;   // 0:OFF, 1:ON

int pre_sw0 = 0, cur_sw0 = 0;
int pre_sw1 = 0, cur_sw1 = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(SW_0, INPUT);
  pinMode(SW_1, INPUT);
  pinMode(LED_0, OUTPUT);
  pinMode(LED_1, OUTPUT);
  digitalWrite(LED_0, LOW);
  digitalWrite(LED_1, LOW);
}

void loop() {
  // put your main code here, to run repeatedly:
  cur_sw0 = digitalRead(SW_0);
  cur_sw1 = digitalRead(SW_1);

  if( (pre_sw0 == 0) && (cur_sw0 == 1)){
    if(flag_0 == 0){
      digitalWrite(LED_0, HIGH);
      flag_0 = 1;
    }
    else{
      digitalWrite(LED_0, LOW);
      flag_0 = 0;
    }
  }

  if( (pre_sw1 == 0) && (cur_sw1 == 1)){
    if(flag_1 == 0){
      digitalWrite(LED_1, HIGH);
      flag_1 = 1;
    }
    else{
      digitalWrite(LED_1, LOW);
      flag_1 = 0;
    }
  }

  pre_sw0 = cur_sw0;
  pre_sw1 = cur_sw1;
}
