import React from 'react';
import ReactDOM from 'react-dom';

import './index.css';
import MainComponent from './components/MainComponent.js'

import './index.css';

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

class Main extends React.Component {
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
        <MainComponent
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

ReactDOM.render(
  <Main />,
  document.getElementById('root')
);
