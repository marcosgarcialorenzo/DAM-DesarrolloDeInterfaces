# Desarrollo de Interfaces

Proyecto académico de la asignatura **Desarrollo de Interfaces**, desarrollado con
C# y .NET 10. La solución contiene un gestor de tareas en consola y una versión
gráfica para Windows Forms.

## Proyectos

- **GestorDeTareas**: aplicación de consola para crear, consultar, modificar,
  listar y eliminar tareas.
- **GestorDeTareasGrafico**: aplicación Windows Forms con una interfaz gráfica
  para gestionar las tareas.

Las dos aplicaciones organizan la lógica en capas sencillas:

- `Models`: modelos de datos.
- `Repositories`: almacenamiento y operaciones sobre las tareas.
- `Controllers`: lógica de gestión.
- `Views`: interacción con el usuario.

Actualmente, las tareas se almacenan en memoria y se pierden al cerrar la
aplicación.

## Requisitos

- [.NET SDK 10.0](https://dotnet.microsoft.com/download/dotnet/10.0) o posterior.
- Windows para ejecutar `GestorDeTareasGrafico`, ya que utiliza Windows Forms.
- Git para clonar el repositorio y gestionar los cambios.

La versión del SDK utilizada está definida en [`global.json`](global.json).

## Instalación y ejecución

Clona el repositorio y accede a su directorio:

```bash
git clone https://github.com/marcosgarcialorenzo/DAM-DesarrolloDeInterfaces.git
cd DAM-DesarrolloDeInterfaces
```

Restaura las dependencias y compila la solución:

```bash
dotnet restore
dotnet build
```

Inicia la aplicación de consola:

```bash
dotnet run --project GestorDeTareas
```

Inicia la aplicación gráfica:

```bash
dotnet run --project GestorDeTareasGrafico
```

También puedes abrir [`DesarrolloDeInterfaces.sln`](DesarrolloDeInterfaces.sln)
con JetBrains Rider o Visual Studio y ejecutar el proyecto que quieras.

## Funcionalidades

Desde la aplicación de consola se puede:

1. Añadir tareas.
2. Listar todas las tareas.
3. Consultar una tarea por su nombre.
4. Modificar el nombre y la descripción.
5. Cambiar el estado entre pendiente y completada.
6. Eliminar tareas.

La aplicación gráfica ofrece estas mismas operaciones mediante un formulario
con lista de tareas, campos de edición y botones de alta, modificación y
eliminación.

## Flujo de trabajo con Git y GitHub

Comprueba el estado del repositorio antes de empezar:

```bash
git status
git branch
```

Crea una rama para cada cambio y trabaja sobre ella:

```bash
git switch -c feature/mejorar-interfaz
```

Cuando termines un cambio, revisa los archivos modificados, añádelos al área
de preparación y crea un commit con `git commit -m`:

```bash
git diff
git add README.md
git commit -m "docs: actualizar documentación del proyecto"
```

El mensaje debe ser breve y explicar el cambio realizado. Algunos ejemplos:

```bash
git commit -m "feat: añadir validación de tareas duplicadas"
git commit -m "fix: corregir eliminación de tareas"
git commit -m "refactor: separar la lógica del controlador"
git commit -m "docs: añadir instrucciones de ejecución"
```

Sube la rama a GitHub:

```bash
git push -u origin feature/mejorar-interfaz
```

Después, abre una *pull request* en GitHub para revisar y fusionar los
cambios en la rama principal. Antes de subirlos, comprueba que la solución
compila correctamente con `dotnet build`.

Para actualizar la copia local con los cambios de la rama principal:

```bash
git switch main
git pull origin main
```

No incluyas contraseñas, tokens ni otros datos sensibles en los commits.

## Licencia

Este proyecto se distribuye bajo la [licencia MIT](LICENSE).
