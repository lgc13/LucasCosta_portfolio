import React from 'react';
import ReactDOM from 'react-dom';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {}
  }
  tossCoin = (coinFace) => {
    console.log('coinFace', coinFace);
  }
  render() {
    return (
      <div>
        <h2>Coin Flip</h2>
        <h4>Heads or Tails?</h4>
        <select>
          <option value="Heads">Heads</option>
          <option value="Tails">Tails</option>
        </select>
        <input
          type="submit"
          value="Toss Coin"
          onClick={() => this.tossCoin('heads')}
          enabled>
        </input>
      </div>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
