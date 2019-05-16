import React from 'react';
import App from './App';
import { shallow } from 'enzyme';

describe('App', () => {
  it('exists', () => {
    const wrapper = shallow(<App />);
    expect(wrapper).toHaveLength(1);
  });
  it('displays Hello World!!!!', () => {
    const wrapper = shallow(<App />);
    expect(wrapper.render().text()).toEqual('Hello World!!!');
  });
});
