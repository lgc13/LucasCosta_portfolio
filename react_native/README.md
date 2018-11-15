Starting up a Reactive Native app steps:

1. Install your package managers
```
brew install node
brew install yarn
```

2. Install react-native
```
npm install -g react-native-cli
```

3. Create app, and install all needed dependencies
```
react-native init project_name
```

4. Start the bundler
```
yarn start
```
or
```
react-native start
```
# Use this to clear cache when using a new picture or file
```
yarn start --reset-cache
```

5. Run app
```
react-native run-ios
```
or with specific iPhone:
```
react-native run-ios --simulator="iPhone 8 Plus" # or whatever version number
```

6. Create own scripts for Starting

Go to 'package.json' and add your own "script" such as "ios": react-native run-ios

# Code info
android, and ios - hold config files for the native app

node_modules - have all the dependencies

index.js - starts up the app by AppRegistry from the App component

App.js - has the App component by extending React.Component
