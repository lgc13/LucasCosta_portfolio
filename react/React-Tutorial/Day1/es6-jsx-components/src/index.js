import React from 'react';
import ReactDOM from 'react-dom';

import MainComponent from './components/MainComponent.js'

import './index.css';
import './ConsoleLogs.js';

const superPeople = [
  {
    name: 'Thanos',
    power: 'The Snap'
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

const Main = () => {
    return (
      <MainComponent
        superPeople={superPeople}
        restaurants={restaurants}
        onClick={handleClick}
      />
    );
}

const handleClick = () => {
  ReactDOM.render(
    <Main />,
    document.getElementById('root')
  );
}

handleClick();
