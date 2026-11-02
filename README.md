[2026-10-05 - Receta.md](https://github.com/user-attachments/files/34276710/2026-10-05.-.Receta.md)
## Universidad Tecnológica Nacional Facultad Regional Rosario

Ingeniería en Sistemas de Información

## Evaluación Aprobación Directa en PC - Tema: Receta

Desarrollar una aplicación .NET aplicando los principios de arquitectura, buenas prácticas y lineamientos vistos en clase y aplicados en el TPI que resuelva las consignas solicitadas a continuación, considerando:

- Capa de Presentación: puede elegir Escritorio (Windows Forms) o Web (Blazor). Debe comunicarse con los servicios mediante una API Rest.

- Servicios: todos deben ser asíncronos y se deben poder testear mediante swagger.

- Utilice el patrón repositorio para resolver el acceso a datos mediante EF, y asegúrese que la base de datos se cree con el nombre dbReceta siguiendo los mecanismos que provee EF.

Criterios de Evaluación: serán considerados el correcto funcionamiento (compilación/ejecución sin errores), uso de convenciones solicitadas, estética visual de las pantallas, estándares y buenas prácticas.

Crear carpeta con su ApellidoNombre y dentro de ella todo lo solicitado. Cada proyecto y namespace debe respetar el formato: [Apellido].[NombreProyecto]. Ejemplo: Perez.Presentacion

La aplicación debe gestionar la entidad Receta con:

## 1. Creación de la estructura del proyecto y entidad/es de Negocio

| Atributo | Ejemplo |
| --- | --- |
| Id: entero, autoincremental y clave primaria | 1 |
| DniPaciente: cadena de texto | 33444555 |
| FechaEmision: fecha | 05/10/2026 |
| Cantidad: número entero positivo | 2 |
| Cobertura: cadena de texto ( “Obra Social”, | Obra Social |
| “Prepaga”, “Particular”) |   |
| Estado: cadena de texto ( "Emitida", "Dispensada") Emitida / Dispensada |   |

## 2. API de Servicios

Agregue los endpoints necesarios para implementar la siguiente funcionalidad:

- a. Recuperar registros según el estado de la Receta.

- b. Agregar nuevo registro, considerando que la Receta debe crearse siempre como “Emitida”.

- c. Dispensar una Receta.

Implementar la lógica de validación, considerando:

- a. Los campos “DniPaciente” y “Cobertura” son obligatorios.

- b. El campo “Cantidad” tiene que ser un valor entero entre 1 y 5.

- c. El campo “FechaEmision” debe ser igual a la fecha de hoy o el día previo.

- a. Genere una pantalla que permita listar los datos recuperados de la base de datos consumiendo los servicios creados previamente. Agregue un control tipo lista que tenga pre-seteados los valores “Emitida” y “Dispensada” que será utilizado para buscar las Recetas por estado. Incluya un botón que ejecute el filtro y actualice el listado en pantalla.

- b. Construya la pantalla de alta de la entidad que sea llamada mediante un botón “Agregar” desde la pantalla del listado. Tenga presente que el usuario no debería poder indicar el estado en el momento de hacer el alta. El estado debe ser pre-seteado automáticamente en el servicio como “Emitida”.

- c. Sobre la pantalla del listado agregue la posibilidad de que una receta pueda ser “Dispensada”.

## 3. Validaciones
Implementar la lógica de validación, considerando:

- a. Los campos “DniPaciente” y “Cobertura” son obligatorios.
  
- b. El campo “Cantidad” tiene que ser un valor entero entre 1 y 5.
  
- c. El campo “FechaEmision” debe ser igual a la fecha de hoy o el día previo.

## 4. Presentación
- a. Genere una pantalla que permita listar los datos recuperados de la base de datos consumiendo los
servicios creados previamente. Agregue un control tipo lista que tenga pre-seteados los valores
“Emitida” y “Dispensada” que será utilizado para buscar las Recetas por estado. Incluya un botón
que ejecute el filtro y actualice el listado en pantalla.

- b. Construya la pantalla de alta de la entidad que sea llamada mediante un botón “Agregar” desde la
pantalla del listado. Tenga presente que el usuario no debería poder indicar el estado en el momento
de hacer el alta. El estado debe ser pre-seteado automáticamente en el servicio como “Emitida”.

- c. Sobre la pantalla del listado agregue la posibilidad de que una receta pueda ser “Dispensada”
