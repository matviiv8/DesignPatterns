# Chain of Responsibility Pattern

## Description

The **Chain of Responsibility** is a behavioral design pattern that allows requests to be passed along a chain of handlers. Each handler decides whether to process the request or pass it to the next handler in the chain. This approach decouples the sender of the request from its potential receivers.

## Use Cases

- When multiple objects can handle a request, but the handler is not known beforehand.
- To avoid coupling the sender of a request to its receiver.
- To implement sequential processing, like validation or logging.

## Advantages

- Decouples the sender and receivers.
- Makes it easy to add new handlers without altering existing code.
- Supports flexible and dynamic handler chains.

## Disadvantages

- Can make debugging difficult due to indirect request flow.
- May lead to unhandled requests if no suitable handler exists.
