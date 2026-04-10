# Sistema Inteligente de Gestión de Citas Médicas Basado en Prioridades

¡Bienvenidos al repositorio principal del sistema inteligente de citas médicas!

## 📋 Descripción del Proyecto
Este proyecto es un sistema web impulsado internamente por un algoritmo y desarrollado bajo un modelo de Clean Architecture (Monolito Modular) que permite la gestión eficiente de citas médicas priorizando a los pacientes con mayor urgencia basada en criterios clínicos, demográficos y operacionales. 

## 💻 Arquitectura e Implementación
La arquitectura elegida para este Sprint es un **Monolito Modular** estructurado en las siguientes capas (proyectos):
- **SistemaCitas.Dominio:** Entidades del modelo (Cita, Paciente, PuntuacionPrioridad, CondicionMedica, Usuario).
- **SistemaCitas.Aplicacion:** Contiene la lógica del algoritmo de prioridades y casos de uso.
- **SistemaCitas.Infraestructura:** Todo el ecosistema técnico local (Base de Datos usando SQLite y Entity Framework Core).
- **SistemaCitas.Presentacion:** La interfaz web y la API construida usando Blazor (Server-Side) y ASP.NET Core Minimal APIs.

## 🛠️ Tecnologías Usadas
- **Backend/Framework:** .NET 8 (C#)
- **Frontend Web:** Blazor Server
- **Base de Datos:** SQLite
- **ORM:** Entity Framework Core
- **Testing:** xUnit

## 🚀 Cómo Empezar a Programar (Para Desarrolladores)

1. **Clonar este repositorio** en tu máquina local.
2. Abre la solución principal (`SistemaCitas.sln`) usando tu IDE de preferencia (Visual Studio, VS Code, Rider, etc.).
3. Dentro de la terminal, asegúrate de **Restaurar todos los paquetes NuGet**:
   ```bash
   dotnet build
   ```

### 💾 Base de Datos (Importante)
A nivel de persistencia de datos, usamos **SQLite**.
**NO SE COMPARTE EL ARCHIVO FÍSICO DE BASE DE DATOS. (`*.db`)** 

Cada miembro del equipo desarrollador debe generar su propio archivo base de datos en su ordenador. Para crearla, asegúrate de tener las herramientas de EF instaladas en la terminal:
```bash
dotnet tool install --global dotnet-ef
```

Luego, en el directorio raíz del proyecto o apuntando al startup project, corre la última migración (la cual creará tu base de datos y le estructurará las tablas relacionales locales):
```bash
dotnet ef database update --project src/SistemaCitas.Infraestructura --startup-project src/SistemaCitas.Presentacion
```
Esto autogenerará un archivo llamado `sistemacitas.db` el cual está ignorado explícitamente en el `.gitignore`.

### 🧪 Pruebas Automatizadas
Para confirmar que el core del sistema no se rompió luego de tu desarrollo, no te olvides de correr la suite de xUnit en la carpeta global:
```bash
dotnet test
```
---

## 🤝 Flujo de Trabajo en GitHub (Colaboración)

Para evitar problemas de colisiones en la integración de código, por favor seguid estas reglas básicas de control de versiones:
1. **Nunca trabajes directamente en la rama `main`**.
2. Cuando se inicie el desarrollo para tu historia de usuario (por ej: US-2.1), crea tu **feature branch**:
   ```bash
   git switch -c feature/us-2.1-interfaz-registro
   ```
3. Trabaja sobre esa rama y sube tus `commits`.
4. Una vez listos y probados los cambios de tu código local, empuja (push) tu rama remota a GitHub.
5. Crea un **Pull Request (PR)** hacia la rama principal solicitando la revisión conjunta del equipo.
