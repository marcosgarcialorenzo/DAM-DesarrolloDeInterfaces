# Desarrollo de Interfaces

Proyecto académico de la asignatura **Desarrollo de Interfaces**, desarrollado con .NET 10 y C#.

## Contenido

La solución incluye los siguientes proyectos:

- **GestorDeTareas**: aplicación de consola para crear, consultar, modificar, listar y eliminar tareas.
- **WinFormsApp1**: aplicación base de Windows Forms para el desarrollo de interfaces gráficas.

El gestor de tareas aplica una separación sencilla por capas:

- `Models`: modelo de datos de las tareas.
- `Repositories`: almacenamiento y operaciones sobre las tareas.
- `Controllers`: lógica de interacción con el repositorio.
- `Views`: menú e interacción con la consola.

## Requisitos

- .NET SDK 10.0 o posterior.
- Windows para ejecutar el proyecto `WinFormsApp1`.

La versión del SDK está definida en [`global.json`](global.json).

## Cómo ejecutar

Clona el repositorio y accede a su directorio:

```bash
git clone https://github.com/marcosgarcialorenzo/DAM-DesarrolloDeInterfaces.git
cd DAM-DesarrolloDeInterfaces
```

Para iniciar el gestor de tareas:

```bash
dotnet run --project GestorDeTareas
```

Para iniciar la aplicación Windows Forms:

```bash
dotnet run --project WinFormsApp1
```

También se puede abrir [`DesarrolloDeInterfaces.sln`](DesarrolloDeInterfaces.sln) con JetBrains Rider o Visual Studio y ejecutar el proyecto deseado.

## Funcionalidades del gestor de tareas

Desde el menú de consola se puede:

1. Añadir tareas.
2. Listar todas las tareas.
3. Consultar una tarea por su nombre.
4. Modificar el nombre de una tarea.
5. Modificar su descripción.
6. Cambiar su estado entre pendiente y completada.
7. Eliminar tareas.

## Licencia

Este proyecto se distribuye bajo la [licencia MIT](LICENSE).
