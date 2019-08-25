import React from 'react';

import '../index.css';

const coolInstruments = ['guitar', 'sexyphone', 'drums'];

const renderFaveMusic = (faveMusic) => {
  let musicParagraph;
  if (faveMusic === 'rock') {
    musicParagraph = <p>Rock is awesome</p>;
  } else if (faveMusic === 'house') {
    musicParagraph = <p>House is better </p>;
  } else {
    musicParagraph = <p>I guess country it is....</p>;
  }
  return musicParagraph;
}

const isUserBusy = (isBusy) => {
  if (!isBusy) {
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

const App = () => {
  const faveMusic = 'rock';
  const name = 'Lucas';
  const isBusy = false;
  
  return (
    <div>
      <div className="header-div">
        <h1> Learning about styling, conditional rendering, lists/keys! </h1>
      </div>
      <div id="name-div">
        I am red
      </div>
      <div>
        {renderFaveMusic(faveMusic)}
      </div>
      <div>
        <p>Coolest instrument: {coolInstruments.length > 2 && coolInstruments[1]} </p>
      </div>
      <div>
        Name: { name ? name : 'not provided'}
      </div>
      <div>
        {isUserBusy(isBusy)}
      </div>
      <LuckyNumbers />
    </div>
  );
}

export default App;
