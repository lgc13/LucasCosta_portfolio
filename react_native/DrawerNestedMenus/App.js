import React from 'react';
import { Text, View, Button, ScrollView } from 'react-native';
import { 
  createAppContainer,
  createSwitchNavigator, 
  } from 'react-navigation';
import { createDrawerNavigator } from 'react-navigation-drawer'
import { createStackNavigator } from 'react-navigation-stack'
import { createBottomTabNavigator } from 'react-navigation-tabs'
import Icon from '@expo/vector-icons/Ionicons';
import { TouchableOpacity } from 'react-native-gesture-handler';

const Feed = () => (
      <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
        <Text>Feed</Text>
      </View>
    );

const Profile = () => (
      <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
        <Text>Profile</Text>
      </View>
    );

const Settings = () => (
  <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
    <Text>Settings</Text>
  </View>
);

const DashboardTabNavigator = createBottomTabNavigator(
  {
    Feed,
    Profile,
    Settings
  },
  {
    navigationOptions: ({ navigation }) => {
      const { routeName } = navigation.state.routes[navigation.state.index];
      return {
        headerTitle: routeName
      };
    }
  }
);

const DashboardTabNavigator2 = createBottomTabNavigator(
  {
    Feed2: Feed,
    Profile2: Profile,
    Settings2: Settings
  },
  {
    navigationOptions: ({ navigation }) => {
      const { routeName } = navigation.state.routes[navigation.state.index];
      return {
        headerTitle: routeName
      };
    }
  }
);

const HambugerMenuIcon = (props) => (
  <Icon
    style={{ paddingLeft: 10 }}
    onPress={props.onPress}
    name="md-menu"
    size={30}
  />
)

const DrawerOption1 = createStackNavigator(
  {
    DashboardTabNavigator: DashboardTabNavigator,
  },
  {
    defaultNavigationOptions: ({ navigation }) => {
      return {
        headerLeft: <HambugerMenuIcon onPress={() => navigation.openDrawer()} />
      };
    }
  }
);

const DrawerOption2 = createStackNavigator(
  {
    DashboardTabNavigator2,
  },
  {
    defaultNavigationOptions: ({ navigation }) => {
      return {
        headerLeft: <HambugerMenuIcon onPress={() => navigation.openDrawer()} />
      };
    }
  }
);

const MyCustomerDrawer = () => (
 <ScrollView>
   <TouchableOpacity onPress={() => console.warn('pressed!')}>
     <View>
       <Text style={{
				flexDirection: 'row',
				backgroundColor: '#0033FF',
				paddingVertical: 28,
				paddingLeft: 17,
				marginTop: 30,
				alignItems: 'center',
			}}>LUCAS</Text>
     </View>
   </TouchableOpacity>
 </ScrollView>
)

// Drawer Menu
const DrawerNavigator = createDrawerNavigator({
  DrawerOption1: {
    screen: DrawerOption1
  },
  DrawerOption2: {
    screen: DrawerOption2
  }
}, {
  contentComponent: MyCustomerDrawer,
});

const Welcome = (props) => (
  <View style={{alignItems: 'center', flex: 1, backgroundColor: '#fff', justifyContent: 'center'}}>
    <Button
        title="Login"
        onPress={() => props.navigation.navigate('Dashboard')}
    />
    <Button title="Sign Up" onPress={() => alert('button pressed')} />
  </View>)
  
const AppSwitchNavigator = createSwitchNavigator({
  Welcome: { screen: Welcome },
  Dashboard: { screen: DrawerNavigator },
})
  
const AppContainer = createAppContainer(AppSwitchNavigator)

const App = () => <AppContainer/>

export default App;
