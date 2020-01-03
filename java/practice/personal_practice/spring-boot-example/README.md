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

 mvn spring-boot:run # For Maven Projects
 # OR
 gradle bootRun # For Gradle Projects
 ```

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
  
 
