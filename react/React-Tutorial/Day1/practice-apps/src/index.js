import React from 'react';
import ReactDOM from 'react-dom';
import tails from './img/tails.jpg';
import heads from './img/heads.png';
import './index.css';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      coinChoices: ['heads', 'tails'],
      randomToss: '',
      resultMessage: '',
      isWinner: '',
    }
  }
  handleRandomToss = (coinFace) => {
    const { coinChoices } = this.state;
    this.setState({ randomToss: coinChoices[Math.floor(
      Math.random() * coinChoices.length)]},
      () => this.changeResultMessage(coinFace));
  }
  changeResultMessage = (coinFace) => {
    const { randomToss } = this.state;
    if (coinFace === randomToss) {
      this.setState({ isWinner: true });
      this.setState({ resultMessage: `${randomToss}. You won!... lucky :P` });
    } else {
      this.setState({ isWinner: false });
      this.setState({ resultMessage: `${randomToss}. You lose. Better luck next time...` });
    }
  };
  render() {
    return (
      <div>
        <h2>Coin Flip</h2>
        <h4>Heads or Tails? Click one</h4>
        <div>
          <img src={heads} className="coin" onClick={() => this.handleRandomToss('heads')} alt="heads-coin"/>
          <img src={tails} className="coin" onClick={() => this.handleRandomToss('tails')} alt="tails-coin"/>
        </div>
        {this.state.resultMessage &&
          <div className={this.state.isWinner
            ? 'result winner'
            : 'result loser'}>
              Result: {this.state.resultMessage}
          </div>
        }
      </div>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
