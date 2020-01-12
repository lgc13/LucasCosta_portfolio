package com.lucas.springbootexample.service;

import com.lucas.springbootexample.entity.Dog;
import com.lucas.springbootexample.repository.DogRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.List;
import java.util.Optional;

@Component // Defines that this class is a spring bean
public class DogsService {

    final DogRepository dogRepository;

    public DogsService(DogRepository dogRepository) {
        this.dogRepository = dogRepository;
    }

    public Dog getDogById(long id) {
        System.out.println("id: " + id);
        Optional<Dog> optionalDog = dogRepository.findById(id);
        System.out.println(optionalDog.isPresent()
                ? optionalDog.get().getName()
                : "no dog found");

        return optionalDog.orElse(null);
    }

    public List<Dog> getAllDogs() {
        System.out.println("Getting all dogs");
        List<Dog> allDogs = dogRepository.findAll();
        System.out.println(!allDogs.isEmpty()
                ? "Amount of dogs found: " + allDogs.size()
                : "No dogs found");

        return allDogs;
    }

    public Dog createDog(String name) {
        System.out.println("Creating a dog for name: " + name);
        Dog dogCreated = dogRepository.save(new Dog(name));
        System.out.println("Dog created: " + dogCreated.getName());

        return dogCreated;
    }
}