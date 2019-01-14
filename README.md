# README #

# Description #

Firebase is a mobile and web application development platform developed by Firebase, Inc. in 2011, then acquired by Google in 2014. 
Firebase allows to track analytics, crash reports, log reports of your mobile app, similar to Hockey App or Mobile Azure.

# App Description #
The Firebase app is created in Xamarin iOS. It is a kitchen sink, meaning its objective is to demonstrate all the possible capabilities of Firebase inside of an app.
It demonstrates the following features: Logging Crash Reporting Notifications Storage Realtime Database Remote Configuration UnitTesting

## Timeline ##
### Training Part 1 ###
* 2h - Onboarding. Create repo. Create app and Look into resources. Start Readme in repo.  
* 2h - Implement Firebase in App
* 12h - Implement app to show content on Firebase
    * 2 hours – Implement Logging
    * 2 hours – Implement Crashes
    * 2 hours – Implement notifications
    * 4 hours – Database/Storage Feature of Firebase
    * 2 hours – View Performance and how to update
* 4 hours – Refine everything. Wrap it up.  Update Readme in Repo with screenshots

### Training Part 2 ###
* 2h – Setup Firebase Test Lab
* 6h – Implement unit testing in app
* 2h – Setup Firebase Database
* 8h – Implement Database in app (realtime)
* 2h – Setup remote config
* 4h – Implement remote config


## Resources ## 

[Xamarin Firebase iOS Components](https://components.xamarin.com)

## How to implement Firebase in your app ##

Create Your Xamarin iOS project and add Firebase to your application by downloading the GoogleService-Info.plist from Firebase.  
Tip (to avoid spending time researching errors): 
Make sure the GoogleService-Info.plist is named exactly "GoogleService-Info" and it's located in the Resources folder, otherwise the application may not find it. 
Make sure keychain sharing is enabled. 
Make sure "Custom Entitlements" under "iOS Bundle Signing" (in Project properties) is set to "Entitlements.plist". Otherwise you will experience a lot of issues in the future.

The image below is the Dashboard of the application. Each button leads to a section that demonstrate features of Firebase. 

![Dashboard Card](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Dashboard.png?token=53bd8edc2138ce0a5dde368640b9d10c44df7a28)


## Logging ##

Logging page allows the user to send a username and an e-mail to the Firebase console. 

![Logging](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Logging.png?token=2fc00980dc71ba92c6d256cbef6c2f267af9c697)


## Crash Reporting ##

![Crash#1](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Crash_NotFiniteNumberException.png?token=07ba10b8426befb2e5094da57f77f1ef2a8d679c)
![Crash#2](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Crash_NotImplementedException.png?token=8586044bf3ccf735399a8d33754f8ee0e237c694)
![Crash#3](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Crash_NullReferenceException.png?token=8c7c50931d9c5c1120571887e4e233190c04f233)
![Crash#4](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Crash_OutofMemoryException.png?token=26b4ec3529d46ec65a3b2210059450434595295f)

## Notifications ##


## Authentication ##

![Mobile Authentication Logged in](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Authentication_LoggedIn.png?token=213d777e42e40e9112e1bf647c6690d2c310aa85)

![Console Authentication](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Console_Authentication.png?token=0e968e01bb6b0d76829ee5b576cb13f793efe51c)


## Storage ##

![Storage Page](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Storage.png?token=e3b8c4327fe713760b13e02ca06787dcf7c0c605)
![Storage Page](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Storage_ImagePicker.png?token=b380bfe367f6a20aa9b4ddef0ad5a575461e3d70)
![Storage Page](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Storage_CameraRoll.png?token=a45e58afe4986f265083a522d5847430a5f4756d)
![Storage Page](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Mobile_Storage_UploadingImage.png?token=08077094cb9667c1294fa8d921749a846f1dce20)

![Console Storage](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Console_Storage.png?token=646391a7a38d65143778567efecb0440a295e3cd)

## Realtime Database ##

![App Database]()

## Unit Testing ##


## Remote Config ##


![Console Remote Config](https://bytebucket.org/bluetube/doubea-pierre-ios-firebase/raw/0277ee8b6caf74f9fae51730c97b30549fbeca1f/Images/Console_RemoteConfig.png?token=b01750b4d75e101ceac8e10878182369f933d16b)

## Contact Doubea Pierre for more info ##
doubea.pierre@perficient.com