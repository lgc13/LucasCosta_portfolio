import React from 'react';
import { shallow } from 'enzyme';

import App from 'src/index.js';

describe('App', () => {
  it('renders', () => {
    shallow(<App />)
  });
});
