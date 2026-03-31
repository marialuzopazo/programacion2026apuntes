import { useEffect, useState } from "react";

function App() {
  const [count, setCount] = useState(0);
  const [isShow, setIsShow] = useState(false);

  console.log("App");

  useEffect(() => {
    console.log("Render: APP");
  }, []);

  return (
    <>
      <h1>Hola</h1>
      <button onClick={() => setCount(count + 1)}>{count}</button>
      <hr />
      <button onClick={() => setIsShow(!isShow)}>Cambiar</button>
      {isShow && <Test />}
    </>
  );
}

export default App;

function Test() {
  const [results, setResults] = useState(null);

  useEffect(() => {
    console.log("Render");
    const controller = new AbortController();
    const signal = controller.signal;
    fetch("https://rickandmortyapi.com/api/character", { signal })
      .then((d) => d.json())
      .then((data) => setResults(data.results));
    return () => controller.abort();
  }, []);

  return (
    <>
      <h2>Soy Test</h2>
      {results?.map((c) => (
        <h3>{c.name}</h3>
      ))}
    </>
  );
}
