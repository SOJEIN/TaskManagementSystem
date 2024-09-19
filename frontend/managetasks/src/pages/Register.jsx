import React, { useState } from "react";
import { registerUser } from "../services/apiService";

const Register = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const handleRegister = async (e) => {
    e.preventDefault();
    try {
      const userData = { email, password };
      const response = await registerUser(userData);
      console.log(response.data);
    } catch (error) {
      console.error("Error en el registro:", error);
    }
  };

  return (
    <form onSubmit={handleRegister}>
      <input
        type="email"
        value={email}
        onChange={(e) => setEmail(e.target.value)}
        placeholder="Email"
        required
      />
      <input
        type="password"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
        placeholder="Contraseña"
        required
      />
      <button type="submit">Registrar</button>
    </form>
  );
};

export default Register;
