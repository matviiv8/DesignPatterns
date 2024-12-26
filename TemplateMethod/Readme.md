# Template Method Pattern

## Description

The **Template Method** pattern is a behavioral design pattern that defines the skeleton of an algorithm in the superclass, but lets subclasses override specific steps of the algorithm without changing its structure. This allows for code reuse while maintaining flexibility in the details.

## Use Cases

- When you have a series of steps that must follow a consistent order, but allow flexibility in certain steps.
- When you want to provide a common algorithm framework and allow subclasses to implement details.

## Advantages

- Promotes code reuse by defining a common structure.
- Allows flexibility for subclasses to customize specific behavior.

## Disadvantages

- Subclasses must follow the template's structure, which may limit flexibility in complex scenarios.
