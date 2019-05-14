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
      newItem: '',
    }
  }
  componentDidMount() {
    this.getInitialItemsRemaining();
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
  handleOnClick = (todo) => {
    const { itemsRemaining } = this.state;
    const newItemsRemaining = todo.complete ? itemsRemaining + 1 : itemsRemaining - 1;
    this.setState({
      itemsRemaining: newItemsRemaining,
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
  handleItemTyping = (event) => {
    this.setState({ newItem: event.target.value});
  }
  handleEnterPress = (event) => {
    event.preventDefault();
    const { todos, itemsRemaining, newItem } = this.state;
    if (newItem.trim()) {
      const newTodo = {
        id: todos[todos.length - 1].id + 1,
        text: newItem.trim(),
        complete: false
      };
      this.setState({
        todos: [
          ...todos,
          newTodo,
        ],
        itemsRemaining: itemsRemaining + 1,
        newItem: '',
      });
    }
  }
  render() {
    return (
      <MainLayout
        title="Things to do"
        todos={this.state.todos}
        onClick={this.handleOnClick}
        newItem={this.state.newItem}
        onNewItem={this.handleItemTyping}
        onEnter={this.handleEnterPress}
        itemsRemaining={this.state.itemsRemaining}
      />
    )
  }
}

ReactDOM.render(
  <TodoApp />,
  document.getElementById('root')
);
