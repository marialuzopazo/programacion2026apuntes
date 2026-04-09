import { useCuenta } from "../hooks/use-cuenta";
import NietoOlivera from "./nieto-olivera";

export default function HijoOlivera() {
  const { sacarPlata } = useCuenta();
  return (
    <>
      <div>Soy el Hijo 🧑</div>
      <button onClick={() => sacarPlata(100)}>Sacar plata</button>
      <NietoOlivera />
    </>
  );
}
