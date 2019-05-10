import React from 'react';

const Select = (props) => (
  <form onSubmit={props.onSubmit}>
     <label>
       Pick your favorite chocolate bar:
       <select value={props.chocolate} onChange={props.onChange}>
         <option value="grapefruit">Grapefruit</option>
         <option value="lime">Lime</option>
         <option value="coconut">Coconut</option>
         <option value="mango">Mango</option>
       </select>
     </label>
     <input type="submit" value="Submit" />
   </form>
)

export default Select;
