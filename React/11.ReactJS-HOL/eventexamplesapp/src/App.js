import React, { useState } from "react";
import "./App.css";
import CurrencyConvertor from "./Components/CurrencyConvertor";

function App() {

  const [count, setCount] = useState(0);

  // Increment Counter
  const increment = () => {
    setCount(count + 1);
  };

  // Decrement Counter
  const decrement = () => {
    setCount(count - 1);
  };

  // Hello Message
  const sayHello = () => {
    alert("Hello! Member1");
  };

  // Multiple Methods
  const handleIncrement = () => {
    increment();
    sayHello();
  };

  // Welcome Message
  const sayWelcome = (msg) => {
    alert(msg);
  };

  // Synthetic Event
  const handleClick = (e) => {
    alert("I was clicked");
    console.log(e);
  };

  return (
    <div className="App">

      <h2>{count}</h2>

      <button onClick={handleIncrement}>Increment</button>
      <br /><br />

      <button onClick={decrement}>Decrement</button>
      <br /><br />

      <button onClick={() => sayWelcome("Welcome")}>
        Say Welcome
      </button>
      <br /><br />

      <button onClick={handleClick}>
        Click on me
      </button>

      <hr />

      <CurrencyConvertor />

    </div>
  );
}

export default App;