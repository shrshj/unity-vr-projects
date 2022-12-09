int ledPin = 13;


void setup(){
  Serial.begin(9600);
  pinMode(ledPin,OUTPUT);
}

void loop(){
  if(Serial.available()){

    char c = Serial.read();
    if(c){
    
      if(c=='A'){
        digitalWrite(ledPin,HIGH);
      }
      else if(c=='Z'){
        digitalWrite(ledPin,LOW);
      }
    }

  }

}