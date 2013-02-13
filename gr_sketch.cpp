/*GR-(RL78) Sketch Template Version: E0.80*/
#include <RLduino78.h>
#include <Firmata.h>

// D22,D23,D24 are assigned to RGB LEDs.
#define LED_RED     22  // LOW active
#define LED_GREEN   23  // LOW active
#define LED_BLUE    24  // LOW active

byte analogPin;
byte previousPIN[2];  // PIN means PORT for input
byte previousPORT[4]; 
byte AvailableFlag = 0;

void outputPort(byte portNumber, byte portValue)
{
    //only send the data when it changes, otherwise you get too many messages!
    if(previousPIN[portNumber] != portValue) {
        Firmata.sendDigitalPort(portNumber, portValue); 
        previousPIN[portNumber] = portValue;
    }
}

void setPinModeCallback(byte pin, int mode) {
    if(pin > 1) { // don't touch RxTx pins (0,1)
        pinMode(pin, mode);
    }
}

void digitalWriteCallback(byte port, int value)
{
    byte i;
    byte currentPinValue, previousPinValue;

    if(value != previousPORT[port]) {
        for(i=0; i<8; i++) {
            currentPinValue = (byte) value & (1 << i);
            previousPinValue = previousPORT[port] & (1 << i);
            if(currentPinValue != previousPinValue) {
                digitalWrite(i + (port*8), currentPinValue);
            }
        }
        previousPORT[port] = value;
    }
}

void analogWriteCallback(byte pin, int value)
{
    pinMode(pin,OUTPUT);
    analogWrite(pin, value);
}

// the setup routine runs once when you press reset:
void setup() {
    pinMode(LED_RED, OUTPUT);
    pinMode(LED_GREEN, OUTPUT);
    pinMode(LED_BLUE, OUTPUT);

    // turn the LEDs on, glow white.
    digitalWrite(LED_RED, LOW);
    digitalWrite(LED_GREEN, LOW);
    digitalWrite(LED_BLUE, LOW);
  
    Firmata.setFirmwareVersion(0, 1);
    Firmata.attach(DIGITAL_MESSAGE, digitalWriteCallback);
    Firmata.attach(SET_PIN_MODE, setPinModeCallback);
    Firmata.attach(ANALOG_MESSAGE, analogWriteCallback);
    Firmata.begin(115200);
}

void loop() {

    while( Firmata.available() ) {
        Firmata.processInput();
        AvailableFlag = 1;
    }

    //if( AvailableFlag==1 ){

        outputPort(0, (P3.BIT.bit0<<2) | (P1.BIT.bit6<<3) | (P3.BIT.bit1<<4) | (P1.BIT.bit5<<5) | (P1.BIT.bit0<<6) | (P6.BIT.bit0<<7) );    //2-7
        outputPort(1, (P6.BIT.bit1) |  (P1.BIT.bit3<<1) |  (P1.BIT.bit4<<2) | (P7.BIT.bit2<<3) | (P7.BIT.bit1<<4) | (P7.BIT.bit0<<5) );     //8-13

        //for(analogPin = 0; analogPin < TOTAL_ANALOG_PINS; analogPin++) {
        for(analogPin = 0; analogPin < 4; analogPin++) {
            Firmata.sendAnalog(analogPin, analogRead(analogPin)); 
        }
    //}
}
