/*********************************************************************
 * Desktop Station Analog Gateway Sketch for Arduino UNO/Leonard
 *
 * Copyright (C) 2014 Yaasan
 * 
 * This example is free software; you can redistribute it and/or
 * modify it under the terms of the Creative Commons Zero License,
 * version 1.0, as published by the Creative Commons Organisation.
 * This effectively puts the file into the public domain.
 *
 * This example is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.	 See the
 * LICENSE file for more details.
 */

#include <avr/wdt.h>


#define MAX_S88DECODER 1
#define RELPYERROR_300 "300 Command error"
#define RELPYERROR_301 "301 Syntax error"
#define RELPYERROR_302 "302 receive timeout"
#define RELPYERROR_303 "303 Unknown error"
#define RELPYERROR_NONE ""

boolean setLocoSpeed(word inAddress, word inSpeed);

String request;

String function;

boolean gPower = false;
word gDirection[2] = {1, 1};

word arguments[8];

word numOfArguments;

boolean result;

//Arduino PWM Speed Control：
int MOTOR1_PWM = 3; // DF-ROBOT:5, ArduinoGenuie: 3
int MOTOR1_DIR = 12; // DF-ROBOT:4, ArduinoGenuie:12
int MOTOR1_BRK = 9; // DF-ROBOT:-, ArduinoGenuie: 9
int MOTOR2_PWM = 11; // DF-ROBOT:6, ArduinoGenuie:11
int MOTOR2_DIR = 13; // DF-ROBOT:7, ArduinoGenuie:13
int MOTOR2_BRK = 8; // DF-ROBOT:-, ArduinoGenuie: 8

void setup() {
  
  //Timer0 sets about 8kHz Carrier frequency
  //TCCR0B = TCCR0B & 0b11111110;
  
  //Initiate Motor Shield Output pins
  pinMode(MOTOR1_DIR, OUTPUT);   
  pinMode(MOTOR2_DIR, OUTPUT); 
  pinMode(MOTOR1_BRK, OUTPUT);
  pinMode(MOTOR2_BRK, OUTPUT);
  
  initLoco();
  
  //Initiate Serial port
  Serial.begin(115200);
  while (!Serial);
  
  wdt_enable(WDTO_8S); // WDT reset


  Serial.println("--------------------------------------");
  Serial.println("Desktop Station Interface with Arduino (Analog/DC)");
  Serial.println("--------------------------------------");
  Serial.println("100 Ready");
  
  

}

int receiveRequest() {
	char buffer[128];
	int i = 0;
	char aByte;
	int aResult = -1;
	
	unsigned long time = millis();
	
	/* Check serial buffer */
	if (Serial.available() > 0) {
		
		while (1) {
		
			if (Serial.available() > 0) {
			
				aByte = Serial.read();
				
				// Write to text buf.
				buffer[i] = aByte;
				
				// check last identification of text end.
				if (aByte == '\n') {
					aResult = i;
					break;
				}
				
				// increment
				i = i + 1;
				
				// buf over check
				if( i > 127)
				{
					break;
				}
			}
			else
			{
				/* Check timeout. */
				if( millis() > time + 4000)
				{
					aResult = -1;
					break;
				}
			}
		}
	}
	else
	{
		/* Not received. */
		aResult = 0;
	}
	
	if( aResult > 0)
	{
	
		buffer[i] = '\0';
		
		request = String(buffer);
	}
	else
	{
		request = "";
	}
	
	return aResult;
}

word stringToWord(String s) {
  word result = 0;
  
  for (int i = 0; i < s.length(); i++) {
	result = 10 * result + (s.charAt(i) - '0');
  }
  
  return result;
}

boolean parse() {
  int lpar = request.indexOf('(');
  if (lpar == -1) {
	return false;
  }
  
  function = String(request.substring(0, lpar));
  function.trim();
  
  int offset = lpar + 1;
  int comma = request.indexOf(',', offset);
  numOfArguments = 0;
  while (comma != -1) {
	String tmp = request.substring(offset, comma);
	tmp.trim();
	arguments[numOfArguments++] = stringToWord(tmp);
	offset = comma + 1;
	comma = request.indexOf(',', offset);
  }

  int rpar = request.indexOf(')', offset);
  while (rpar == -1) {
	return false;
  }
  
  if (rpar > offset) {
	String tmp = request.substring(offset, rpar);
	tmp.trim();
	arguments[numOfArguments++] = stringToWord(tmp);
  }
  
  return true;
}

