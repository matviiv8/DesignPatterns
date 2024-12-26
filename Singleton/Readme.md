# Singleton Pattern

## Description

The **Singleton** pattern is a creational design pattern that ensures a class has only one instance and provides a global access point to that instance. This pattern is used when a single instance of a class is required to control actions such as managing shared resources.

## Use Cases

- When exactly one object is needed to coordinate actions across the system.
- When managing shared resources like database connections or configurations.

## Advantages

- Guarantees a single instance, ensuring consistency across the application.
- Provides a global point of access to the instance.

## Disadvantages

- Can introduce global state, making testing more difficult.
- Can lead to tight coupling between the Singleton and other classes.
