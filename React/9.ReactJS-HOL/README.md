# React Exercise 9 - ES6 Features in React

## Objective

This exercise demonstrates the usage of ES6 features in a React application.

The following concepts are implemented:

- ES6 map() method
- Arrow Functions
- Array Filtering
- Array Destructuring
- Spread Operator (Merge Arrays)
- Conditional Rendering using if-else

---

## Technologies Used

- React JS
- JavaScript (ES6)
- HTML
- CSS
- Node.js
- Visual Studio Code

---

## Project Structure

```
9.ReactJS-HOL
│
├── cricketapp
│   ├── public
│   ├── src
│   │   ├── Components
│   │   │   ├── ListofPlayers.js
│   │   │   └── IndianPlayers.js
│   │   │
│   │   ├── App.js
│   │   ├── App.css
│   │   ├── index.js
│   │   └── index.css
│   │
│   ├── package.json
│   └── ...
│
├── Screenshots
│   ├── Output_Flag_True.png
│   └── Output_Flag_False.png
│
└── README.md
```

---

## Features Implemented

### 1. List of Players

- Displayed 11 cricket players using the ES6 `map()` method.
- Displayed player names along with their scores.

### 2. Players with Scores Less than or Equal to 70

- Used ES6 `filter()` with an arrow function.
- Displayed players having scores less than or equal to 70.

### 3. Odd and Even Players

- Used ES6 Array Destructuring.
- Displayed Odd Team Players.
- Displayed Even Team Players.

### 4. Merge Arrays

- Created two arrays:
  - T20 Players
  - Ranji Trophy Players
- Merged both arrays using the ES6 Spread Operator (`...`).

### 5. Conditional Rendering

- Used an `if-else` statement with a `flag` variable.
- When `flag = true`, the **ListofPlayers** component is displayed.
- When `flag = false`, the **IndianPlayers** component is displayed.

---

## ES6 Concepts Used

- map()
- filter()
- Arrow Functions
- Array Destructuring
- Spread Operator
- Conditional Rendering

---

## Output

### When Flag = true

- List of Players
- Players having Scores Less than or Equal to 70

### When Flag = false

- Odd Players
- Even Players
- List of Indian Players Merged

---

## Screenshots

The following screenshots are included in the **Screenshots** folder:
- Output (Flag = true)
- Output (Flag = false)

---

