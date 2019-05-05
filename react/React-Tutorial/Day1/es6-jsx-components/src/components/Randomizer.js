import React from 'react';

const Randomizer = (props) => {
  return (
    <div>
      <h3>Randomizer</h3>
      <button onClick={props.onClick}>
        Click me
      </button>
      {(props.randomPerson && props.randomRestaurant) &&
        <h4>{props.randomPerson.name} likes to eat at {props.randomRestaurant}</h4>}
    </div>
  );
}

export default Randomizer;
