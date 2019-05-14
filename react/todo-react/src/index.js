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
      itemsRemaining: 0,
    }
  }
  componentDidMount() {
    this.getInitialItemsRemaining();
  }
  handleOnClick = (todo) => {
    let { itemsRemaining } = this.state;
    const difference = todo.complete ? 1 : -1;
    this.setState({
      itemsRemaining: itemsRemaining += difference,
      todos: this.state.todos.map(td => {
        if (td.id === todo.id) {
          return {
            ...td,
            complete: td.complete ? false : true
          }
        }
        return td;
      })
    });
  }
  getInitialItemsRemaining = () => {
    let itemsCompleted = 0;
    this.state.todos.forEach(todo => {
      if (todo.complete) {
        itemsCompleted += 1;
      }
    });
    this.setState({
      itemsRemaining: this.state.todos.length - itemsCompleted
    });
  }
  consoleCompleted = () => {
    this.state.todos.forEach(todo => {
      if (todo.complete === true) {
        console.log('completed:', todo.text);
      }
    });
    console.log('---');
  }
  render() {
    return (
      <MainLayout
        title="Things to do"
        initialTodos={this.state.todos}
        onChange={this.handleOnClick}
        itemsRemaining={this.state.itemsRemaining}
      />
    )
  }
}

ReactDOM.render(
  <TodoApp />,
  document.getElementById('root')
);
