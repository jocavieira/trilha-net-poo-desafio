# Smartphone Project  📱 

This project is part of the **DIO Fullstack Bootcamp** and a introduction to **C# object-oriented programming** concepts using a console application.

## Description

The application simulates a **smartphone system** where different phone models can:

- Make outgoing calls
- Receive incoming calls
- Install applications

The project includes two smartphone models:

- **Nokia** – Represents a basic smartphone capable of making/receiving calls and installing apps.
- **iPhone** – Represents a more advanced smartphone, also capable of making/receiving calls and installing apps.

This project focuses on **classes, inheritance, abstract methods, and basic user input/output**.

## How to Use

1. Instantiate the phone objects:
   ```csharp
   Nokia nokia = new Nokia("123456789", "Nokia 3310", 32);
   Iphone iphone = new Iphone("987654321", "iPhone 13", 128);

2. Use the phone methods

  nokia.Call();
  nokia.IncomingCall();
  nokia.InstallApp("WhatsApp");
  
  iphone.Call();
  iphone.IncomingCall();
  iphone.InstallApp("Instagram");

  
## Technologies Used

- C#
- .NET

## Classes

- **Smartphone (abstract)** – Base class with common properties (`Number`, `Model`, `Storage`) and methods (`Call()`, `IncomingCall()`, abstract `InstallApp()`).

- **Nokia** – Inherits from `Smartphone` and implements `InstallApp()`.

- **iPhone** – Inherits from `Smartphone` and implements `InstallApp()`.

