import React from 'react';

const ListItem = (props) => {
  return (
    <div id="main-todo-list" className="todo-list">
      <div className="todo">
        <input type="checkbox" className="todo-checkbox" />
        <span className="todo-text">Delete me!</span>
      </div>
    </div>
  );
}

export default ListItem;
