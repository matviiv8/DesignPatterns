# Memento Pattern

## Description

The **Memento** pattern is a behavioral design pattern that allows you to save and restore an object's previous state without exposing its internal details. This is useful for implementing undo/redo functionality or keeping track of historical states.

## Use Cases

- Implementing undo/redo functionality.
- Keeping track of changes for a rollback feature.

## Advantages

- Encapsulates an object's state, ensuring that internal implementation details are hidden.
- Facilitates restoring objects to previous states.

## Disadvantages

- Increases complexity, especially when tracking large numbers of states.
- Can consume more memory if the state is large.
