import React from 'react';
import { shallow } from 'enzyme';

import App from './App';


describe('App', () => {
  it('exists', () => {
    const wrapper = shallow(<App />);
    expect(wrapper).toHaveLength(1);
  });
  it('nothing', () => {
    console.log('yeah')
  })
});
