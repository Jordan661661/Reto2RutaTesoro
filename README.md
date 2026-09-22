# 🗺️ Reto 2 - Ruta del Tesoro

Aplicación desarrollada en **C# con Windows Forms** que permite administrar una ruta del tesoro utilizando una **lista simplemente enlazada** como estructura de datos principal.

El sistema permite registrar diferentes ubicaciones de una ruta, guardar información sobre cada una de ellas y realizar operaciones básicas como insertar, buscar, modificar y eliminar registros.

## 📌 Descripción del proyecto

El proyecto **Reto2RutaTesoro** representa una ruta formada por diferentes ubicaciones. Cada ubicación contiene información que permite identificarla y describirla dentro de la ruta.

La información manejada por cada ubicación es:

- **ID:** identificador único de la ubicación.
- **Nombre:** nombre de la ubicación.
- **Pista:** pista relacionada con la ubicación.
- **Nivel de peligro:** nivel de peligro asignado a la ubicación.

La estructura utilizada para almacenar las ubicaciones es una **lista simplemente enlazada**, donde cada nodo contiene los datos de una ubicación y una referencia al siguiente nodo.

## 🎯 Objetivo

El objetivo principal del proyecto es poner en práctica el uso de **estructuras de datos dinámicas**, específicamente una lista simplemente enlazada, mediante una aplicación gráfica.

Con este proyecto se practican operaciones como:

- Inserción de nodos.
- Búsqueda de elementos.
- Modificación de información.
- Eliminación de nodos.
- Recorrido de la lista.
- Conteo de elementos.
- Visualización de los datos mediante un `DataGridView`.

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** Windows Forms
- **Entorno:** Visual Studio
- **Estructura de datos:** Lista simplemente enlazada
- **Interfaz gráfica:** Windows Forms
- **Control utilizado para mostrar información:** DataGridView

## 📂 Estructura del proyecto

### `FrmRutaTesoro.cs`

Es el formulario principal de la aplicación. Desde este formulario se pueden realizar las operaciones principales:

- Insertar una ubicación.
- Buscar una ubicación por ID.
- Modificar una ubicación.
- Eliminar una ubicación.
- Limpiar los campos.
- Seleccionar una ubicación desde la tabla.

Al iniciar el formulario se actualiza la información mostrada y se obtiene la cantidad actual de ubicaciones.

### `ListaSimple.cs`

Contiene la implementación de la **lista simplemente enlazada**.

La lista utiliza una referencia llamada `inicio`, que funciona como el punto de entrada de la ruta. Cada nodo está conectado con el siguiente mediante su referencia `Next`.

Entre las operaciones implementadas se encuentran:

#### Insertar

Agrega una nueva ubicación al final de la lista. Antes de realizar la inserción se verifica que no exista otra ubicación con el mismo ID.

#### Buscar

Recorre la lista desde el inicio hasta encontrar una ubicación cuyo ID coincida con el solicitado. Si no encuentra el elemento, devuelve `null`.

#### Modificar

Busca una ubicación mediante su ID y actualiza su nombre, pista y nivel de peligro. Si el ID no existe, la operación devuelve `false`.

#### Eliminar

Elimina una ubicación de la lista y reconecta los nodos para mantener la estructura enlazada. También contempla el caso en el que se elimina el primer nodo.

#### Recorrer

Recorre todos los nodos desde el inicio hasta `NULL` y genera una colección temporal utilizada principalmente para mostrar los datos en el `DataGridView`.

#### Contar

Recorre la lista y cuenta cuántos nodos existen actualmente.

## ⚙️ Funcionamiento

Al abrir la aplicación se muestra la información de las ubicaciones registradas en un `DataGridView`.

El usuario puede ingresar:

1. ID de la ubicación.
2. Nombre.
3. Pista.
4. Nivel de peligro.

Después puede utilizar los botones disponibles para realizar las diferentes operaciones.

### ➕ Insertar una ubicación

Para insertar una nueva ubicación se introduce un ID válido junto con sus datos.

El sistema verifica que el ID no esté repetido. Si todo es correcto, la nueva ubicación se agrega al final de la lista y la información de la tabla se actualiza.

### 🔎 Buscar una ubicación

El usuario introduce el ID que desea consultar.

Si la ubicación existe, sus datos se cargan automáticamente en los campos del formulario. Si no existe, se muestra un mensaje indicando que no fue encontrada.

### ✏️ Modificar una ubicación

Se introduce el ID de la ubicación y los nuevos datos.

El programa intenta modificar el nodo correspondiente. Si el ID no existe, se muestra un mensaje de advertencia.

### 🗑️ Eliminar una ubicación

El usuario proporciona el ID de la ubicación que desea eliminar.

Si existe, se elimina de la lista. En caso contrario, se informa que no se encontró el ID.

### 🧹 Limpiar campos

El botón de limpiar permite borrar la información introducida en los campos y regresar el nivel de peligro a su valor inicial.

### 📋 Seleccionar desde la tabla

También es posible seleccionar directamente una fila del `DataGridView`. Al hacer clic sobre ella, los datos de la ubicación se cargan nuevamente en los campos del formulario para poder consultarlos o modificarlos.

## 🔗 Estructura de la lista

La estructura general de la ruta puede representarse de la siguiente manera:

```text
Inicio
  │
  ▼
┌───────────────┐
│ Ubicación 1   │
│ ID            │
│ Nombre        │
│ Pista         │
│ Peligro       │
│ Next ─────────┼──────┐
└───────────────┘      │
                       ▼
                ┌───────────────┐
                │ Ubicación 2   │
                │ ID            │
                │ Nombre        │
                │ Pista         │
                │ Peligro       │
                │ Next ─────────┼──────┐
                └───────────────┘      │
                                       ▼
                                ┌───────────────┐
                                │ Ubicación 3   │
                                │ ...           │
                                │ Next → NULL   │
                                └───────────────┘
```

Cada ubicación apunta hacia la siguiente, formando la ruta.

## 🧠 Estructura de datos utilizada

Se utiliza una **lista simplemente enlazada** porque permite agregar y eliminar elementos de manera dinámica sin necesitar un tamaño fijo.

La lista mantiene una referencia al primer elemento, denominada `inicio`. A partir de ella se recorren los demás nodos mediante la propiedad `Next`.

## 🚀 Cómo ejecutar el proyecto

1. Descargar o clonar el repositorio.
2. Abrir la solución del proyecto en **Visual Studio**.
3. Verificar que estén disponibles todos los archivos y referencias necesarias.
4. Compilar el proyecto.
5. Ejecutar la aplicación.
6. Utilizar el formulario para administrar las ubicaciones de la ruta.

## 📋 Operaciones disponibles

| Operación | Descripción |
|---|---|
| Insertar | Agrega una nueva ubicación al final de la ruta. |
| Buscar | Busca una ubicación utilizando su ID. |
| Modificar | Actualiza los datos de una ubicación existente. |
| Eliminar | Elimina una ubicación de la lista. |
| Recorrer | Obtiene las ubicaciones almacenadas para mostrarlas. |
| Contar | Indica cuántas ubicaciones existen. |
| Limpiar | Limpia los campos del formulario. |

## 👨‍💻 Autor

**Jordan Rojas**

Proyecto académico: **Reto 2 - Ruta del Tesoro**

Desarrollado en **C# / Windows Forms** como práctica de estructuras de datos y listas simplemente enlazadas.