boolean dispatch() {
  byte aValue;
  byte aValueHigh;
  boolean aResult;

  if (function == "accelerateLoco") {
	return true;
	
  } else if (function == "decelerateLoco") {
	return true;
	
  } else if (function == "toggleLocoDirection") {
	return true;
	
  } else if (function == "setLocoDirection") {
	return setLocoDirection(arguments[0], arguments[1]);
	
  } else if (function == "toggleLocoFunction") {
	return true;
	
  } else if (function == "setLocoFunction") {
	return true;
	
  } else if (function == "setTurnout") {
	return true;
	
  } else if (function == "setPower") {
        gPower = arguments[0] == 1 ? true : false;
        initLoco();
	return true;
	
  } else if (function == "setLocoSpeed") {
	return setLocoSpeed(arguments[0], arguments[1]);

  } else if (function == "getLocoConfig") {

	
	return true;
  } else if (function == "setLocoConfig") {
	return true;
	
  } else if (function == "setPing") {
	return setPing();
	
  } else if (function == "getVersion") {
	
	Serial.println("@VER,00,00,");
	return true;

  }
  else if (function == "getS88")
  {
	
    return true;
	
  } /* getS88 */
  else if (function == "reset")
  {

	Serial.println("100 Ready");
	
	return true;
  } /* reset */
  else if (function == "mfxDiscovery")
  {	
	return true;
  } /* mfxDiscovery */
  else if (function == "mfxBind")
  {	
	return true;
  } /* mfxBind */
  else if (function == "mfxVerify")
  {
	return true;
  } /* mfxVerify */
  else
  {
	return false;
  }
  
}

void loop() {
	
	String aReplyText = RELPYERROR_NONE;
	
	/* Reset watchdog timer. */
	wdt_reset(); 

	//Receive command from Desktop Station(PC via USB)
	int aReceived = receiveRequest();
	
	/* Reset watchdog timer. */
	wdt_reset();
	
	if( aReceived > 0)
	{
  		if (parse()) {
			if (dispatch()) {
				aReplyText = "200 Ok";
			} else {
				//Serial.println(function);
				aReplyText = RELPYERROR_300;
			}
		} else {
			aReplyText = RELPYERROR_301;
		}
	}
	else if( aReceived == 0)
	{
		aReplyText = "";
		
	
	}
	else if( aReceived < 0)
	{
		// Not received per 4sec
		// Reset serial
		Serial.flush();
		
		aReplyText = RELPYERROR_302;
        }
	else
	{
		/* Nothing to do */
		
	}
	
	
	/* Reply to Desktop Station */
	if( aReplyText != "")
	{
		Serial.println(aReplyText);
	}

}

boolean setPing() {
	
	return true;
}

boolean setLocoDirection(word inAddress, word inDirection)
{
  boolean aResult = true;
  
   switch(inAddress & 0xFF)
  {
    case 1: 
          gDirection[0] = inDirection;
          
          if( gDirection[0] <= 1)
          {
              digitalWrite(MOTOR1_DIR,HIGH);
          }
          else
          {
              digitalWrite(MOTOR1_DIR,LOW);
          }           
          break;
    
    case 2: 
          gDirection[1] = inDirection;
          
          if( gDirection[1] <= 1)
          {
              digitalWrite(MOTOR2_DIR,HIGH);
          }
          else
          {
              digitalWrite(MOTOR2_DIR,LOW);
          }          
          break;
    
    default:
          break;
  }
  
  return aResult;
  
}

void initLoco()
{
 analogWrite(MOTOR1_PWM, 0); 
 analogWrite(MOTOR2_PWM, 0); 
 
 digitalWrite(MOTOR1_BRK, LOW);
 digitalWrite(MOTOR2_BRK, LOW);
}

boolean setLocoSpeed(word inAddress, word inSpeed)
{
  int aValue = inSpeed >> 2;
  
  if(aValue < 0)
  {
    aValue = 0;
  }
  
  if( aValue >= 255)
  {
    aValue = 255;
  }
  
  //Check power on
  if( gPower == false)
  {
    initLoco();
    return true;
  }
  
  switch(inAddress & 0xFF)
  {
    case 1:
          if( gDirection[0] <= 1)
          {
              digitalWrite(MOTOR1_DIR,HIGH);
          }
          else
          {
              digitalWrite(MOTOR1_DIR,LOW);
          }   
          analogWrite(MOTOR1_PWM, aValue);   //PWM Speed Control
          break;
    
    case 2:
          if( gDirection[1] <= 1)
          {
              digitalWrite(MOTOR2_DIR,HIGH);
          }
          else
          {
              digitalWrite(MOTOR2_DIR,LOW);
          }
          analogWrite(MOTOR2_PWM, aValue);   //PWM Speed Control
          break;
  }
  
  return true;
  
}


