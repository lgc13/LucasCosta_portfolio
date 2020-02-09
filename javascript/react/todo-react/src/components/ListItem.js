import React from 'react';

const ListItem = (props) => {
  return (
    <div className={props.style} onClick={() => props.onClick(props.todo)}>
      <input
        type="checkbox"
        className="todo-checkbox"
        checked={props.todo.complete}
        onChange={() => props.onClick(props.todo)}
      />
      <span className="todo-text">{props.todo.text}</span>
    </div>
  );
}

export default ListItem;
