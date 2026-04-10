# apuntes de clase
---

el origen de los proyectos es porque surge
un problema que resolver, una oportunidad que antes no se haya creado y/o por una estrategia para vender u optimizar
estas son las preguntas que vamos a responder con cada una 
- el problema, que duele ?
- la oportunidad, que falta ?
- la estrategia, que conviene controlar del proceso ?

  el cliente trar el problema, luego se analizan los requisitos y requirimientos del mismo

  algunos de los errores principalmente se centran en la comunicaci{on
  entre el cliente y el analista puede exitir errores de ambiguedad
  entre el analista y el programador, los supuestos.
  entre el cliente y el programador, la distancia.
en lo que respecta a los errores,el codigo estadisticamente no entre en lo principales

# proyecto vs producto 

el producto empieza como un proyecto y se mantiene constante con actualización permanente 
elproyecto tiene un inicio y un final y en comparación al producto es este ultimo el que necesita de iteracciones y mantenimiento 
en el caso de los proyectos, tienene un presupuesto usualmente acotado o cerrado 
con un entregable especifico 
y cuando se finaliza el proyecto, el equipo se disuelve. 
no todos son iguales segun su etapa de desarrollo

# proyecto greenfield

Un proyecto greenfield es una iniciativa que se desarrolla desde cero, en un terreno o entorno totalmente virgen, sin las limitaciones, restricciones o infraestructura de proyectos anteriores. Permite la creación nueva, con máxima flexibilidad de diseño, pero suele implicar mayor inversión inicial y riesgo que un proyecto.

## Conceptos basicos 

- INTEGRAR una api, es el concepto de usarla, consumirla.
- MIGRAR es cuando una plataforma se traslada a una nueva.
- REINGENIERIA o RESCATE es cuando un proyecto en riesgo falla o se replantea.
- ARTEFACTO es un producto tangible, que se puede consultar que es parte del resultado del proceso de desarrollo. algunos artefactos como los casos de suso, diagrama de clases y otros modelos, uml, etc, ayudan a la descripción y por ende al mantenimiento. 

# que tan seguido fallan los proyectos ? 

estadisticamente el 20 % de los proyectos tuenen exito 
el 33 % tiene problemas 
y el 46 % se cancelan 

las causas mas comunes son: 
- requirimientos incompletos o cambiantes
- falta de participación del usuario
- expectativas no alineadas entre el cliente y el equipo
- cambios de alcance sin control

## como se estructuran los proyectos ?

SDLC (es el ciclo de vida de desarrollo de software )
# S software 
# D development 
# L Life 
# C cycle 

---
## ETAPAS de un proyecto 

uno puede elegir trabajar o desarrollarse en cualquiera de estas 

requirimientos - diseño - implementación - testing - despliegue y mantenimiento.
---

ejemplo de clase :  APLICACION DE TURNOS MÉDICOS 

De las primeras cosas que tenemos que preguntar es:

- cuales son los requerimientos basicos de la aplicación ?
- que tipo de aplicación es ?
- recibe notificaciones?
- cuantos perfiles va a tener ?
- con que nos vamos a integrar ?

en un proyecto es el ARQUITECTO el que pone al tanto a los programadores nuevos 

- COSAS QUE REVISAMOS GRUPALMENTE:
dos clases existentes, el medico y el paciente
iene sucursales
cancelaciones
disponibilidad, y horarios de los medicos
datos e identificaciones
integraciones del calendario de google
integraciones medios de pago
integraciones para correo o whatsapp para notificaciones

## ARTEFACTOS 
existen distintos tipos de artefactos:
- requerimientos
- especificacion
es el documento que define que se debe hacer, TODO lo que NO ESTE en el documento NO EXISTE
para el equipo tecnico, todo lo que este MAL ESCRITO, puede generar problemas.

estos son los errores tipicos en la etapa de requerimientos: 
AMBIGUEDAD, donde cada persona interpreta algo distinto, requirimientos IMPLICITOS en donde el cliente ASUME que es obvio. Requirimientos CONTRADICTORIOS, donde dos stakeholders piden cosas incompatibles, y el Scope creep ( scope es alcance ) el alcance crece durante el relevamiento sin control ni priorizacion. 

# en el área de diseño: 

Se define la arquitectura, lo que hace el arquitecto o el programador con mas experiencia y se genera un diagrama si falla a la hora de la arquitectura, por ejemplo: 
si hay errpres de bases de datos, se pierden los datos, y cuando hay que hacer migraciones, esos eroores suelen ser muy costosos por la perdida que producen. 

de que se trata ?
se define como va a estar construido el sistema antes de escribir el codigo. 
se eligen los lenguajes, el framework, la infraestructura, la estimación de tiempo y recursos. 

el ARTEFACTO que se utiliza es el documento TECNICO 
en donde se define la arquitectura del sistema, el modelo de datos, las interfaces del usuario y las decisiones tecnologicas. 
- es el DOCUMENTO que el equipo de desarrollo va a consultar durante toda la implementación

ERRORES TIPICOS EN ESTA ETAPA : 
- OVER ENGINEERING que es diseñar para una escala o complejidad que el sistema nunca va a necesitar
- UNDER-ENGINEERING: diseñar sin considerar el crecimiento futuro del sistema 
-DECISIONES TECNOLOGICAS: elegir una tecnología por ser nueva, no por ser la correcta para el problema.
-DISEÑO SIN VALIDACION: nunca se confirma con el cliente que el diseño resuelve el problema original. 

# en el area de implementacion: 

en esta etapa, el programador hace el codigo fuente, el codigo, fuente versionado y la documentacion tecnica del sistema 
que pasa si se hace mal ?
cada desarrollador interpreta el diseño a su manera, el modulo de turnos y el de notificaciones no se integrarian de manera correcta 

esta etapa se trata de CONSTRUIR todo lo que se diseño

se realiza: 
- estructura de codigo
- revision de codigo
- documentacion tecnica del codigo
- integracion continua de los componenetes de desarrollo
- comunicacion constante con el equipo ante dudas o bloqueos

toda documentacion que nos ayude a entender el codigo es ideal porque el codigo es mentenible y debe ser claro. 

el ARTEFACTO ES : el codigo fuente + la documentacion tecnica. 
la documentacion que vive cerca del codigo, y explica porque se tomo una decision de implementacion que no es evidente. 

ERRORES TIPICOS: 
las DEUDAS TECNICAS , que son las soluciones rapidas que resuelven el problema cual parche, y complican el codigo de mañana. 

deuda técnica: ES EL COSTO FUTURO de retrabajo que surge al priorizar la entrega rápida de software sobre una mejor solución o diseño. asumiento atajos en el código 

REFACTORIZACION: 
es la técnica que mejora la estructura interna del código fuente ( legibilidad , mantenibilidad ) SIN ALTERAR SU COMPORTAMIENTO EXTERNO. 
Se usa para eliminar la deuda técnica, reducir la complejidad y facilitar 
futuros cambios. 

# en el area de TESTING

se prueba que el sistema funcione según lo esperado 
lo hace el QA 
produce el plan de pruebas y reportes de defectos. 
que pasa si se hace mal ? 
entonces el sistema pasa todos los test técnicos pero la recepcionista después no 
puede usarlo. 

se hace las pruebas unitarias, las pruebas de integración, las pruebas 
de sistema 
las pruebas de aceptación. 

artefacto es:
el plan de pruebas + el reporte de defectos 

UN SISTEMA QUE PASA TODAS LAS PRUEBAS TECNICAS PERO NO RESUELVE EL PROBLEMA DEL CLIENTE NO ES UN EXITO, ES UN FRACASO BIEN DOCUMENTADO 

los errores típicos: 

testing como etapa final 
pruebas insuficientes
testing solo a cargo del qa 
validación saltada.

***TEST DRIVEN DESING***

Casos border (Edge cases)
implican fallos en la aplicación o vulnerabilidades de seguridad, suelen ser 
casos extremos o comportamientos de usuarios poco frecuentes  

----------------------------------------------

Despliegue 

se sube a producción y se sube en el servidor o en la nube o local 

PRODUCCION esta listo para usar 

DEVOs es el que despliega el proyecto.
Si hay algo nuevo, se debe generar alguna explicación o documentación 
para capacitar al usuario como usarlo. 

copia de seguridad (backup)
una copia de datos digitales almacenada por separado del original para 
permitir su restauración 

REVERSION de cambios (rollback)
es el proceso de revertir un sistema, aplicación o base de datos, a un estado estable anterior después de una implementación fallida o un erro, sirve como 
mecanismo de seguridad, asegurando la integridad de los datos y minimizand el tiempo de inactividad. 


---
Clase 4 - REQUERIMIENTOS 
---

REQUERIMIENTOS:
nos enfocamos que cosas necesita el cliente 
como lo obtenemos 
como lo documentamos para que el equipo pueda construirlo ?

"la mayor parte de los problemas empiezan por aca"

- funciones que datos de entrada y de salida y que va a procesar 
- todo lo que se pueda ver y tocar es un requerimiento funcional 

/cargar un medico - revisar los usuarios y verificar los usuarios - agendar los turnos 
/ que se repeten las reglas del negocio ( horarios y verificaciones de feriados, etc ) 
/ no poder sacar sobre turnos - notificaciones del sistema y del usuario 


un requerimiento NO DESCRIBE como lo hace internamente eso es diseño, describe que hace desde la perspectiva del usuario 


-feature: 	FUNCIONALIDAD ( una accion se que se puede aislar )

Es una unidad, a menudo aislable, como una barra de búsqueda, la autenticación de usuarios o un botonn para activar el modo oscuro. 

funcionalidad es una capacidad del sistema de alto nivel como la gestión de turnos
es la descomposición de esa funcionalidad en comportamientos específicos, concretos y verificables 
la diferencia importa porque una funcionalidad no se puede probar directamente, un requerimiento funcional si. 

en el caso de la app // gestión de turnos, gestión de pacientes y las notificaciones 

requerimientos NO FUNCIONALES : 

son parte del sistema
la seguridad, la rapidez, que sea escalable, que se pueda usar por muchos usuarios, etc 
son algunos de los requerimientos que hacen a los no funcionales. 

los requerimientos NO FUNCIONALES son tan importantes como los funcionales
frecuentemente se omiten o se escriben de forma vaga. 

no alcanza con querer que el sistema sea rápido, tenemos que medirlo y cuantificarlo. 

<img width="797" height="528" alt="image" src="https://github.com/user-attachments/assets/639095a9-ac75-4853-84a1-9fbef9a4692e" />

---
Requerimientos de usuario vs de sistema
---

# DE USUARIO: 

el recepcionista debe poder registrar un nuevo turno
el paciente debe poder cancelar su turno 
el medico debe poder ver su agenda 

# de sistema 

el sistema debe validad que la fecha y hora de turno no coincida con otro turno existente para el mismo medico antes de confirmar 
el sistema debe permitir la cancelacion de un turno hasta 2 horas antes de la hora asignada.
el sistema debe mostrar los turnos del dia ordenados por hora, por nombre del paciente, motivo de consulta

** importante **

los requerimientos de usuario estan escritos en lenguaje de negocio 

los requisitos del sistema son tecnicos y especificos.
el cliente tiene que confirmar que el comportamiento descrito es el que realmente se necesita. 

---
Como se escriben los requerimientos bien definidos ?
---

debe ser especifico, alcanzable, definido, claro, evitar ambiguedades, escalable y medible ( CUANTOS USUARIOS, CUANTO TIEMPO ETC ) 

- debe estar claro quien realiza la acciones ( el usuario o el sistema )
- verbos precisos: debe, no debería ni podria
- condiciones especificas: bajo que circunstancias
- criterio verificable: como sabemos que esta cumplido

ejemplo: 
MAL ESCRITO: 
el sistema debe ser rapido 

BIEN ESCRITO: 
el sistema debe responder en menos de 2 segundos con hasta 100 usuarios simultaneos. 

---
tecnicas de relevamiento: entrevistas
---

entrevistas, escuchar y tomar notas - se graba o se escribe tal cual lo que pide el cliente.
conversacion estructurada entre el analista y uno o mas del stakeholders con el objetivo de obtener informacion sobre necesidades, procesos y restricciones. 

- regla de documentar textualmente durante la entrevista
- regla: lo que el cliente dijo exactamente y lo que el analista entendio pueden ser cosas distintas
- reglas: si el analista que interpreta en tiempo real, puede ser que este introduciendo sus propios supuestos en el registro.

# TIPOS DE ENTREVISTAS: ( estructurada y semi estructurada ) 

ESTRUCTURADA: el analista tiene un listado de preguntas predefinidas util cuando el tiempo es limitado o el stakeholder es dificil de acceder. 
SEMI ESTRUCTURADA: el analista tiene un guion base pero permite que la conversacion derive hacia temas no anticipados, util para descubrir requerimientos implicitos

REGLAS PRACTICAS PARA LAS ENTREVISTAS: entrevistas al usuario final, no solo al cliente que paga o gestiona el proyecto 
preguntar por el proceso actual antes de hablar del sistema nuevo ( QUE COSAS HACEN HOY Y COMO SE HACEN PARA SABER COMO MEJORAR Y CUAL ES EL COMPORTAMIENTO ) 
documentar textualmente, no interpretar durante la entrevista. 

---
TECNICAS DE RELEVANIENTO: observaciones directas y talleres conjuntos 
---

- observacion directa, se va al lugar y se ve como trabajan.
- talleres conjunto, reuniones en grupo.

---
PROTOTIPADO
---

prototipado de baja fidelidad y prototipado de alta fidelidad 

---
CLASE 5
---

# HISTORIAS DE USUARIO 

el requerimiento desde la perspectiva del usuario 

# QUE ES ?
una descripcion corta y simple de una funcionalidad del sistema desde la perspectiva del usuario que la necesita 
NO DESCRIBE como se implementa, describe que valor genera para quien 

# PARA QUE SIRVE ?

* poner el foco en el valor al usuario, no en la funcionalidad tecnica
* facilita la conversacion entre el cliente y el equipo
* ser la unidad basica de planificacion en metodologias agiles

## ESTRUCTURA: como (rol ) - quiero (accion ) - para (valor-beneficio) 
rol quien lo necesita quiero quien lo necesita y que quiere hacer valor, para que lo necesita ?

## crtiterios de aceptacion 

condiciones concretas y verificables que deben coumplir para considerar una historia de usuario correctamente implementada. son el contrato entre el equipo entre el equipo y el cliente sobre que significa "listo"

ejemplo: 

### HISTORIA DE USUARIO 

- COMO recepcionista quiero registrar un nuevo turno para confirmar la atencion del paciente:

### CRITERIOS DE ACEPTACION 

- el sistema valida que el horario no este ocupado
- el paciente recibe confirmacion por mensaje
- el turno aparece en la agenda del medico

ejercitacion en donde ponemos en practica las historias de usuario aplicadas al ejemplo de la app de turnos medicos 

<img width="766" height="346" alt="image" src="https://github.com/user-attachments/assets/623164fa-30e8-4e06-af0f-884f88756c06" />

# HAPPY PATH - flujo feliz 

es el escenario ideal por defecto en el que un usuario completa una tarea con exito. sin encontrar errores, excepciones ni comportamientos esperados. representa el recorrido mas directo y libre de fricciones 

# CASOS DE USO 

el requerimiento desde la pespectiva del sistema 

## que es ? 

Es una descripcion detallada y estructurada de como el sistema responde a una accion de un actor externo 
documenta no solo el flujo exitoso o happy path sino todas las variaciones y errores posibles 

LOS CASOS DE USO Y LAS HISTORIAS DE USUARIO SON HERRAMIENTAS COMPLEMENTARIAS

# estructura de los casos de uso 

<img width="706" height="316" alt="image" src="https://github.com/user-attachments/assets/21049b67-1cfc-49bd-8d9e-84abff5c5397" /> 







de baja fidelidad: bocetos en papel y wireframes simples sin funcionalidad // se usa para validar requisitos.
de alta fidelidad: maqueta interactica que simula la experiencia real del sistema

el valor real del proptotipado es que hace visible lo que las palabras no pueden describir con precision 
un cliente puede tener dificultad para expresar como quiere que se vea una pantalla, pero cuando se le muestra un boceto puede decir imediatamente cosas como : 
esto es lo que necesito, falta este dato...
esa retroalimentacion temprana es mucho mas barata que descubrirlo durante el testint o despues del despliegue

el PROTOTIPADO ES UNA herramienta de comunicacion y validacion. 

https://vercel.com/    probamos con esta aplicacion 


















