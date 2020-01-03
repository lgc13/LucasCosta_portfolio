package com.lucas.springbootexample.controllers;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.beans.factory.annotation.Autowired;

import com.lucas.springbootexample.service.DogsService;

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