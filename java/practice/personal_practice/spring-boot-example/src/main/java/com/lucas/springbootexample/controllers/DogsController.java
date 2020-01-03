package com.lucas.springbootexample.controllers;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;

@RestController
@RequestMapping("dogs")
public class DogsController {

    @GetMapping("/")
    public String getAllDogs() {
        System.out.println("Return all dogs here!");
        return "I am a Dog! (string)...";
    }
}