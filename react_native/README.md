# React Native Basics

I. Starting up a Reactive Native app steps:

(yarn must be installed)

1. Install react-native

```sh
yarn global add react-native-cli
```

2. Create app, and install all needed dependencies

```sh
react-native init YourProjectName
```

3. Start the bundler

```sh
yarn start
# or
react-native start
```

# Use this to clear cache when using a new picture or file

```sh
yarn start --reset-cache
```

4. Run app on simulator

```sh
react-native run-ios
# or with specific iPhone:
react-native run-ios --simulator="iPhone 8 Plus" # or whatever version number
```

5. Create own scripts for Starting

Go to 'package.json' and add your own "script" such as

```sh
"ios": react-native run-ios
```

# Code info
android, and ios - hold config files for the native app

node_modules - have all the dependencies

index.js - starts up the app by AppRegistry from the App component

App.js - has the App component by extending React.Component

II. Basics

<Text>
    - Prints out on simulator
<Image source={require('./path_to_file.jpg')} />
    - Adds picture
