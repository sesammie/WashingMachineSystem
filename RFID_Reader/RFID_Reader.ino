#include <SoftwareSerial.h>
SoftwareSerial Serial1(2,3);

byte MF_GET_SNR[8] = {0xAA, 0x00, 0x03, 0x25, 0x26, 0x00, 0x00, 0xBB};
String  serialBasicString = "170021131128187";
String lastcard = "";
unsigned long timeOfLastCard = 0;
void setup()  
{
 Serial.begin(9600);

 // No longer using NewSoftSerial but instead an Arduino Mega
 Serial1.begin(9600);
}

void loop()
{
 Serial1.write(MF_GET_SNR, 8);
 delay(50);
 String NewCard = "";
 while(Serial1.available() > 0) 
 {
   NewCard += Serial1.read(); 
 }  
    if ( NewCard != serialBasicString && (NewCard != lastcard || millis()-timeOfLastCard > 2500)){
    Serial.print("#SCAN_ID_");
      Serial.print(NewCard);
      Serial.println("%");
      timeOfLastCard = millis();
    lastcard = NewCard;
  }
}
