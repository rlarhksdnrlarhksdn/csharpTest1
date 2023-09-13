const int LED_0 = 12;
const int LED_1 = 11;
const int LED_2 = 10;
const int LED_3 = 9;
const int LED[4] = { 12, 11, 10, 9};

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  Serial.println(sizeof(LED));

  for (int i = 0; i < (sizeof(LED) / sizeof(int)); i++) {
    pinMode(LED[i], OUTPUT);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  for (int i = 0; i < 999; i++) {
    for (int j = 0; j < (sizeof(LED) / sizeof(int)); j++) {
      digitalWrite(LED[j], HIGH);
    }
    delayMicroseconds(999 - i);
    for (int j = 0; j < (sizeof(LED) / sizeof(int)); j++) {
      digitalWrite(LED[j], LOW);
    }
    delayMicroseconds(1 + i);
  }

  for (int i = 0; i < 999; i++) {
    for (int j = 0; j < (sizeof(LED) / sizeof(int)); j++) {
      digitalWrite(LED[j], HIGH);
    }
    delayMicroseconds(1 + i);
    for (int j = 0; j < (sizeof(LED) / sizeof(int)); j++) {
      digitalWrite(LED[j], LOW);
    }
    delayMicroseconds(999 - i);
  }
}
