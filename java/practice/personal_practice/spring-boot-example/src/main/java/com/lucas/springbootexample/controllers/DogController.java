package com.lucas.springbootexample.controllers;

import com.lucas.springbootexample.entity.Dog;
import org.springframework.http.HttpHeaders;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.beans.factory.annotation.Autowired;

import com.lucas.springbootexample.service.DogsService;

import java.util.List;

@RestController // Defines that this class is a spring bean
@RequestMapping("dog")
public class DogController {

    private final DogsService dogsService;

    @Autowired
    public DogController(DogsService dogsService) {
        this.dogsService = dogsService;
    }

    @GetMapping("/{id}")
    public ResponseEntity<Dog> getDogById(@PathVariable long id) {
        HttpHeaders headers = new HttpHeaders();
        headers.add(HttpHeaders.ACCESS_CONTROL_ALLOW_ORIGIN, "*");

        return ResponseEntity.ok()
                .headers(headers)
                .body(dogsService.getDogById(id));
    }

    @GetMapping("/all")
    public ResponseEntity<List<Dog>> getAllDogs() {
        HttpHeaders headers = new HttpHeaders();
        headers.add(HttpHeaders.ACCESS_CONTROL_ALLOW_ORIGIN, "*");
        // The DogsService is already injected and you can use it
        return ResponseEntity.ok()
                .headers(headers)
                .body(dogsService.getAllDogs());
    }

    @GetMapping("/create/{name}")
    public Dog createDog(@PathVariable String name) {

        return dogsService.createDog(name);
    }



}