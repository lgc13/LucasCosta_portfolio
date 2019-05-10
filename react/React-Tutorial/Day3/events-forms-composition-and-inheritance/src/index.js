import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

import Toggle from './components/Toggle.js';
import EventsAndState from './components/EventsAndState.js';
import Form from './components/Form.js';
import TextArea from './components/TextArea.js';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      isToggleOn: true,
      name: '',
      people: [],
      food: '',
      poem: ''
    };
  }
  handleClick = () => {
    this.setState(state => ({
      isToggleOn: !state.isToggleOn
    }));
  }
  handleChange = (event) => {
      this.setState({ name: event.target.value });
   }
  handleEnterPress = (event) => {
    if (event.key === 'Enter') {
      this.setState({
        ...this.state,
        name: '',
        people: [
          ...this.state.people,
          event.target.value
        ]
      });
    }
  }
  handleFoodChange = (event) => {
    this.setState({ food: event.target.value })
  }
  handleSubmit = (event, input) => {
    alert(`Sumited: ${input}`);
    event.preventDefault();
  }
  handleChangePoem = (event) => {
    console.log('in handleChangePoem');
    this.setState({ poem: event.target.value });
  }
  render() {
    return (
      <div className="App">
        <Toggle
          handleClick={this.handleClick}
          isToggleOn={this.state.isToggleOn}
        />
        <hr/>
        <EventsAndState
          name={this.state.name}
          onKeyDown={this.handleEnterPress}
          onChange={this.handleChange}
          people={this.state.people}
        />
        <hr/>
        <Form
          onSubmit={this.handleSubmit}
          food={this.state.food}
          onChange={this.handleFoodChange}
        />
        <hr/>
        <TextArea
          onSubmit={this.handleSubmit}
          poem={this.state.poem}
          onChange={this.handleChangePoem}
        />
      </div>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
