# Unity Plugin System

A complete plugin system for Unity that provides core functionality through a clean, Unity-friendly API.

## Features

- **Math Operations**: Add, subtract, multiply, divide
- **String Utilities**: Reverse, uppercase, lowercase
- **Random Generation**: Integers, floats, booleans, colors, vectors

## Installation

1. Download the package
2. Import into your Unity project via Package Manager
3. The plugin will auto-initialize on game start

## Quick Start

```csharp
// Math operations
int sum = SimpleSdk.Unity.BridgePlugin.PluginBridge.Add(5, 3);

// String operations
string reversed = SimpleSdk.Unity.BridgePlugin.PluginBridge.ReverseString("Hello");

// Random generation
Color randomColor = SimpleSdk.Unity.BridgePlugin.UnityExtensions.RandomColor();