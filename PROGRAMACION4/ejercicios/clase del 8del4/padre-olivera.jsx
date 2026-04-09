import { useCuenta } from "../hooks/use-cuenta";
import HijoOlivera from "./hijo-olivera";

export default function PadreOlivera() {
  const { saldo, sacarPlata } = useCuenta();

  return (
    <>
      <div>Soy el Padre 🧔</div>
      <p>Saldo: {saldo}</p>
      <button onClick={() => sacarPlata(300)}>Sacar plata al abu</button>
      <HijoOlivera />
    </>
  );
}
