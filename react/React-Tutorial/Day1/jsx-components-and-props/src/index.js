import React from 'react';
import ReactDOM from 'react-dom';

import './index.css';
import MyAwesomeFirstComponent from './components/MyAwesomeFirstComponent.js'

const handleClick = () => {
  ReactDOM.render(
    <MyAwesomeFirstComponent
      onClick={handleClick}/>,
    document.getElementById('root')
  );
}

handleClick(); // rendering when browser first starts
