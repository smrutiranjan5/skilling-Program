import React, { useState } from "react";
import "./App.css";

import Greeting from "./Components/Greeting";
import LoginButton from "./Components/LoginButton";
import LogoutButton from "./Components/LogoutButton";

function App() {

  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const login = () => {
    setIsLoggedIn(true);
  };

  const logout = () => {
    setIsLoggedIn(false);
  };

  return (
    <div className="App">

      <Greeting isLoggedIn={isLoggedIn} />

      <br />

      {
        isLoggedIn
          ? <LogoutButton onClick={logout} />
          : <LoginButton onClick={login} />
      }

    </div>
  );
}

export default App;