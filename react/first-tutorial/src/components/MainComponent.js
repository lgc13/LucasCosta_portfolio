import React from 'react';

import HelloEveryone from './HelloEveryone.js'
import Restaurants from './Restaurants.js'
import Randomizer from './Randomizer.js'

const MainComponent = (props) => (
  <div>
    <HelloEveryone superPeople={props.superPeople}/>
    <Restaurants
      restaurants={props.restaurants}
    />
    <Randomizer
      superPeople={props.superPeople}
      restaurants={props.restaurants}
      onClick={props.onClick}
    />
  </div>
)

export default MainComponent;
