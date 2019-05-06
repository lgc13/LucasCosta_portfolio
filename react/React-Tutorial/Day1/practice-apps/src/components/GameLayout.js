import React from 'react';

const GameLayout = (props) => {
  return (
    <div>
      <h2>{props.title}</h2>
      <h4>{props.instructions}</h4>
      {props.images.map(image =>
        <img
          key={image.id}
          src={image.src}
          className="image"
          onClick={() => props.onClick(image.face)}
          alt={image.alt}
          />
      )}
      {props.resultMessage &&
        <div className={props.isWinner
          ? 'result winner'
          : 'result loser'}>
           {props.resultMessage}
        </div>
      }
    </div>
  );
}

export default GameLayout;
