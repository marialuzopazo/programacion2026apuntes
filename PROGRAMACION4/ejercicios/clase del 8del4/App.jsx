import AbuOlivera from "./components/abu-olivera";
import CuentaProvider from "./context/cuenta-provider";

function App() {
  return (
    <>
      <h1>Hola</h1>
      <CuentaProvider>
        <AbuOlivera />
      </CuentaProvider>
    </>
  );
}

export default App;
