import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

const coolInstruments = ['guitar', 'sexyphone', 'drums'];

const renderFaveMusic = (props) => {
  let musicParagraph;
  if (props.faveMusic === 'rock') {
    musicParagraph = <p>Rock is awesome</p>;
  } else if (props.faveMusic === 'house') {
    musicParagraph = <p>House is better </p>;
  } else {
    musicParagraph = <p>I guess country it is....</p>;
  }
  return musicParagraph;
}

const isUserBusy = (props) => {
  if (!props.isBusy) {
    return <p>Nah I'm not busy</p>;
  } else {
    return null;
  }
}

const LuckyNumbers = () => {
  const luckyNumbers = [15, 32, 3, 54, 25];
  const listItems = luckyNumbers.map((number) =>
    <li key={number}>{number}</li>
  );
  return (
    <div>
      <p> My Lucky Numbers: </p>
      <ul>{listItems}</ul>
    </div>
  );
}

function App(props) {
  return (
    <div>
      <div className="header-div">
        <h1> Learning about styling, conditional rendering, lists/keys! </h1>
      </div>
      <div id="name-div">
        { props.name ? props.name : 'No name provided'}
      </div>
      <div>
        <p>plays the {coolInstruments.length > 2 && coolInstruments[1]} </p>
      </div>
      <div>
        {renderFaveMusic(props)}
      </div>
      <div>
        {isUserBusy(props)}
      </div>
      <LuckyNumbers />
    </div>
  );
}

ReactDOM.render(
  <App name="Lucas" faveMusic="rock" isBusy={false}/>,
  document.getElementById('root')
);
