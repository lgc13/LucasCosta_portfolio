package com.lucas.springbootexample.controllers;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.beans.factory.annotation.Autowired;

import com.lucas.springbootexample.service.DogsService;

@RestController // Defines that this class is a spring bean
@RequestMapping("dogs")
public class DogsController {

    private final DogsService dogsService;

    @Autowired
    public DogsController(DogsService dogsService) {
        this.dogsService = dogsService;
    }

    @GetMapping("/")
    public String getAllDogs() {
        // The DogsService is already injected and you can use it
        return dogsService.getAllDogs();
    }
}