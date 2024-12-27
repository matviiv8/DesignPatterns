# Proxy Pattern

## Description

The **Proxy** pattern is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. The proxy controls access to the real object, often adding additional functionality such as access control, caching, logging, or lazy initialization before passing the request to the real service object.

## Use Cases

- When you need to control access to a resource-heavy or sensitive object.
- When you want to add additional functionality (like logging or security checks) to existing objects without modifying their code.

## Advantages

- Provides a way to add additional functionality like access control or caching.
- Protects sensitive objects by controlling access.
- Can improve performance through lazy initialization or caching.

## Disadvantages

- Adds an extra layer of abstraction, which can complicate the design.
- May reduce performance in cases where the proxy adds overhead.
