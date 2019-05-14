import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

export const App = () => {
  return (
    <div>
      <p>Hi!</p>
    </div>
  )
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
