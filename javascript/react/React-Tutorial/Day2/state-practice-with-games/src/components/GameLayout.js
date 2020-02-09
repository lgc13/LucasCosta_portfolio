import React from 'react';

const GameLayout = (props) => {
  let classResult;
  if (props.isWinner === true) {
    classResult = 'result winner';
  }
  else if (props.isWinner === 'tie') {
    classResult = 'result tie';
  }
  else {
    classResult = ' result loser';
  }
  return (
    <div>
      <h2>{props.title}</h2>
      <h4>{props.instructions}</h4>
      {props.images.map(image =>
        <img
          key={image.id}
          src={image.src}
          className="image"
          onClick={() => props.onClick(image.face, props.gameId)}
          alt={image.alt}
          />
      )}
      {props.resultMessage &&
        <div className={classResult}>
           {props.resultMessage}
        </div>
      }
    </div>
  );
}

export default GameLayout;
