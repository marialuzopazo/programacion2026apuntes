import { useState } from "react";
import CuentaContext from "./cuenta-context";

export default function CuentaProvider({ children }) {
  const [saldo, setSaldo] = useState(1000);

  const sacarPlata = (monto) => {
    if (saldo >= monto) {
      const resto = saldo - monto;
      setSaldo(resto);
    }
  };

  return (
    <CuentaContext.Provider value={{ saldo, sacarPlata }}>
      {children}
    </CuentaContext.Provider>
  );
}
