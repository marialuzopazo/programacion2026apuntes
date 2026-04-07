import { useReducer } from "react";

const initialState = {
  ml: 0,
  cm3: 0,
  litros: 0,
};

function reducer(state, action) {
  switch (action.type) {
    case "CHANGE_ML":
      return {
        ml: action.payload,
        cm3: action.payload,
        litros: action.payload / 1000,
      };

    case "CHANGE_CM3":
      return {
        ml: action.payload,
        cm3: action.payload,
        litros: action.payload / 1000,
      };

    case "CHANGE_LITROS":
      return {
        ml: action.payload * 1000,
        cm3: action.payload * 1000,
        litros: action.payload,
      };

    default:
      return state;
  }
}

function App() {
  const [state, dispatch] = useReducer(reducer, initialState);

  return (
    <main className="min-h-screen bg-gradient-to-r from-pink-200 to-purple-200 flex items-center justify-center">
      
      <div className="bg-white p-6 rounded-3xl shadow-xl border-4 border-pink-400 w-80">
        
        <h1 className="text-2xl mb-4 text-pink-500 text-center">
          🌸 Conversor de Volumen 🌸
        </h1>

        {/* ML */}
        <p>ml: {state.ml}</p>
        <input
          className="border p-2 rounded mb-3 w-full"
          type="number"
          value={state.ml}
          onChange={(e) =>
            dispatch({
              type: "CHANGE_ML",
              payload: Number(e.target.value),
            })
          }
        />

        {/* CM3 */}
        <p>cm³: {state.cm3}</p>
        <input
          className="border p-2 rounded mb-3 w-full"
          type="number"
          value={state.cm3}
          onChange={(e) =>
            dispatch({
              type: "CHANGE_CM3",
              payload: Number(e.target.value),
            })
          }
        />

        {/* LITROS */}
        <p>Litros: {state.litros}</p>
        <input
          className="border p-2 rounded w-full"
          type="number"
          value={state.litros}
          onChange={(e) =>
            dispatch({
              type: "CHANGE_LITROS",
              payload: Number(e.target.value),
            })
          }
        />

      </div>
    </main>
  );
}

export default App;