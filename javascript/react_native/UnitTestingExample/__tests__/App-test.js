import 'react-native';
import React from 'react';
import App from '../App';
import { shallow } from 'enzyme';

describe('App', () => {
  it('exists', () => {
    const wrapper = shallow(<App />);
    expect(wrapper).toHaveLength(1);
  })
});
