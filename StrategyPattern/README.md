# Strategy Design Pattern

## Definition

#### The Strategy Design Pattern is a behavioral pattern that allows you to define a family of algorithms, put each of them into separate classes, and make them interchangeable at runtime.

#### Instead of writing many if-else or switch statements to choose an algorithm, you put each algorithm in its own class and swap them easily.

## What Problem does it solves?

### Without Strategy

```
if (paymentMethod == "CreditCard") { ... }
else if (paymentMethod == "UPI") { ... }
else if (paymentMethod == "NetBanking") { ... }
```

- Harder to maintain
- Adding new algorithm requires changing existing code (violates OCP — Open/Closed Principle)
- Too many if-else blocks

### With Strategy Pattern

- Each algorithm has its own class
- Code becomes cleaner, extensible
- New algorithm = new class (no modification of existing code)

### **Code Summary**

The Strategy Pattern is implemented by creating:

1. **Strategy Interface (`IPaymentStrategy`)**
   – Defines a common method `Pay()` for all payment types.

2. **Concrete Strategies (`CreditCardPayment`, `UpiPayment`, `PayPalPayment`)**
   – Each class implements `IPaymentStrategy` and provides its own payment logic.

3. **Context Class (`PaymentContext`)**
   – Holds a reference to a strategy.
   – Allows switching the strategy at runtime using `SetStrategy()`.
   – Calls the selected strategy’s `Pay()` method through `MakePayment()`.

4. **Usage**
   – Create a `PaymentContext` with a strategy.
   – Change strategies at runtime without modifying existing code.

This shows how the pattern removes multiple `if-else` conditions and makes algorithms interchangeable.
