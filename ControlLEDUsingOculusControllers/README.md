# LED Control

1- Configure the project as the tutorial provided <a href="https://github.com/shshjmakerspace/Unity-VR-Projects/tree/main/Configuration"> here </a>.

2- Install Ardity (more details <a href="https://github.com/shshjmakerspace/ArduinoUnity3D/tree/main/Ardity">here</a>)

3- Add "Ardity -> prefabs -> serialcontroller" to hierarchy and Drag "MyMessageListener.cs" and "led.cs" into it. then drag this "serialcontroller" to the "led.cs" serialcontroller section.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/ControlLEDUsingOculusControllers/-media/img1.jpg" width="700"/>


3- from Hierarchy Create a "XR->UI Canvas" and add to buttons to it. make sure the buttons are not that far from the screen. you can also change the text setting inside the buttons. For example the "On" button has settings as below...


<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/ControlLEDUsingOculusControllers/-media/img2.jpg" width="700"/>


3- Then as you can see in the above image, we shoud add some "onclick" actions to the buttons. we should first select the Object that contains "led.cs" (here the serialcontroller) and then select the related method you wanna call (like led_on()).


4- The arduino part is also like previous works as you see in "led-on-off-oculus" folder.\

5- Codes...

```
// led.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class led : MonoBehaviour
{
    // Start is called before the first frame update
    public SerialController serialController; // drag the controller prefab in hierarchy to here
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ledon()
    {
        serialController.SendSerialMessage("A");
    }

    public void ledoff()
    {
        serialController.SendSerialMessage("Z");
    }
}

```


```
// "MyMessageListener.cs"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMsgListener : MonoBehaviour
{
    // Use this for initialization

    public string MyMSG;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
        MyMSG = msg;

    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}

```


```
// led-on-off-oculus.ino

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
```