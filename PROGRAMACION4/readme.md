## fechas de parciales ESTIMADAS 

- 11 al 22 de mayo es el primer parcial
- julio de 6 al 10 el globalizador
- la defensa del tp, tambien el 8 9 de julio
- y entre el 29 de junio al 3 de julio  
---


carpeta apuntes y ejercicios de programacion4

# videos variados para refrescar contenidos de programacion 2 y 3 

https://www.youtube.com/watch?v=SI7O81GMG2A  (teoria de orientado a objeto, pilares principales y conceptos basicos)


# videos de referencia para programacion 4 

https://www.youtube.com/watch?v=yIr_1CasXkM   ( react )

---
## CONCEPTOS BASICOS DE REACT:

react es la Biblioteca de JavaScript para construir interfaces de usuario (lo que el usuario ve y toca).

DOM
Estructura en árbol del HTML (ej: < html > → < body > → <  div  >).

Problema: Manipularlo directamente es lento y engorroso.

Virtual DOM
Copia en memoria del DOM real. React cambia esta copia, la compara con la real y solo actualiza lo necesario (muy rápido).

JSX
Extensión de JavaScript que permite escribir HTML dentro de JS.

Componentes (el corazón de React)
Componente
Bloque reutilizable que encapsula estructura (HTML), estilo (CSS) y comportamiento (JS).
Ejemplo visual: Un botón, un formulario, una tarjeta de producto.

Props
Datos que recibe un componente de su padre (solo lectura, como parámetros de función).
Ejemplo: <Usuario nombre="Ana" edad={25} /> → dentro usas props.nombre.

Estado (state)
Dato interno de un componente que puede cambiar y, al cambiar, React re-renderiza el componente.
Ejemplo visual: Contador que aumenta al hacer clic.

useState
Hook para declarar estado en componentes funcionales.

Ciclo de vida y efectos
useEffect
Hook para ejecutar código en momentos específicos: cuando el componente se monta, se actualiza o se desmonta.
Utilidad: Llamadas a API, suscripciones, modificar el DOM directamente.

Dependencias (array)
Lista en useEffect que indica qué variables debe vigilar para re-ejecutar el efecto.
Vacío []: solo una vez al montar.

Comunicación entre componentes
Props drilling
Pasar datos desde un componente muy arriba hasta uno muy abajo, pasando por componentes intermedios que no necesitan esos datos.
Problema: Engorroso y acoplado.

Contexto (Context)
Permite compartir datos globales sin pasar props manualmente por cada nivel.
Ejemplo: Tema (oscuro/claro), usuario loguea

useContext
Hook para leer el valor de un Contexto directamente.

5. Hooks principales (además de useState y useEffect)
useRef
Guarda un valor mutable que no causa re-render al cambiar. También sirve para apuntar a un elemento del DOM.
Ejemplo: Enfocar un input al cargar la página.

useMemo
Memoiza (cachea) el resultado de un cálculo costoso para no recalcular en cada render.
Ejemplo: Filtrar una lista grande de productos.

useCallback
Memoiza la función en sí, útil para pasarla a componentes hijos y evitar renders innecesarios.

useReducer
Alternativa a useState para lógica de estado compleja (múltiples sub-valores o transiciones dependientes).
Ejemplo: Formulario con muchos campos o carrito de compras.

6. Importancia práctica (¿por qué aprenderlos?)
Componentes → Reutilización y orden.

Estado + Virtual DOM → Interfaz reactiva y rápida.

Props y Context → Datos fluyen de forma predecible.

Hooks → Lógica reutilizable y separada por preocupaciones.
Componente funcional
Función de JS que retorna JSX. Hoy es el estándar.

sobre use reducer:
Un reducer ayuda a mantener los controladores de eventos cortos y concisos. Sin embargo, a medida que tu aplicación crece, puedes encontrarte con otra dificultad. Actualmente, el estado tasks y la función dispatch sólo están disponibles en el componente de nivel superior TaskApp. Para permitir que otros componentes lean la lista de tareas o la modifiquen, tienes que pasar explícitamente el estado actual y los controladores de eventos que lo cambian como props.

<img width="1308" height="713" alt="image" src="https://github.com/user-attachments/assets/5f9ec5c7-d9d4-47ae-9ffa-7a096860c2d2" /> 

https://lenguajejs.com/react/datos/context-api/  sitio web que explica Prop Drilling etc. y hooks en general 


