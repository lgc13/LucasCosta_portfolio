import React from 'react';

const HelloEveryone = (props) => {
  const listItems = props.superPeople.map((person) => (
    <p key={person.name}>{person.name} has {person.power}</p>)
  );
  return (
    <div>
      {listItems}
    </div>
  );
}

export default HelloEveryone;
