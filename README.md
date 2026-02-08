# 🏋️‍♂️ C# Gym: The Ultimate Logic Workout

![Status](https://img.shields.io/badge/Status-Under%20Construction%20🚧-orange?style=for-the-badge)
![Language](https://img.shields.io/badge/Language-C%23%20%7C%20.NET-purple?style=for-the-badge)
![Architecture](https://img.shields.io/badge/Architecture-Reflection%20Based-blue?style=for-the-badge)

> **"Code is like humor. When you have to explain it, it’s bad."** – *Cory House*

Welcome to my personal coding dojo! This isn't just a collection of scripts; it's a **Dynamic Console Architecture** designed to solve, test, and organize 100+ C# algorithmic challenges.

---

## 🧠 The Architecture (Behind the Scenes)
Unlike standard repositories where files are scattered, this project uses **Reflection** to dynamically load and run challenges.

### 🛠️ How it works:
1.  **The Contract (`IChallenge`):** Every solution implements a unified interface.
2.  **The Discovery (Reflection):** On startup, the `Program.cs` scans the assembly for any class implementing `IChallenge`.
3.  **The Menu System:** Challenges are automatically categorized by `Difficulty` enum (Easy, Intermediate, Advanced) and sorted by name.
4.  **Zero-Maintenance:** To add a new problem, I simply create a class. No hardcoded `switch` statements, no manual registration!

---

## 🚀 Progress Tracker
*Current Status: Building the Engine & Solving Level 1...*

| Difficulty | Badge | Count | Status |
|:---:|:---:|:---:|:---:|
| **Level 1** | ![Easy](https://img.shields.io/badge/-Easy-green) | 0/40 | 🔄 In Progress |
| **Level 2** | ![Medium](https://img.shields.io/badge/-Intermediate-yellow) | 0/35 | ⏳ Pending |
| **Level 3** | ![Hard](https://img.shields.io/badge/-Advanced-red) | 0/25 | ⏳ Pending |

---

## 📂 Project Structure
A sneak peek into how I organize my logic:

```text
CSharpGym/
├── 📂 Core/
│   ├── IChallenge.cs       # The Contract 📜
│   └── Difficulty.cs       # The Levels 📊
├── 📂 Solutions/
│   ├── 📂 Level1_Easy/     # Where the warm-up happens 🏃
│   ├── 📂 Level2_Intermediate/
│   └── 📂 Level3_Advanced/
└── Program.cs              # The Reflection Engine ⚙️
