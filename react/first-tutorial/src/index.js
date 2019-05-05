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

class Main extends React.Component {
  render() {
    return (<MainComponent superPeople={superPeople} />)
  }
}

ReactDOM.render(
  <Main />,
  document.getElementById('root')
);
