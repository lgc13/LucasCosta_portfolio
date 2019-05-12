import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

import todos from './initialTodos.js';
import MainLayout from './components/MainLayout.js';

class TodoApp extends React.Component {

  render() {
    return (
      <MainLayout
        title="Things to do"
        initialTodos={todos}
      />
    )
  }
}

ReactDOM.render(
  <TodoApp />,
  document.getElementById('root')
);
