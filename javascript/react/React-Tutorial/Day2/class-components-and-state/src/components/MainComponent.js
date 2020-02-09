import React from 'react';

import '../index.css';

import SuperPeople from './SuperPeople.js'
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

class MainComponent extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      superPeople,
      restaurants,
      randomPerson: '',
      randomRestaurant: ''
    };
  }
  handleClick = () => {
    const { superPeople, restaurants } = this.state;
    let randomPerson = superPeople[Math.floor(Math.random() * superPeople.length)];
    let randomRestaurant = restaurants[Math.floor(Math.random() * restaurants.length)];
    this.setState({randomPerson, randomRestaurant});
  }
  render() {
    return (
      <div className="main-component">
          <SuperPeople superPeople={this.state.superPeople}/>
          <Restaurants
            restaurants={this.state.restaurants}
          />
          <Randomizer
            superPeople={this.state.superPeople}
            restaurants={this.state.restaurants}
            onClick={this.handleClick}
            randomPerson={this.state.randomPerson}
            randomRestaurant={this.state.randomRestaurant}
          />
      </div>
    );
  }
}

export default MainComponent;
