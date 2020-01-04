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


## Database integration

1. Create your database

(I used psql to create a public db)

```shell script
# in psql
CREATE DATABASE dogsdb;

\c dogsdb # connects to db
```

2. Connect to database

- in your `src/main/resources/application.properties`, add the following:

```shell script
## Spring DATASOURCE (DataSourceAutoConfiguration & DataSourceProperties)
spring.datasource.url=jdbc:postgresql://localhost:5432/dogsdb # any your db name here in the end. in our case, dosdb
spring.datasource.username=tlgc1
spring.datasource.password=

# The SQL dialect makes Hibernate generate better SQL for the chosen database
spring.jpa.properties.hibernate.dialect = org.hibernate.dialect.PostgreSQLDialect

# Hibernate ddl auto (create, create-drop, validate, update)
spring.jpa.hibernate.ddl-auto = create-drop
```

3. Create an entity

- An @Entity is what is used for each table so that `Hibernate` can handle it

Here's an entity example:

```java
package com.lucas.springbootexample.entity;

import javax.persistence.Entity;
import javax.persistence.Table;
import javax.persistence.Id;
import javax.persistence.GeneratedValue;
import javax.persistence.Column;

@Entity
@Table(name = "dog")
public class Dog {
    @Id
    @GeneratedValue // no need for column here
    private long id;

    @Column(name = "name")
    private String name;
}
```

4. Import needed dependencies

```shell script
# buid.gradle file

# in order to use Hibernate, we need to import a jpa dependency:
implementation 'org.springframework.boot:spring-boot-starter-data-jpa'

# postgres driver needed:
implementation 'org.postgresql:postgresql'
```

Now when you run your project, it'll create that table every time it starts.
 
## Annotations:

### @Autowired

This guy had a good answer: https://stackoverflow.com/a/3153617/8238895

`Autowiring happens by placing an instance of one bean into the desired field in an instance of another bean. Both classes should be beans, i.e. they should be defined to live in the application context.`

Example:

```java
// DogsController.java
@RestController // Defines that this class is a spring bean
@RequestMapping("dogs")
public class DogsController {

    @Autowired // Tells the application context to inject an instance of DogsService here
    private DogsService dogsService;

    @GetMapping("/")
    public String getAllDogs() {
        // The DogsService is already injected and you can use it
        return dogsService.getAllDogs();
    }
}

// DogsService.java
import org.springframework.stereotype.Component;

@Component // Defines that this class is a spring bean
public class DogsService {
    public String getAllDogs() {
        return "Im in Dogs service";
    }
}
```

### @Entity

   - lets you use `@Entity`, `@Id`, `@GeneratedValue`

   import jpa dependency:
   
   ```xml
   <!-- Maven -->
   <dependency>
    <groupId>org.springframework.boot</groupId>
    <artifactId>spring-boot-starter-data-jpa</artifactId>
   </dependency>
  ```
  
 
