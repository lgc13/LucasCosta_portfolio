import React from 'react';
import '../index.css';

const FancyBorder = (props) => {
  return (
    <div className={'FancyBorder FancyBorder-' + props.color}>
      {props.children}
    </div>
  );
}

export default FancyBorder;
