
# Configuring Unity3D for VR development

Note: Installing Oclulus App on windows-> after downloading it needs you insta facebook or a gmail(which already has an account) to log in. It may not work properly sometimes. I used our lab's email to login.

Note: After pluging your headset to the pc with the link (usb 3 and type-c) device and the controllers must be recognized and be paired to the pc. For me one of the controllers had probles and was not recognized by the headset. even after changing the battery. so I had to use another headset(with it's own controllers).

The configuration steps that did not work...
- https://developer.oculus.com/documentation/unity/book-unity-gsg/
- https://www.circuitstream.com/blog/oculus-unity-setup



The configuration steps that WORKED ...
- https://www.youtube.com/watch?v=JyxbA2bm7os


Summary of the steps we need...
1- create a 3D project

2- XR Plugin Management Setup: Install it from project settings and select oculus for both android(for the quest) and pc
3- change build setting so that we can deploy to android(for quest)
4- In the "Player-> identification" check if the api level for android is correct (for now it should be marshmallow which means level 23)

5- Installing Packages: Window tab ->  packages manager
change the "Packages: In project" to "Packages: Unity Registry"

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/1.png" width="700"/>


in the package manager from setting go to advanced settings and select 'enable preview packages' so that we can alos see the packages that are not 'LTS' yet.
search for XR and install "XR interaction toolkit" and also make sure that 'XR plugin management is also installed'
then press all the dialog boxes that may appear and after restaring the project in package manager, go to the "XR interaction toolkit" and in sample section import "starter Assets".


then in the below path you must see all the "XRI Default ..." .

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/2.png" width="700"/>


6- Import Default Input Actions:
then select and add them like the below image. (for all of them)

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/3.png" width="700"/>


then in "project settings -> preset manager" set the values as the below images.

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/4.png" width="700"/>


7- install "polygon starter pack" which is free from asset store. and then import it.

8- select "polygonStarter -> Scenes -> Demo" 

9- Configure XR Rig (XR rig represents the user or player)
right click in the Hierarchy and "XR -> Device-based -> XR origin (VR)"
then camera offset must have main camera and left and right controllers as below

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/5.png" width="700"/>



In the inspetor:
make sure that "input action manager script" component exsits in "XR Origin (VR)" and if it doesn't, add it from "add component section".
in the "Action Assets" it must have an element called "XRI Default Input Actions".

<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/6.png" width="700"/>


Adding a Locomotion System: It will make us able to navigate instead of being in a static place.
right click in the Hierarchy and "XR -> Locomotion System"
we are going to use continuous movement instead off teleportation. in inspector window add another component which is called "Continuous Move Provider(Action-based)"
and then drag the locomotion system (itself) to  the system section. 
then change the selected options as below.
<img src="https://github.com/shshjmakerspace/Unity-VR-Projects/blob/main/-media/7.png" width="700"/>


10- Run


to create your own scene every thing is pretty the sam. like the 'my scene' that i made in the "oculus-test project"

to make objects interactable: add "XR Grab Interactable" to your object. but make sure that it is on another object(floor) otherwise it will disapear in the space.