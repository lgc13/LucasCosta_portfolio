import React from 'react';

const buttonMap = {
  hide: 'Hide Completed Items',
  show: 'Show Completed Items'
};

const HideOrShowButton = (props) => {
  return (
    <div>
      <button
        type="button"
        onClick={(event) => props.onSubmit(props.button)}
      >
        {buttonMap[props.button]}
      </button>
    </div>
  )
}

export default HideOrShowButton;
