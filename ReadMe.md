<h3>Overview:</h3>
This repo contains a framework to write the tests for Meraki demo app, and few blackbox tests. 

 <h3>How it works</h3>
 There are two projects in a solution:
 
   * MerakiApiAutomation
   * TestMerakiApi (Contains all the tests)
   
<b>MerakiApiAutomation</b>: 
  This project consist of architecture and mapping of all the pages of the mobile app. It supports to write tests for android/IOS and it can be easily extended to add any other target mobile OS (windows). Here is the block diagram architecture:
  ![image](https://user-images.githubusercontent.com/83523058/149566078-aa365904-2b01-4e66-8679-9d801905c2ba.png)
  
  * Controls (textbox, label, button, etc)
  * Pages (Home screen, networks list, network details)
  * Driver wrapper (It help to execute the tests in Android/IOS)

<b>TestMerakiApi</b>
This project contains all the blackbox tests that will run using MerakiApiAutomation library components. Please note these tests are independent which environment they can run (android/IOS/Windows)
  
<b>Software dependencies</b>
* Install Java 7 JDK
* Install Node.js
* Visual Studio 2019 or above
* Install Appium from the command line (skip if you install Appium Desktop)
* npm install -g appium
* Install Appium Desktop (optional)
* Install the Carthage dependency manager
* There are few other dependencies that will get installed automatically when we build the solution using nuget.

I have created a demo video here. 
[![Here is my explaination on Youtube](https://user-images.githubusercontent.com/83523058/149571007-a932679d-1030-4f47-b6a9-45ad496bb623.png)](https://www.youtube.com/watch?v=4HGH-wuuZsA)
https://www.youtube.com/watch?v=4HGH-wuuZsA


<b>How to run</b>
* Download a clone of this repo locally.
* Make sure you have downloaded and installed all the dependencies seperately.
* Double click on the solution file, which will open the visual studio.
* Update the android sdk env variable in file `AppiumServerUtil.cs` to your local path.
* Update `App.config` for desired IP and port number. Also you need to set which platform the test should run. I recommend to keep it to android, since I could not test the IOS on my machine. 
* Once everything is done, build and solution. This should install all other necessary dependencies using nuget.
* Finally go to MerakiAppTest.cs and select a test using this shortcut Ctrl+r+t our using context menu.

I could not able to run the automation demo while recording my machine keep crashing when running tests for IOS using emulator for windows.
![Demo1](https://user-images.githubusercontent.com/83523058/149564243-eee2b05d-2556-4112-a3d8-da051c51a625.gif)

