# LED Control

1- Configure the project as the tutorial provided <a href="https://github.com/shshjmakerspace/Unity-VR-Projects/tree/main/Configuration"> here </a>.

2- Install Ardity (more details <a href="https://github.com/shshjmakerspace/ArduinoUnity3D/tree/main/Ardity">here</a>)

3- Add "Ardity -> prefabs -> serialcontroller" to hierarchy and Drag "MyMessageListener.cs" and "led.cs" into it. then drag this "serialcontroller" to the "led.cs" serialcontroller section.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/ControlLEDUsingOculusControllers/-media/img1.jpg" width="700"/>


3- from Hierarchy Create a "XR->UI Canvas" and add to buttons to it. make sure the buttons are not that far from the screen. you can also change the text setting inside the buttons. For example the "On" button has settings as below...


<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/ControlLEDUsingOculusControllers/-media/img2.jpg" width="700"/>


3- Then as you can see in the above image, we shoud add some "onclick" actions to the buttons. we should first select the Object that contains "led.cs" (here the serialcontroller) and then select the related method you wanna call (like led_on()).


4- The arduino part is also like previous works as you see in "led-on-off-oculus" folder.