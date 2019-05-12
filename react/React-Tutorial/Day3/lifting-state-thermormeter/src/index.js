import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

import TemperatureInput from './components/TemperatureInput.js';
import BoilingVerdict from './components/BoilingVerdict.js';

class Calculator extends React.Component {
  render() {
    return (
      <div>
        <TemperatureInput scale="c" />
        <TemperatureInput scale="f" />
      </div>
    );
  }
}


ReactDOM.render(
  <Calculator />,
  document.getElementById('root')
);
