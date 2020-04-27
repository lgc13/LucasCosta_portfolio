package com.sample.graphql.modal;

import lombok.AllArgsConstructor;
import lombok.Data;

@Data
@AllArgsConstructor
public class Hero {
    private String name;
    private String superPower;
}
