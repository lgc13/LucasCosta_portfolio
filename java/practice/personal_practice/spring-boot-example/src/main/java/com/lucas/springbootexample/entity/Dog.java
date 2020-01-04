package com.lucas.springbootexample.entity;

import javax.persistence.Entity;
import javax.persistence.Table;
import javax.persistence.Id;
import javax.persistence.GeneratedValue;
import javax.persistence.Column;

@Entity
@Table(name = "dog")
public class Dog {
    @Id
    @GeneratedValue
    private long id;

    @Column(name = "name")
    private String name;
}