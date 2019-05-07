import React from 'react';
import ReactDOM from 'react-dom';

import './index.css';
import GameLayout from './components/GameLayout.js';
import { headTailImages, handImages } from './data.js';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      coinToss: {
        id: 'coinToss',
        choices: ['heads', 'tails'],
        randomChoice: '',
        isWinner: '',
        resultMessage: ''
      },
      rockPaperScissors: {
        id: 'rockPaperScissors',
        choices: ['rock', 'paper', 'scissors'],
        randomChoice: '',
        isWinner: '',
        resultMessage: '',
      },
    }
  }
  randomizer = (choices) => {
    return choices[Math.floor(Math.random() * choices.length)];
  }
  handleUserPick = (userPick, gameId) => {
    const gameState = this.state[gameId];
    const randomToss = this.randomizer(gameState.choices);
    this.setState({
      ...this.state,
      [gameState.id]: {
        ...gameState,
        randomChoice: randomToss
      }
    }, () => this.changeResultMessage(userPick, gameId));
  };
  changeResultMessage = (userPick, gameId) => {
    let gameState = this.state[gameId];
    const { randomChoice } = gameState;
    if (gameId === this.state.coinToss.id) {
      this.checkWinnerForHeadsOrTails(gameState, userPick, randomChoice);
    } else {
      this.checkWinnerForRockPaperScissors(gameState, userPick, randomChoice);
    }
    this.setState({
      ...this.state,
      [gameState.id]: {
        ...gameState,
        isWinner: gameState.isWinner,
        resultMessage: gameState.resultMessage
      }
    });
  };
  checkWinnerForHeadsOrTails = (gameState, userPick, randomChoice) => {
    if (userPick === randomChoice) {
      gameState.isWinner = true;
      gameState.resultMessage = `Rolled ${randomChoice}. Nice, you won!`;
    } else {
      gameState.isWinner = false;
      gameState.resultMessage = `Rolled ${randomChoice}... You lose!`;
    }
  }
  checkWinnerForRockPaperScissors = (gameState, userPick, randomChoice) => {
    if (userPick === randomChoice) {
      gameState.isWinner = false;
      gameState.resultMessage = `Computer picked ${randomChoice}. It was a tie`;
    } else if ((userPick === 'rock' && randomChoice === 'paper') ||
               (userPick === 'paper' && randomChoice === 'scissors') ||
               (userPick === 'scissors' && randomChoice === 'rock')) {
      gameState.isWinner = false;
      gameState.resultMessage = `Computer picked ${randomChoice}. ${randomChoice} beats ${userPick}. You lose`;
    } else {
      gameState.isWinner = true;
      gameState.resultMessage = `Computer picked ${randomChoice}. ${userPick} beats ${randomChoice}. You win!`;
    }
  }
  render() {
    return (
      <div>
        <GameLayout
          title="Headers or Tails?"
          instructions="Click one"
          images={headTailImages}
          gameId={this.state.coinToss.id}
          onClick={this.handleUserPick}
          resultMessage={this.state.coinToss.resultMessage}
          isWinner={this.state.coinToss.isWinner}
        />
        <GameLayout
          title="Rock/Paper/Scissors"
          instructions="Pick one"
          images={handImages}
          gameId={this.state.rockPaperScissors.id}
          onClick={this.handleUserPick}
          resultMessage={this.state.rockPaperScissors.resultMessage}
          isWinner={this.state.rockPaperScissors.isWinner}
        />
      </div>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
