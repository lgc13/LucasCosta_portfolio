package com.lucas.springbootexample.service;

import org.springframework.stereotype.Component;

@Component // Defines that this class is a spring bean
public class DogsService {
    public String getAllDogs() {
        return "Im in Dogs service";
    }
}