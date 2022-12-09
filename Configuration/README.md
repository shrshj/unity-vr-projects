
# Configuring Unity3D for VR development in Oculus

Note: Installing Oculus App on windows <br />
After downloading Oculus App, it needs you Instagram, Facebook or a Gmail(which already has an account) for login. It may not work properly sometimes. I used our lab's email for login.

Note: After plugging your headset to the pc with the link (usb 3 and type-c), your device and the controllers must be recognized and be paired to the pc. For me one of the controllers had problem and was not recognized by the headset. even after changing the battery. so I had to use another headset(with it's own controllers).

The configuration steps that did not work...
- https://developer.oculus.com/documentation/unity/book-unity-gsg/
- https://www.circuitstream.com/blog/oculus-unity-setup


The configuration steps that WORKED ...
- https://www.youtube.com/watch?v=JyxbA2bm7os


Summary of the steps we need...


1- create a 3D project

2- XR Plugin Management Setup: Install it from project settings and select oculus for both android(for the quest) and pc

3- change build setting so that we can deploy to android(for quest)

4- In the "Player-> identification" check if the api level for android is correct (for now it should be marshmallow which means 
level 23)

5- Installing Packages: Window tab ->  packages manager <br />
change the "Packages: In project" to "Packages: Unity Registry" as below.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/1.png" width="700"/>


In the package manager from setting go to advanced settings and select "enable preview packages" so that we can also see the packages that are not 'LTS' yet.
Search for XR and install "XR interaction toolkit" and make sure that "XR plugin management" is also installed.
Then press OK in all the dialog boxes that may appear and after restaring the project, in the package manager go to the "XR interaction toolkit" and in the Samples section import "starter Assets".
Then in the below path you must see all the "XRI Default ..." .

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/2.png" width="700"/>


6- Import Default Input Actions:
Select and add them like the below image. (for all of them)

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/3.png" width="700"/>


Then in "project settings -> preset manager" set the values as the below image.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/4.png" width="700"/>


7- Add "XR -> Interaction Manager" to Hierarchy As below.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/5.png" width="700"/>

And also check the setting to be as below... if the script does not exist add it and change the setting like here.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/5-2.png" width="700"/>


8- Configure XR Rig (XR rig represents the user or player) <br />
Right click in the Hierarchy and "XR -> Device-based -> XR origin (VR)". Then  the 'camera offset' must have 'main camera' and 'left and right controllers' as below


<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/6.png" width="700"/>


In the inspetor: Make sure that "input action manager script" component exsits in "XR Origin (VR)" and if it doesn't, add it from "add component section". Also, in the "Action Assets" it must have an element called "XRI Default Input Actions".


<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/7.png" width="700"/> <br />


Adding a Locomotion System: It will make us able to navigate instead of being in a static place. Right click in the Hierarchy and "XR -> Locomotion System" . 
We are going to use continuous movement instead off teleportation so in the inspector window add another component which is called "Continuous Move Provider(Action-based)" and drag the locomotion system (itself) to  the system section. 
Then change the selected options as below.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/8.png" width="700"/>

Then change the selected options as below.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/Configuration/-media/9.png" width="500"/>

9- Run



To make objects interactable: add "XR Grab Interactable" to your object. but make sure that it is on another object(floor) otherwise it will disapear in the space.