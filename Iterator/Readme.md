# Iterator Pattern

## Description

The **Iterator** pattern is a behavioral design pattern that allows you to traverse elements of a collection without exposing its underlying representation (e.g., list, stack, tree). It provides a way to access the elements of an aggregate object sequentially without knowing the internal structure.

## Use Cases

- When you need to traverse a collection, but want to keep its internal structure hidden.
- When you need to iterate over collections of different types (e.g., lists, trees, sets).

## Advantages

- Allows for flexible and uniform iteration over different types of collections.
- Keeps the internal structure of the collection hidden, promoting encapsulation.

## Disadvantages

- Adds extra classes and complexity, especially if the collection types are simple.
