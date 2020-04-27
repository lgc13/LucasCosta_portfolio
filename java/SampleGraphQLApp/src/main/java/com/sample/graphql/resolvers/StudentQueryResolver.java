package com.sample.graphql.resolvers;

import com.coxautodev.graphql.tools.GraphQLQueryResolver;
import com.sample.graphql.modal.Hero;
import com.sample.graphql.modal.Student;
import com.sample.graphql.service.StudentService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class StudentQueryResolver implements GraphQLQueryResolver
{
    @Autowired
    private StudentService studentService;

    public Student student (String name)
    {
        return studentService.getStudentDetailsByName(name);
    }

    public Hero hero(String name) {
        // fetch a current existing thing
        // db
        // Hero hero = get hero where name == name
        return new Hero(name, "fire");
    }
}
