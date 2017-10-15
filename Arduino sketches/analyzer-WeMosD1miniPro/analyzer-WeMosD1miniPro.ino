#define green1 D0
#define green2 D1
#define yellow1 D2
#define yellow2 D3
#define purple1 D4
#define purple2 D5
#define purple3 D6
#define purple4 D7
#define data0 D8
#define data1 18
#define data2 17
#define data3 16
#define data4 15
#define data5 14 
#define data6 10
#define data7 11
#define powerPin 12

void setup() {
  
  pinMode(green1, INPUT);
  pinMode(green2, INPUT);
  pinMode(yellow1, INPUT);
  pinMode(yellow2, INPUT);
  
  pinMode(purple1, INPUT);
  pinMode(purple2, INPUT);
  pinMode(purple3, INPUT);
  pinMode(purple4, INPUT);
  /*
  pinMode(data0, INPUT);
  pinMode(data1, INPUT);
  pinMode(data2, INPUT);
  pinMode(data3, INPUT);
  
  pinMode(data4, INPUT);
  pinMode(data5, INPUT);
  pinMode(data6, INPUT);
  pinMode(data7, INPUT);
  */

  /*
  pinMode(powerPin, OUTPUT);
  digitalWrite(powerPin, LOW);
  delay(1000);
  digitalWrite(powerPin, HIGH);
  */

  Serial.begin(19200);
  while (!Serial) { ; }
}

byte in;
int buff;
unsigned long times;

void loop() {
  times = micros();

  //for(int i = 0; i < 100; i++){
  
  buff = 2;

  if (digitalRead(green1) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(green2) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(yellow1) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(yellow2) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(purple1) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(purple2) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(purple3) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(purple4) == HIGH) buff = buff | 1;
  buff = buff << 1;
  /*
  if (digitalRead(data0) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data1) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data2) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data3) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data4) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data5) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data6) == HIGH) buff = buff | 1;
  buff = buff << 1;
  if (digitalRead(data7) == HIGH) buff = buff | 1;
  //buff = buff << 1;*/
  Serial.println(buff);
  delay(4);
  //}
  /*
  Serial.println("Time test:");
  Serial.println(micros() - times);
  delay(1000);*/
  
}
