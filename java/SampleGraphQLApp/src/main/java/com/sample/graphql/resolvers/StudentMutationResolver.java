package com.sample.graphql.resolvers;

import com.coxautodev.graphql.tools.GraphQLMutationResolver;
import com.sample.graphql.modal.Hero;
import com.sample.graphql.modal.Student;
import com.sample.graphql.service.StudentService;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.List;

@Component
@Slf4j
public class StudentMutationResolver implements GraphQLMutationResolver
{
    @Autowired
    private StudentService studentService;

    public Student createStudent (Student student) {
        return studentService.createStudentRecord(student);
    }

    public Hero createHero(Hero hero) {
        log.info("Creating hero: {}", hero);
        return hero;
    }
}
