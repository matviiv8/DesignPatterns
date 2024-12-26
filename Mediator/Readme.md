# Mediator Pattern

## Description

The **Mediator** pattern is a behavioral design pattern that reduces chaotic dependencies between objects. Instead of objects communicating directly with each other, they interact through a mediator object, simplifying the relationships and decoupling the objects from one another.

## Use Cases

- When multiple objects are dependent on each other but need to be decoupled.
- When communication between objects becomes complex and hard to manage.

## Advantages

- Reduces dependencies between objects.
- Centralizes control, making it easier to manage communication between many objects.

## Disadvantages

- The mediator can become overly complex if it handles too many relationships.
- Can increase coupling between the mediator and its colleagues.
