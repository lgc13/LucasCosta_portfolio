import React from 'react';

const Restaurants = (props) => (
  <div>
    <h3>Best Restaurants:</h3>
    {props.restaurants.map(restaurant => <p key={restaurant}>{restaurant}</p>)}
  </div>
);

export default Restaurants;
