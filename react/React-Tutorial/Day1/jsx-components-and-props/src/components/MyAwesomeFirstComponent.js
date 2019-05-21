import React from 'react';

import HelloEveryone from './HelloEveryone.js'
import Restaurants from './Restaurants.js'
import Randomizer from './Randomizer.js'

const superPeople = [
  {
    name: 'Thanos',
    power: 'The Snap!'
  },
  {
    name: 'Iron Man',
    power: 'Intelligence x 3000'
  },
  {
    name: 'Dr Strange',
    power: 'the Time Stone'
  }
];

const restaurants = ['Cosmic Stones Wings', 'BK', 'Rye of Agamotto']

const MainComponent = (props) => (
  <div>
    <HelloEveryone
      superPeople={superPeople}
    />
    <Restaurants
      restaurants={restaurants}
    />
    <Randomizer
      superPeople={superPeople}
      restaurants={restaurants}
      onClick={props.onClick}
    />
  </div>
)

export default MainComponent;
