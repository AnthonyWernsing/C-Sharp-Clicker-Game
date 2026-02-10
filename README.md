# C# Clicker Game

A lightweight, interactive desktop application built with C# and Windows Forms. This project serves as a foundational example of state management, UI updating, and event-driven programming in a game context.

## 🎮 Features

* **Core Loop:** Click the main button to earn coins.
* **Persistent Tracking:** Real-time display of your current **Coin Balance**.
* **Incremental Upgrades:** Purchase an upgrade to increase your **Coins Per Click (CPC)**.
* **Dynamic Scaling:** The cost of the upgrade increases as you progress, providing a classic "clicker" feel.
* **Reactive UI:** All labels (Coins, CPC, and Upgrade Cost) update instantly whenever an action is taken.

## 🛠️ How it Works

The game logic revolves around three primary variables:
1.  **Coins:** Your total currency.
2.  **Coins Per Click:** How much you earn every time you click the main button.
3.  **Upgrade Cost:** The amount of coins required to level up your clicking power.

### Controls
* **Click Button:** Increases your total coins by your current CPC.
* **Upgrade Button:** Deducts the current cost from your balance and increases your CPC—only clickable if you have enough coins.

## 🚀 Getting Started

### Prerequisites
* [.NET Framework](https://dotnet.microsoft.com/download) or [.NET SDK](https://dotnet.microsoft.com/download)
* An IDE like **Visual Studio 2022** or **VS Code**

### Installation
1.  Clone the repository:
    ```bash
    git clone [https://github.com/AnthonyWernsing/C-Sharp-Clicker-Game.git](https://github.com/AnthonyWernsing/C-Sharp-Clicker-Game.git)
    ```
2.  Open the solution file (`.sln`) in Visual Studio.
3.  Press `F5` to build and run the application.

## 🗺️ Roadmap (Future Goals)

I plan to continue expanding this project with the following features:
* **User Authentication & Databases:** Implement a login system with a backend database to save and restore player progress across sessions.
* **Advanced Math:** Add support for **Scientific Notation** to handle massive coin values as the game scales.
* **Content Expansion:** Introduce multiple upgrade tiers, passive income structures, and prestige mechanics.

## 📸 Screenshots

![Game Preview](https://i.gyazo.com/a87bd5c90df3b49835cf521e15bb9b0e.png)
![Game Preview](https://i.gyazo.com/b7da4b35ea1c402a7a7065025ed5627a.png)
![Game Preview](https://i.gyazo.com/3f8e1647714ed65054d67059e209823d.png)
