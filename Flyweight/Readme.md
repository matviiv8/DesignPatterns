# Flyweight Pattern

## Description

The **Flyweight** pattern is a structural design pattern that reduces memory usage by sharing common parts of state between multiple objects, instead of keeping all data in each individual object. It allows for a large number of objects to be represented efficiently, particularly when objects share similar data.

## Use Cases

- When dealing with large numbers of similar objects that need to share common state.
- When memory usage is a concern, especially in graphics-heavy applications.

## Advantages

- Reduces memory usage by sharing common states.
- Efficient when dealing with large numbers of objects.

## Disadvantages

- Increases complexity by requiring careful management of shared data.
- May be unnecessary for simple scenarios where memory usage is not a concern.
