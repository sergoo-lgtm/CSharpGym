<div align="center">

<a href="https://git.io/typing-svg">
  <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&weight=700&size=40&pause=1000&color=239120&center=true&vCenter=true&width=800&height=80&lines=Welcome+to+The+C%23+Gym;100%2B+Algorithmic+Challenges;Powered+by+C%23+Reflection;Zero-Maintenance+Architecture" alt="Typing SVG" />
</a>

<img src="https://api.iconify.design/noto:person-lifting-weights.svg?width=120" alt="Gym" />

# 🏋️‍♂️ C# Gym: The Ultimate Logic Workout

*A dynamic, auto-discovering console architecture engineered to conquer algorithmic challenges, master Data Structures, and solidify Backend logic.*

[![C#](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)]()
[![.NET Core](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)]()
[![Architecture](https://img.shields.io/badge/Architecture-Reflection_Engine-FF9900?style=for-the-badge)]()
[![SOLID](https://img.shields.io/badge/Principle-Open%2FClosed-0078D4?style=for-the-badge)]()

<br/>

> **"Code is like humor. When you have to explain it, it’s bad."** – *Cory House*

</div>

---

## 🚀 The Vision: Beyond a Standard Repository

Most developers practice algorithmic problems by dumping scripts into disorganized folders, relying on massive, hardcoded `switch` statements to run them. 

**This project takes a Senior-Level approach.** The **C# Gym** is a self-sustaining ecosystem. It acts as a testing ground for algorithmic efficiency (perfect for LeetCode-style training) while strictly adhering to the **Open/Closed Principle (OCP)**. You can add infinite new challenges without ever touching the core execution engine.

---

## 🧠 The Architecture: The Reflection Engine

The crown jewel of this repository is the `Program.cs` engine. It uses **C# Reflection** to dynamically scan, load, and categorize classes at runtime.

### 🛠️ How the Magic Happens:
1.  **The Contract (`IChallenge`):** Every new algorithm strictly implements a unified interface, defining its `Difficulty`, `Name`, and an `Execute()` method.
2.  **The Assembly Scanner:** On startup, the engine scans the compiled assembly for any class implementing `IChallenge`.
3.  **Dynamic Instantiation:** It instantiates these classes, categorizes them by their `Difficulty` enum, and dynamically generates a sleek Console UI.
4.  **Zero-Maintenance:** To add a new problem, I simply create a new class. **No manual registration. No bloated menus.**

### 🔄 The Execution Flow

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#239120', 'edgeLabelBackground':'#111'}}}%%
sequenceDiagram
    actor Dev as Developer
    participant Class as New Challenge Class
    participant Engine as Reflection Engine
    participant UI as Console Menu
    
    Dev->>Class: Creates Class : IChallenge
    Note over Dev,Class: Adds logic (e.g., TwoSum)<br/>No other files touched!
    Dev->>Engine: Run Application
    Engine->>Engine: Assembly.GetTypes()
    Engine->>Engine: Filter by typeof(IChallenge)
    Engine->>UI: Group by Difficulty & Generate Menu
    UI-->>Dev: Displays Dynamic Interactive Menu
