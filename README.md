
# react-native-3dtoolkit

## Getting started

`$ npm install react-native-3dtoolkit --save`

### Mostly automatic installation

`$ react-native link react-native-3dtoolkit`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-3dtoolkit` and add `RN3dtoolkit.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRN3dtoolkit.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RN3dtoolkitPackage;` to the imports at the top of the file
  - Add `new RN3dtoolkitPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-3dtoolkit'
  	project(':react-native-3dtoolkit').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-3dtoolkit/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-3dtoolkit')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RN3dtoolkit.sln` in `node_modules/react-native-3dtoolkit/windows/RN3dtoolkit.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using 3dtoolkit.RN3dtoolkit;` to the usings at the top of the file
  - Add `new RN3dtoolkitPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RN3dtoolkit from 'react-native-3dtoolkit';

// TODO: What to do with the module?
RN3dtoolkit;
```
  