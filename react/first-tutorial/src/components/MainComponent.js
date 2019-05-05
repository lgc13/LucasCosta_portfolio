import React from 'react';

import HelloEveryone from './HelloEveryone.js'
import Restaurants from './Restaurants.js'

const MainComponent = (props) => (
  <div>
    <HelloEveryone superPeople={props.superPeople}/>
    <Restaurants
      superPeople={props.superPeople}
      restaurants={props.restaurants}
    />
  </div>
)

export default MainComponent;
