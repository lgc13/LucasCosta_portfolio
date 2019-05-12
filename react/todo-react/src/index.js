import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

import todos from './initialTodos.js';
import MainLayout from './components/MainLayout.js';

class TodoApp extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      todos,
    }
  }
  consoleCompleted = () => {
    this.state.todos.forEach(todo => {
      if (todo.complete === true) {
        console.log('completed:', todo.text);
      }
    });
    console.log('---');
  }
  handleOnClick = (todo) => {
    this.setState({
      ...this.state,
      todos: this.state.todos.map(td => {
        if (td.id === todo.id) {
          return {
            ...td,
            complete: todo.complete ? false : true
          }
        }
        return td;
      })
    });
  }

  render() {
    return (
      <MainLayout
        title="Things to do"
        initialTodos={this.state.todos}
        onChange={this.handleOnClick}
      />
    )
  }
}

ReactDOM.render(
  <TodoApp />,
  document.getElementById('root')
);
