import React from 'react';

const ListItem = (props) => {
  return (
    <div
      id="main-todo-list"
      className="todo-list"
      onClick={() => props.onClick(props.todo)}
    >
      <div className={props.style}>
        <input
          type="checkbox"
          className="todo-checkbox"
          checked={props.todo.complete}
          onChange={() => props.onClick(props.todo)}
        />
        <span className="todo-text">{props.todo.text}</span>
      </div>
    </div>
  );
}

export default ListItem;
