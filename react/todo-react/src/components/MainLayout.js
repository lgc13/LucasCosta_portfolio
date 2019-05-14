import React from 'react';

import ListItem from './ListItem.js';
import NewItemInput from './NewItemInput.js';
import RemainingItems from './RemainingItems.js';

const MainLayout = (props) => {
  return (
    <div className="app">
      <h1>{props.title}</h1>
      {props.todos.map(todo =>
        <ListItem
          key={todo.id}
          todo={todo}
          onClick={props.onClick}
          style={todo.complete ? 'todo complete' : 'todo'}
        />
      )}
      <div>
        <NewItemInput
          value={props.newItem}
          onChange={props.onNewItem}
          onSubmit={props.onSubmit}
        />
        <RemainingItems
          itemsRemaining={props.itemsRemaining}
        />
      </div>
    </div>
  )
}

export default MainLayout;
