# Strategy Design Pattern

## Definition

#### The Strategy Design Pattern is a behavioral pattern that allows you to define a family of algorithms, put each of them into separate classes, and make them interchangeable at runtime.

#### Instead of writing many if-else or switch statements to choose an algorithm, you put each algorithm in its own class and swap them easily.

## What Problem does it solves?

### Without Strategy

if (paymentMethod == "CreditCard") { ... }
else if (paymentMethod == "UPI") { ... }
else if (paymentMethod == "NetBanking") { ... }

- Harder to maintain
- Adding new algorithm requires changing existing code (violates OCP — Open/Closed Principle)
- Too many if-else blocks

### With Strategy Pattern

- Each algorithm has its own class
- Code becomes cleaner, extensible
- New algorithm = new class (no modification of existing code)
