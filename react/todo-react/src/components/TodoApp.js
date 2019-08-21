import React from 'react';
import '../index.css';

import todos from '../initialTodos';
import MainLayout from './MainLayout';

class TodoApp extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      todos,
      itemsRemaining: 0,
      newItem: '',
      button: '',
    };
  }

  componentDidMount() {
    this.getInitialItemsRemaining();
  }

  getInitialItemsRemaining = () => {
    let itemsCompleted = 0;
    const { todos } = this.state;
    todos.forEach(todo => {
      if (todo.complete) {
        itemsCompleted += 1;
      }
    });
    this.setState({
      itemsRemaining: todos.length - itemsCompleted,
      button: 'hide',
    });
  };

  handleOnClick = todo => {
    const { itemsRemaining } = this.state;
    const newItemsRemaining = todo.complete ? itemsRemaining + 1 : itemsRemaining - 1;
    this.setState({
      itemsRemaining: newItemsRemaining,
      todos: todos.map(td => {
        if (td.id === todo.id) {
          return {
            ...td,
            complete: !td.complete,
          };
        }
        return td;
      }),
    });
  };

  handleItemTyping = event => {
    this.setState({ newItem: event.target.value });
  };

  handleEnterPress = event => {
    event.preventDefault();
    const { todos, itemsRemaining, newItem } = this.state;
    if (newItem.trim()) {
      const newTodo = {
        id: todos[todos.length - 1].id + 1,
        text: newItem.trim(),
        complete: false,
      };
      this.setState({
        todos: [...todos, newTodo],
        itemsRemaining: itemsRemaining + 1,
        newItem: '',
      });
    }
  };

  handleButtonPress = button => {
    this.setState({
      button: button === 'hide' ? 'show' : 'hide',
      styles: button === 'hide' ? 'hidden' : '',
    });
  };

  render() {
    const { todos, styles, newItem, itemsRemaining, button } = this.state;
    return (
      <MainLayout
        title="Things to do"
        todos={todos}
        onClick={this.handleOnClick}
        styles={styles}
        newItem={newItem}
        onChange={this.handleItemTyping}
        onSubmit={this.handleEnterPress}
        itemsRemaining={itemsRemaining}
        button={button}
        onButtonPress={this.handleButtonPress}
      />
    );
  }
}

export default TodoApp;
