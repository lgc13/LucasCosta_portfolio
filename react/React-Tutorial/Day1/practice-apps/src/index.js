import React from 'react';
import ReactDOM from 'react-dom';

import './index.css';
import GameLayout from './components/GameLayout.js';
import { headTailImages, handImages } from './data.js';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      coinChoices: ['heads', 'tails'],
      randomToss: '',
      resultMessage: '',
      isWinner: '',
      handChoices: ['rock', 'paper', 'scissors'],
      randomComputerChoice: '',

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
      this.setState({ resultMessage: `Flipped... ${randomToss}. You won!... lucky :P` });
    } else {
      this.setState({ isWinner: false });
      this.setState({ resultMessage: `Flipped... ${randomToss}. You lose. Better luck next time...` });
    }
  };
  handleHandChoice = (handChoice) => {
    console.log('handChoice: ', handChoice);
  }
  render() {
    return (
      <div>
        <GameLayout
          title="Headers or Tails?"
          instructions="Click one"
          images={headTailImages}
          onClick={this.handleRandomToss}
          resultMessage={this.state.resultMessage}
          isWinner={this.state.isWinner}
        />
        <GameLayout
          title="Rock/Paper/Scissors"
          instructions="Pick one"
          images={handImages}
          onClick={this.handleHandChoice}
          resultMessage={this.state.resultMessage}
          isWinner={this.state.isWinner}
        />
      </div>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
