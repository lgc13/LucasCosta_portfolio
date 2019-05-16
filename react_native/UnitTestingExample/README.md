# React Native unit testing

mock functions by putting them in separate separate files

spyOn for functions within same file

Note:

Importing a class syntax:
`import { ClassScreen } from ./somePath`
Importing a component:
`import SomeComponent from ./somePath;`

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

1. Check a component within this component (by name):
```js
// Checks for <View> 12345 </View>
expect(component.find('Text').childAt(0).text()).toEqual('12345');
```

2. Check if a component text is rendering properly (by name):
```js
const component = shallow(
    <OrderNumber
      {...defaultProps}
      orderIdentifier={{ type: 'FINAL_MILE', value: '456' }}
    />,
  );
  expect(
    component
      .find('Text') // This is the <Text> component. Make sure there is only one of them
      .render()
      .text(),
  ).toEqual('456');
});
```

3. Check if a component exists (by a id):
```js
// Looks for <View testID="someIdNameHere">
expect(component.find({ testID: 'someIdNameHere' })).toHaveLength(1);
```

4. Check component text by testID:
```js
expect(
        wrapper
          .find({ testID: 'someTestID' })
          .childAt(0)  
          .text(),
      ).toEqual('Some Text');
```

4. Check a component value by its index number (how many times it showed):
```js

expect(
     component
       .find('Text')
       .at(0) // this is where you specify the index number.... 0 for first time it showed
       .render()
       .text(),
   ).toEqual('Something');
```

4. Check what props a component is using
```js
// Looks for <SomeComponent clickable someOtherProp="123">
expect(component.find('SomeComponent').props()).toEqual({
      clickable: true,
      someOtherProp: '123',
    });
```

5. Check a specific prop value
```js
// Looks for <SomeComponent clickable someOtherProp="123">
expect(component.find('SomeComponent').prop('specificComponent')).toEqual('123');
```

6. Check a child component
```js
// You must mock the component
jest.mock(
  'navigators/dashboard/screens/final-mile/components/FinalMileDelivery',
  () => 'FinalMileDelivery',
);

it('renders correct props for <FinalMileDelivery />', () => {
    const component = mount(<FinalMileDeliveryScreen {...defaultProps} />);
    expect(component).toHaveChild('FinalMileDelivery', {
      orderIdentifier: defaultProps.navigation.state.params.orderIdentifier,
      productDetails: defaultProps.navigation.state.params.productDetails,
    });
  });


```

7. Check if a component's props are correct (when a function needs to be mocked)
```js
it('renders with correct props', () => {
      expect(JSON.stringify(wrapper.find('SomeComponent').props())).toEqual(
        JSON.stringify({
          onPress: () => jest.fn(),
        }),
      );
    });

```

6. Testing a function within the same component:

```js
// Function generateOrderNumberText() calls getArrivalTask() within component AddressWrapper
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

7. Testing a function within a class (component)
```js

export class SomeScreenClass extends React.Component<Props, State> {
  handleSave = () => {
    console.warn('Pressed the save button');
  };
  render() {
    return (
      <ComponentName
        onSave={this.handleSave}
      />
    );
  }
}

it('ComponentName renders with correct props', () => {
  const wrapper = shallow(<FinalMileDeliveryScreen {...defaultProps} />);
      expect(wrapper.find('ComponentName').props()).toEqual({
        onSave: wrapper.instance().handleSave,
      });
    });
```

8. Simulate onPress

```js
<SomeComponent
          onPress={someFunction}
        />

it('calls someFunction on press', () => {
      wrapper.find('SomeComponent').simulate('press');
      expect(defaultProps.someFunction).toHaveBeenCalled();
    });

```
6. Mocking function

- Import that function
```js
import { ordersWithoutMedia } from 'models/Order';
```

- Mock the implementation of it (its return value)
```js
jest.mock('models/Order', () => ({  // models/Order is the location of this function
  ...require.requireActual('models/Order'),  // this requires all actual tests from this module
  ordersWithoutMedia: jest.fn().mockImplementation(() => ['order2']),  // mocking return
}));
```

-  Actual test:
```js
it('filters out FINAL_MILE orders', async () => {
    const mockOrders = [
      {
        orderNumber: '123',
        orderIdentifier: {
          type: 'VCOM',
          value: '123',
        },
        type: 'HOUSEHOLD_GOODS',
      },
      {
        orderNumber: '456',
        orderIdentifier: {
          type: 'FINAL_MILE',
          value: '456',
        },
        type: 'HOUSEHOLD_GOODS',
      },
      {
        orderNumber: '678',
        orderIdentifier: {
          type: 'VCOM',
          value: '678',
        },
        type: 'LOGISTICS',
      },
    ];
    getState.mockImplementation(() => ({
      appReducer: {
        token: '123',
        loads: [{ loadStatus: 'ASSIGNED', orders: mockOrders }],
        media: {},
      },
    }));
    await updateMedia()(dispatch, getState);

    expect(ordersWithoutMedia).toHaveBeenCalledWith(
      [mockOrders[0].orderNumber],
      getState().appReducer.media,
    );
  });
  ```

  10. Resetting and clearing mocks:

  ```js
  afterEach(() => {
    jest.resetAllMocks();
    jest.clearAllMocks();
  });

  ```
