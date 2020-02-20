# Testing with Spring

1- Basics:

- make a public class:
- instantiate the class you want to test
   - you can add this to a `@Before`
- add any methods (tests)
   - each method takes a `@Test`
- use `Assertions`

```java
import org.junit.Before;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class DogTest {
    
    private Dog dog;   // class to be tests

    @Before
    public void init() {
        dog = new Dog();  // instantiate class 
    }
    
    @Test
    public void getDogId_whenCalled_returns5() {  // test name: methodName_whenX_returnsY
        // assertions here
        assertThat(dog.getDogId).isEqualTo(5);
    }   
}
```

2. Mocks

- use `@RunWith(MockitoJUnitRunner.class)` to set up your class
- mock any classes with `@Mock`
- use `InjectMocks` on the class to be tested
- use `when` to make returns of methods


```java
import org.junit.Before;
import org.junit.Test;
import org.mockito.Mock;
import org.mockito.InjectMocks;

import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.when;

@RunWith(MockitoJUnitRunner.class) // set up mockito to run with your class
public class DogTest {
   
    @Mock    // you can mock like this
    private Cat cat; // or:  Cat someCat = mock(Cat.class);  

    @InjectMocks
    private Dog dog;   

    @Before
    public void init() {
     dog = new Dog();  
    }
    
    @Test
    public void getDogId_whenCatIdIs10_returns10() {  
    when(cat.getId()).thenReturn(10);
     assertThat(dog.getDogId).isEqualTo(10);
    }  
}
```






