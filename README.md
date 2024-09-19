# TaskManagementSystem

## Descripción

TaskManagementSystem es una aplicación web diseñada para gestionar tareas de manera eficiente. La aplicación incluye autenticación de usuarios y un sistema de roles que permite diferentes niveles de acceso y funcionalidad:

- **Administrador**: Puede crear, editar y eliminar usuarios y tareas.
- **Supervisor**: Puede asignar tareas a empleados y cambiar el estado de las tareas.
- **Empleado**: Puede ver sus tareas asignadas y actualizar el estado de las mismas.

La aplicación sigue los principios SOLID y está estructurada utilizando la arquitectura hexagonal, lo que facilita el mantenimiento y la escalabilidad del código.

## Tecnologías Utilizadas

- **Frontend**:

  - React
  - Material UI
  - Axios

- **Backend**:
  - .NET Core (v6 en adelante)
  - Entity Framework Core
  - JWT (JSON Web Token) para autenticación

## Funcionalidades

- **Autenticación de Usuarios**:

  - Registro e inicio de sesión.
  - Uso de JWT para la autenticación.

- **Gestión de Tareas**:

  - CRUD (Crear, Leer, Actualizar, Eliminar) de tareas.
  - Asignación de tareas a usuarios.
  - Actualización del estado de las tareas (Pendiente, En Proceso, Completada).

- **Gestión de Usuarios**:
  - CRUD de usuarios.
  - Asignación de roles a los usuarios.# TaskManagementSystem

## Descripción

TaskManagementSystem es una aplicación web diseñada para gestionar tareas de manera eficiente. La aplicación incluye autenticación de usuarios y un sistema de roles que permite diferentes niveles de acceso y funcionalidad:

- **Administrador**: Puede crear, editar y eliminar usuarios y tareas.
- **Supervisor**: Puede asignar tareas a empleados y cambiar el estado de las tareas.
  -- React

  - Material UI
  - Axios

- **Backend**:
  - .NET Core (v6 en adelante)
  - Entity Framework Core
  - JWT (JSON Web Token) para autenticación

## Funcionalidades

- **Autenticación de Usuarios**:

  - Registro e inicio de sesión.
  - Uso de JWT para la autenticación.

- **Gestión de Tareas**:

  - CRUD (Crear, Leer, Actualizar, Eliminar) de tareas.
  - Asignación de tareas a usuarios.
  - Actualización del estado de las tareas (Pendiente, En Proceso, Completada).

- **Gestión de Usuarios**:
  - CRUD de usuarios.
  - Asignación de roles a los usuarios.

## Estructura del Proyecto

Instrucciones de Instalación

Backend

Clona el repositorio:

git clone https://github.com/SOJEIN/TaskManagementSystem.git

cd backend/TaskManagementSystem.API

dotnet restore
Ejecuta la aplicación:
dotnet run

Frontend

cd frontend/manage-tasks

npm install
Inicia la aplicación:

npm start
