import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

let todos = [
  {id: 1, text: "Take out trash and recycling", complete: true},
  {id: 2, text: "Pick up dry cleaning", complete: false},
  {id: 3, text: "Get oil change", complete: false},
  {id: 4, text: "Write thank-you notes", complete: false},
];

const App = () => {
  return (
    <p>hi</p>
  )
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
