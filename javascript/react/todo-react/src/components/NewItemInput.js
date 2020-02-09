import React from 'react';

const NewItemInput = (props) => {
  return (
    <form onSubmit={props.onSubmit}>
      <input
        type="text"
        value={props.value}
        placeholder="New todo"
        onChange={props.onChange}
      />
    </form>

  )
}

export default NewItemInput;
