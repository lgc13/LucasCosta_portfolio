# Spring Boot Example

## Links, videos, and resources:

Getting Started with Spring Boot: https://www.youtube.com/watch?v=sbPSjI4tt10

Maven video: https://www.youtube.com/watch?v=KNGQ9JBQWhQ

JPA: https://www.javaworld.com/article/3379043/what-is-jpa-introduction-to-the-java-persistence-api.html
skim this: https://www.baeldung.com/jpa-entities

Repositories: http://blog.sapiensworks.com/post/2014/06/02/The-Repository-Pattern-For-Dummies.aspx

## Create Project:

For this example, let's say I'm creating a `spring-boot-example` on the Desktop (aka on ~/Desktop/spring-boot-example/)

1. Download project start up

- Go here to download your zip file with any start up dependencies you want:

   https://start.spring.io/

 - Unzip folder

 2. Start it:

 ```sh
 cd ~/Desktop/spring-boot-example # Go to root directoy of your project
```

 - For Maven Projects:

 ```sh
 mvn spring-boot:run # For Maven Projects
 ```

 - For Gradle Projects:

 ```sh
 gradle bootRun # For Gradle Projects

 # If you don't have Gradle installed:
 brew install gradle

 # If you need to build:
 gradle build
 ```

 ## Simple Rest API

1. Create controller

 ```sh
 # 1. Creating controllers folder:
 mkdir ~/Desktop/spring-boot-example/src/main/java/com/lucas/springbootexample/controllers

 # 2. Create controller (ex: DogsController.java)
 cd ~/Desktop/spring-boot-example/src/main/java/com/lucas/springbootexample/controllers
 touch DogsController.java
 ```

- Make simple RestController:

 ```java
 // DogsController.java
package com.lucas.springbootexample.controllers;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;

@RestController
@RequestMapping("dogs")
public class DogController {

    @GetMapping("/")
    public String getAllDogs() {
        System.out.println("Return all dogs here!");
        return "I am a Dog! (string)...";
    }
}
 ```

 - If the spring web framework is not installed, you can add it:

 ```sh
 # Gradle:

 # Go to build.gradle and change:
 implementation 'org.springframework.boot:spring-boot-starter' # from

 implementation 'org.springframework.boot:spring-boot-starter-web' # to
 ```

 2. Call API

 From a browser or Postman, call:

 `http://localhost:8080/dogs/`
 
## Annotations:

1. @Entity

   - lets you use `@Entity`, `@Id`, `@GeneratedValue`

   import jpa dependency:
   
   ```xml
   <!-- Maven -->
   <dependency>
    <groupId>org.springframework.boot</groupId>
    <artifactId>spring-boot-starter-data-jpa</artifactId>
   </dependency>
  ```
  
 
