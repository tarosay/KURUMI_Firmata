//********************************************
// Firmata Lua用　v0.01 2012.2.25
//********************************************
#include <RLduino78.h>
#include <Firmata.h>

// D22,D23,D24 are assigned to RGB LEDs.
#define LED_RED     22  // LOW active
#define LED_GREEN   23  // LOW active
#define LED_BLUE    24  // LOW active

#define DN0 P1.BIT.bit1
#define DN1 P1.BIT.bit2
#define DN2 P3.BIT.bit0
#define DN3 P1.BIT.bit6
#define DN4 P3.BIT.bit1
#define DN5 P1.BIT.bit5
#define DN6 P1.BIT.bit0
#define DN7 P0.BIT.bit0
#define DN8 P0.BIT.bit1
#define DN9 P1.BIT.bit3
#define DN10 P1.BIT.bit4
#define DN11 P7.BIT.bit2
#define DN12 P7.BIT.bit1
#define DN13 P7.BIT.bit0
#define DN14 P2.BIT.bit2
#define DN15 P2.BIT.bit3
#define DN16 P2.BIT.bit4
#define DN17 P2.BIT.bit5
#define DN18 P2.BIT.bit6
#define DN19 P2.BIT.bit7
#define DN20 P14.BIT.bit7
#define DN21 P12.BIT.bit0
#define DN22 P1.BIT.bit7
#define DN23 P5.BIT.bit1
#define DN24 P5.BIT.bit0

byte analogPin;
byte previousPIN[4];
byte previousPORT[4];

//********************************************
// digital IO送信
//********************************************
void outputPort(byte portNumber, byte portValue)
{
    //only send the data when it changes, otherwise you get too many messages!
    if(previousPIN[portNumber] != portValue) {
        Firmata.sendDigitalPort(portNumber, portValue);
        previousPIN[portNumber] = portValue;
    }
}

//********************************************
// PinModeの設定
//********************************************
void setPinModeCallback(byte pin, int mode) {
    if(pin > 1) { // don't touch RxTx pins (0,1)
        pinMode(pin, mode);
    }
}

//********************************************
// digital IOの設定
//********************************************
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
        Firmata.sendDigitalPort(port, value);
    }
}

//********************************************
// アナログ(PWM)出力の設定
//********************************************
void analogWriteCallback(byte pin, int value)
{
    pinMode(pin,OUTPUT);
    analogWrite(pin, value);
}

//********************************************
// セットアップ
//********************************************
void setup() {

    //Color LEDの設定
    pinMode(LED_RED, OUTPUT);
    pinMode(LED_GREEN, OUTPUT);
    pinMode(LED_BLUE, OUTPUT);
    digitalWrite(LED_RED, HIGH);
    digitalWrite(LED_GREEN, HIGH);
    digitalWrite(LED_BLUE, HIGH);

    //Firmataの設定
    Firmata.setFirmwareVersion(0, 1);
    Firmata.attach(DIGITAL_MESSAGE, digitalWriteCallback);
    Firmata.attach(SET_PIN_MODE, setPinModeCallback);
    Firmata.attach(ANALOG_MESSAGE, analogWriteCallback);
    Firmata.begin(115200);
}

//********************************************
// メインループ
//********************************************
void loop() {
byte portValue0 = 0;
byte portValue1 = 0;
byte portValue2 = 0;

    while( Firmata.available() ) {
        Firmata.processInput();
    }

    for( int i=0; i<8; i++ ){
        portValue0 |= (digitalRead(i)<<i);
        portValue1 |= (digitalRead(i + 8)<<i);
        portValue2 |= (digitalRead(i + 16)<<i);
    }
    outputPort(0, portValue0 );
    outputPort(1, portValue1 );
    outputPort(2, portValue2 );
    outputPort(3, digitalRead(24) );

    //for(analogPin = 0; analogPin < TOTAL_ANALOG_PINS; analogPin++) {
    for(analogPin = 0; analogPin < 8; analogPin++) {
        Firmata.sendAnalog(analogPin, analogRead(analogPin));
    }
    delay(5);
}
