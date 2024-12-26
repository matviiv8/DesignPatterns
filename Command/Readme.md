# Command Pattern

## Description

The **Command** pattern is a behavioral design pattern that encapsulates a request as an object, allowing for parameterization of clients with queues, requests, and operations. It also provides the ability to decouple the sender from the receiver, enabling more flexible command execution.

## Use Cases

- When you want to parameterize objects to execute commands.
- When you need to support undoable operations.
- When you want to decouple sender and receiver objects.

## Advantages

- Decouples the sender and receiver of a request.
- Simplifies adding new commands without changing existing code.
- Supports undo and redo operations easily.

## Disadvantages

- Can lead to a large number of command classes in complex systems.
- Increases the number of objects in the system.
