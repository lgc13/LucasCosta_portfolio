# Compoition vs Inheritance

Demo:

![Demo](./demo.PNG)

When you have a component that will take different types of children, you might want to use composition.

You can have multiple components that pass different children to this one specific component.

Ex:

```js
// index.js
const WelcomeDialog = () => {
  return (
    <FancyBorder color="blue">
      <h1 className="Dialog-title">
        Welcome
      </h1>
      <p className="Dialog-message">
        Thank you for visiting our spacecraft!
      </p>
    </FancyBorder>
  );
}

// FancyBorder.js
const FancyBorder = (props) => {
  return (
    <div className={'FancyBorder FancyBorder-' + props.color}>
      {props.children}
    </div>
  );
}
```

Taken from FB React docs:

Anything inside the <FancyBorder> JSX tag gets passed into the FancyBorder component as a children prop. Since FancyBorder renders {props.children} inside a <div>, the passed elements appear in the final output.

- So What About Inheritance?

If you want to reuse non-UI functionality between components, we suggest extracting it into a separate JavaScript module. The components may import it and use that function, object, or a class, without extending it.
