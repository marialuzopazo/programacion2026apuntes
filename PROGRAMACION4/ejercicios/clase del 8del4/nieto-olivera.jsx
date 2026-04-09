import { useCuenta } from "../hooks/use-cuenta";

export default function NietoOlivera() {
  const { sacarPlata } = useCuenta();
  return (
    <>
      <div>Soy el Nieto 👦</div>
      <button onClick={() => sacarPlata(50)}>Sacar para caramelos</button>
    </>
  );
}
