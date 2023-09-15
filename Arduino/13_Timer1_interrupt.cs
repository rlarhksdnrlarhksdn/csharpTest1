#include <TimerOne.h>

unsigned long t1_prev = 0;
const unsigned long t1_delay = 1000;

unsigned long t2_prev = 0;
const unsigned long t2_delay = 500;

const int LED = 11;
unsigned long ms = 0;

void timerIsr(void){
  ms++;
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(LED, OUTPUT);
  Timer1.initialize(1000);  // 1ms
  Timer1.attachInterrupt(timerIsr);
}

void loop() {
  // put your main code here, to run repeatedly:
    unsigned long t1_now = ms;
  if( (t1_now - t1_prev) >= t1_delay)
  {
    t1_prev = t1_now;
    Serial.println("t1");
  }

  unsigned long t2_now = ms;
  if( (t2_now - t2_prev) >= t2_delay)
  {
    t2_prev = t2_now;
    Serial.println("t2");
  }
}
