# 021 – Observer Design Pattern

## Overview

A classic implementation of the **Observer (Publish/Subscribe) design pattern** from the Gang of Four. A `Subject` maintains a list of `IObserver` objects and notifies them all whenever its state changes. Observers can subscribe (`Attach`) or unsubscribe (`Detach`) at any time.

## Concepts Covered

- **Design Pattern:** Observer / Event-Listener
- `interface` definitions (`IObserver`, `ISubject`)
- `List<IObserver>` for managing subscribers
- Polymorphism: different observer classes react differently to the same event
- `Thread.Sleep` to simulate asynchronous state changes

## Project Structure

```
021-Observer-Pattern/
└── ObserverPattern/
    ├── ObserverPattern.csproj
    ├── ObserverPattern.sln
    └── Program.cs
```

## Key Interfaces

```csharp
public interface IObserver
{
    void Update(ISubject subject);
}

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
```

## How It Works

1. `Subject` stores its `State` (a random int 0–9).
2. `SomeBusinessLogic()` changes the state and calls `Notify()`.
3. `Notify()` iterates all attached observers and calls `Update(this)`.
4. `ConcreteObserverA` reacts only when `State < 3`.
5. `ConcreteObserverB` reacts when `State == 0` or `State >= 2`.

## How to Run

```bash
dotnet run --project ObserverPattern
```

### Sample Output

```
Subject: Attached an observer.
Subject: Attached an observer.

Subject: I'm doing something important.
Subject: My state has just changed to: 7
Subject: Notifying observers...
ConcreteObserverB: Reacted to the event.

Subject: I'm doing something important.
Subject: My state has just changed to: 1
Subject: Notifying observers...
ConcreteObserverA: Reacted to the event.
Subject: Detached an observer.
...
```
