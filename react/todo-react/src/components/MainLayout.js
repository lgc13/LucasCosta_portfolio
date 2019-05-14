import React from 'react';

import ListItem from './ListItem.js';
import NewItemInput from './NewItemInput.js';
import RemainingItems from './RemainingItems.js';
import HideOrShowButton from './HideOrShowButton.js';

const MainLayout = (props) => {
  return (
    <div className="app">
      <h1>{props.title}</h1>
      <div id="main-todo-list" className="todo-list">
        {props.todos.map(todo =>
          <ListItem
            key={todo.id}
            todo={todo}
            onClick={props.onClick}
            style={todo.complete ? `todo complete ${props.styles}`  : 'todo'}
          />
        )}
      </div>
      <div>
        <NewItemInput
          value={props.newItem}
          onChange={props.onNewItem}
          onSubmit={props.onSubmit}
        />
        <RemainingItems
          itemsRemaining={props.itemsRemaining}
        />
        <HideOrShowButton
          button={props.button}
          onSubmit={props.onButtonPress}
        />
      </div>
    </div>
  )
}

export default MainLayout;
