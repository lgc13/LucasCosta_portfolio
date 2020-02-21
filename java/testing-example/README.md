# Testing with Spring

Solid docs:

https://reflectoring.io/unit-testing-spring-boot/
https://reflectoring.io/spring-boot-web-controller-test/

## Basics:

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

## Mocks

- Add Mockito annotation to class:
   - JUnit 5: `@ExtendWith(MockitoExtension.class)`
   - JUnit 4: `@RunWith(MockitoJUnitRunner.class)`
- mock any classes with `@Mock`
- use `InjectMocks` on the class to be tested
   - this instantiates the class as well
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

    @InjectMocks  // this instantiates the class as well. Bonus!
    private Dog dog;
    
    @Test
    public void getDogId_whenCatIdIs10_returns10() {  
    when(cat.getId()).thenReturn(10);
     assertThat(dog.getDogId).isEqualTo(10);
    }  
}
```

## Controller Test

- annotate class with: `@WebMvcTest(MyClassName.class)`
- use `MockMvc`
- Mock any Beans (dependencies) of tested class

```java
import com.fasterxml.jackson.databind.ObjectMapper;
import com.lucas.dogspringservice.entity.Dog;
import com.lucas.dogspringservice.services.DogsService;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.web.servlet.MockMvc;

import static org.mockito.Mockito.when;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.content;

@WebMvcTest(DogController.class)  // need this to run Spring
class DogControllerTest {
    
    @Autowired
    private MockMvc mockMvc;

    @Autowired
    private ObjectMapper objectMapper;
    
    @MockBean
    DogsService dogsService;

    @Test
    public void getDogById_whenDogIsFoundByIdProvided_returnsDog() throws Exception {
        Dog dog = new Dog("Sasha", "blue");
        when(dogsService.getDogById(1)).thenReturn(dog);

        mockMvc.perform(get("/dog/1"))
                .andExpect(content().string(objectMapper.writeValueAsString(dog)));
    }
}
```

## Intermediate

- Using `@RunWith(SpringRunner.class)` will make your test run with Spring, making it slower (try not using it)






