import React from 'react';

const RemainingItems = (props) => {
  return (
    <p>
      <span id="remaining-count">{props.itemsRemaining}</span> items remain
    </p>
  );
}

export default RemainingItems;
