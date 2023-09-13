// "LED_ON" = ON
// "LED_OF" = OFF
unsigned int dataBytes = 10;
char readData[10] = {};
const int LED = 13;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(LED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    // unsigned int val = Serial.readBytes(readData,dataBytes);
    // Serial.println(val);

    // for(int i=0; i<val; i++) {
    //   Serial.print(readData[i]);
    // }
    // readData[val] = "\0"; // null
    
    switch (readData) {
    case "LED_ON":
      digitalWrite(LED, HIGH);  break;
    case "LED_OFF":
      digitalWrite(LED, LOW);  break;
    default: break;
    }
  }  
}
