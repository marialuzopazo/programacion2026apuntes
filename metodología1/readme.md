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


























