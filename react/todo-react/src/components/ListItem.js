import React from 'react';

const ListItem = (props) => {
  return (
    <div id="main-todo-list" className="todo-list">
      <div className={props.style}>
        <input
          type="checkbox"
          className="todo-checkbox"
          onChange={() => props.onChange(props.todo)}
          checked={props.todo.complete}
        />
        <span className="todo-text">{props.todo.text}</span>
      </div>
    </div>
  );
}

export default ListItem;
