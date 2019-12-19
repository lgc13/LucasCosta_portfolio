1- Setup:

- make a public class:

```java
public class SomeTest() {

}
```

- use mockito and junit
```java
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;
```

- set up mockito to run with your class

```java
@RunWith(MockitoJUnitRunner.class)
public class SomeTest() {

}
```

- add any @Before each implementations:

```java
@RunWith(MockitoJUnitRunner.class)
public class SomeTest() {
    // any mocks go here

    @Before
    public void initMocks() {
        // instantiate anything here
    }
}
```

2- Write a test

```java
@RunWith(MockitoJUnitRunner.class)
public class SomeTest() {
    private Dog dog;

    @Before
    public void initMocks() {
        dog = new Dog();
    }

    @Test
    public void getDog_getsADog() {

    }
}
```

3- Mocks

- use mockito to mock any other classes within your test:

```java
import static org.mockito.Mockito.*;

@Test
    public void getDog_getsADog() {
        Cat someCat = mock(Cat.class);
    }
```

- use @Mock to mock any other modules/libraries:

```java
public class SomeTest() {
    
    @Mock
    private Cat cat;

    @Test
    public void someTest() {
    }
}
```

0 use mockito `when` to mock return values from functions:

```java
import static org.mockito.Mockito.when;

public class SomeTest() {
    @Mock
    private Cat cat;

    @Test
    public void someTest() {
        when(cat.meows()).thenReturn(true);
    }
}
```

4- Assertions

use assertj:

```java
import static org.assertj.core.api.Assertions.assertThat;

public class SomeTest() {

    @Test
    public void someTest() {
        assertThat(1 + 1).isEqual(2);
    }
}
```






