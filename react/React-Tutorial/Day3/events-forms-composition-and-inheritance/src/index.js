import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      isToggleOn: true,
      name: '',
      people: []
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
  render() {
    return (
      <div className="App">
        <div>
          <button onClick={this.handleClick}>
            Click me
          </button>
          <p> Current isToggleOn: {this.state.isToggleOn.toString()} </p>
        </div>
        <div>
          <h2> Input a name </h2>
          <input
            type="text"
            value={this.state.name}
            onKeyDown={this.handleEnterPress}
            onChange={this.handleChange}
          />
          <p> Current Name: {this.state.name} </p>
          <p> Current array of people: {this.state.people.map((person, index) => {
            if (index !== (this.state.people.length - 1)) {
              return `${person}, `;
            } else {
              return person;
            }
          })} </p>
        </div>
      </div>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
