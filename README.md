# Sistema Académico San José

Sistema web desarrollado en ASP.NET Core MVC para la gestión de expedientes académicos de alumnos, materias y calificaciones.

---

# Descripción del Proyecto

El Sistema Académico San José permite administrar de forma digital la información académica de los estudiantes de una institución educativa.

El sistema permite:

- Registrar alumnos
- Registrar materias
- Gestionar expedientes académicos
- Asignar notas finales
- Consultar promedios
- Visualizar estadísticas mediante gráficas

El proyecto fue desarrollado utilizando:

- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Bootstrap
- Chart.js

---

# Tecnologías Utilizadas

| Tecnología | Descripción |
|---|---|
| ASP.NET Core MVC | Framework principal del sistema |
| Entity Framework Core | ORM para manejo de base de datos |
| MySQL | Sistema gestor de base de datos |
| Bootstrap 5 | Diseño visual y responsive |
| Bootstrap Icons | Iconografía moderna |
| Chart.js | Gráficas estadísticas |

---

# Estructura de la Base de Datos

El sistema utiliza tres tablas principales:

## Alumno

Almacena la información de los estudiantes.

Campos:
- AlumnoId
- Nombre
- Apellido
- FechaNacimiento
- Grado

---

## Materia

Almacena las materias impartidas por la institución.

Campos:
- MateriaId
- NombreMateria
- Docente

---

## Expediente

Tabla intermedia que relaciona alumnos y materias.

Campos:
- ExpedienteId
- AlumnoId
- MateriaId
- NotaFinal
- Observaciones

---

# Relación Entre Tablas

- Un alumno puede cursar muchas materias.
- Una materia puede ser cursada por muchos alumnos.
- La tabla Expediente administra la relación muchos a muchos.

---

# Funcionalidades Implementadas

# Gestión de Alumnos

Permite:

- Agregar alumnos
- Editar alumnos
- Eliminar alumnos
- Consultar detalles
- Buscar alumnos dinámicamente
- Filtrar alumnos por grado

Características:
- Dropdown para selección de grado
- Interfaz moderna
- Botones con íconos Bootstrap
- Validación visual

---

# Gestión de Materias

Permite:

- Agregar materias
- Editar materias
- Eliminar materias
- Consultar detalles

Características:
- Interfaz moderna
- CRUD completo
- Diseño consistente

---

# Gestión de Expedientes

Permite:

- Registrar expedientes académicos
- Asociar alumnos con materias
- Registrar notas finales
- Registrar observaciones docentes

Características:
- Dropdowns dinámicos
- Visualización de nombres en lugar de IDs
- Búsqueda dinámica
- Interfaz moderna
- CRUD completo

---

# Validaciones del Sistema

El sistema valida:

- Relaciones entre tablas
- Integridad referencial
- Restricciones de eliminación

Ejemplo:
No se permite eliminar un alumno que tenga expedientes registrados.

---

# Reporte de Promedios

El sistema genera automáticamente:

- Promedio de notas por alumno
- Tabla resumen de resultados

---

# Gráficas Estadísticas

El sistema incluye gráficas dinámicas utilizando Chart.js.

Características:
- Gráfica de barras
- Colores dinámicos
- Barras redondeadas
- Visualización clara de promedios

---

# Interfaz Gráfica

El sistema incluye:

- Navbar moderna
- Dashboard principal
- Cards visuales
- Tablas modernas
- Íconos Bootstrap
- Diseño responsive

---

# Patrón Arquitectónico

El proyecto implementa correctamente el patrón MVC:

## Models
Representan la estructura de datos y entidades.

## Views
Interfaz gráfica y páginas Razor.

## Controllers
Gestionan la lógica y comunicación entre modelos y vistas.

---

# Configuración del Proyecto

## Requisitos

- Visual Studio 2026
- .NET 8
- MySQL Server
- MySQL Workbench

---

# Paquetes NuGet Utilizados

```bash
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Tools
Pomelo.EntityFrameworkCore.MySql