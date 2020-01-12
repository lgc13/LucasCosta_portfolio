package com.lucas.springbootexample.entity;

import javax.persistence.*;

@Entity
@Table(name = "dog")
public class Dog {
    @Id
    @GeneratedValue(strategy= GenerationType.AUTO)
    private long id;

    @Column(name = "name")
    private String name;

    @Column(name = "color")
    private String color;

    public Dog(String name) {
        this.name = name;
    }

    public String getName() {
        return this.name;
    }
}