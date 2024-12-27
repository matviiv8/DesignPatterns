# Factory Method Pattern

## Description

The **Factory Method** pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. This pattern is used to delegate the instantiation of objects to subclasses, enabling flexible and extensible object creation.

## Use Cases

- When you want to allow subclasses to decide which class to instantiate.
- When object creation should be deferred to subclasses rather than being hard-coded.

## Advantages

- Promotes loose coupling by decoupling the client from the concrete classes.
- Extends the application with minimal changes by adding new subclasses.

## Disadvantages

- Can introduce complexity if not used appropriately in simpler applications.
