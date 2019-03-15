# How to test in RN

mock functions by putting them in separate separate files

spyOn for functions within same file

- Import the following:

```js
import React from 'react';
import { shallow } from 'enzyme';
import SomeComponent from '../SomeComponent';
```

- Do a shallow on your component:

```js
const component = shallow(<ComponentName {...someProps} />);
// or
const component = shallow(<ComponentName prop1={'123'} style={ margin: 5 } />);
```

- Tests (examples)

1. Check a component within this component:
```js
// Checks for <View> 12345 </View>
expect(component.find('Text').childAt(0).text()).toEqual('12345');
```

2. Check if a component exists (by a id):
```js
// Looks for <View testID="someIdNameHere">
expect(component.find({ testID: 'someIdNameHere' })).toHaveLength(1);
```

3. Check the props being used for a component (call)
```js
// Looks for <SomeComponent clickable someOtherProp="123">
expect(component.find('SomeComponent').props()).toEqual({
      clickable: true,
      someOtherProp: '123',
    });
```

4. Testing a function within the same component:

```js
// Function within component AddressWrapper
const generateOrderNumberText = (location: Location) => {
  const { orderIdentifiers } = getArrivalTask(location);

  if (_.isEmpty(orderIdentifiers)) {
    return `0 Orders`;
  } else if (orderIdentifiers.length > 1) {
    return `${orderIdentifiers.length} Orders`;
  }
  return parseOrderIdentifier(orderIdentifiers[0]).formatted;
};

<View style={styles.textContainer}>
      <DriverTypeConditional
        displayIf="VCOM"
        render={() => (
          <View style={{ flexDirection: 'row' }}>
            <Text testID="orderNumberText" style={styles.orderNumberContent}>
              {generateOrderNumberText(location)}
            </Text>
          </View>
        )}
      />
```
```js
// Component AddressWrapper which calls function generateOrderNumberText
it('Shows correct order number text', () => {
      getArrivalTask.mockReturnValue({
        orderIdentifiers: [{ type: 'VCOM', value: 'U0000100000011ABC' }],
      });

      const component = mount(<AddressWrapper {...defaultProps} />);
      const driverTypeConditionals = component.findAll('DriverTypeConditional');
      const children = mount(driverTypeConditionals[0].props.render());
      const textNode = children.find('Text');
      expect(text(textNode)).toEqual('U-1-1-1-A-B-C');

      expect(getArrivalTask).toHaveBeenCalledWith(defaultProps.location);
    });
```
