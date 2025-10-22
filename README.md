# 🍕 Factory Pattern Example (C#)
<p align="center">
  <a href="https://learn.microsoft.com/en-us/dotnet/csharp/">
    <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150"/>
  </a>
</p>

---

This project demonstrates the **Factory Design Pattern** using a fun **Global Pizza Factory** example in C#.

The Factory pattern provides a way to **create objects without exposing their concrete classes**.  
In this example, depending on the **region** selected (`USA`, `Italy`, or `China`), the factory produces a different style of pizza with unique preparation and serving methods.

---

## 🧩 How It Works

1. **IPizza** – Defines the common interface that all pizzas must implement (`Prepare`, `Bake`, `Serve`).  
2. **USAPizza**, **ItalianPizza**, **ChinesePizza** – Concrete classes that represent regional pizza styles.  
3. **PizzaFactory** – The factory class that decides which pizza to create based on the region.  
4. **Program (Client)** – Prompts the user for a region and requests a pizza from the factory.

---

## 🚀 Key Takeaways

- Encapsulates object creation logic in one place (the **factory**).  
- Promotes **loose coupling** between the client and concrete pizza classes.  
- Makes it easy to **add new pizza types** (e.g., JapanPizza, MexicoPizza) without touching client code.  
- Demonstrates the **creational** nature of the Factory Pattern.


---

## 🧪 How to Run

1. Open the project in **Visual Studio** or any C# IDE.  
2. Build and run the console application.  
3. Enter a region (`USA`, `Italy`, or `China`).  
4. The factory will create the corresponding pizza and simulate its preparation, baking, and serving steps.

---

**Pattern Type:** Creational  
**Language:** C# (.NET Console Application)  
**Design Goal:** Centralize and simplify object creation logic while keeping the client unaware of specific classes.

---


