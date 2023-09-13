const int LED = 13;

void serialEvent(){
  char userInput = Serial.read();
  Serial.print(userInput);
  
  switch (userInput) {
  case 'n':
    digitalWrite(LED, HIGH);  break;
  case 'f':
    digitalWrite(LED, LOW);  break;
  default: break;
  }
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(LED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly: 
}
