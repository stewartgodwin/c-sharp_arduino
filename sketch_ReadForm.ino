int redLED = 12; // Red LED
int blueLED = 13; // Blue LED
int buzzerPin  = 5; // Buzzer

void setup() {
  Serial.begin(9600);
  pinMode(redLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  pinMode(buzzerPin, OUTPUT);
}
void loop() {
  // LED and buzzer
  int val = Serial.parseInt();
  switch (val) {
    case 100: digitalWrite(redLED, HIGH); break;
    case 101: digitalWrite(redLED, LOW); break;
    case 200: digitalWrite(blueLED, HIGH); break;
    case 201: digitalWrite(blueLED, LOW); break;
    case 300: {
        tone(buzzerPin, 1000, 50);
        delay(500);
        tone(buzzerPin, 3000, 100); break;
      }
  } // end of switch
}

