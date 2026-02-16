# CRUD con ASP.NETCore y MySQL


<details> <summary>Descripción del proyecto</summary>

API REST desarrollada en ASP.NET Core 8 que permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) utilizando MySQL como motor de base de datos.

El proyecto sigue buenas prácticas como:

Separación por capas

Uso de DTOs

Entity Framework Core

Principios SOLID

Patrón Repository

</details>
<details> <summary>Dependencias</summary>
📦 Backend

.NET 8 SDK

ASP.NET Core Web API

Entity Framework Core

Pomelo.EntityFrameworkCore.MySql

MySql.Data

Swashbuckle (Swagger)

📦 Base de Datos

MySQL Server 8+

📦 Herramientas recomendadas

Visual Studio 2022 o VS Code

MySQL Workbench

</details>
<details> <summary>Instalación y ejecución</summary>
1️⃣ Clonar el repositorio
git clone https://github.com/tuusuario/tu-repositorio.git
2️⃣ Restaurar dependencias
dotnet restore
3️⃣ Configurar la cadena de conexión

Editar el archivo:

appsettings.json

Configurar:

"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=CrudDB;user=root;password=tu_password;"
}
4️⃣ Ejecutar migraciones
dotnet ef database update
5️⃣ Ejecutar el proyecto
dotnet run

La API se ejecutará en:

https://localhost:5001
6️⃣ Documentación Swagger

Disponible en:

https://localhost:5001/swagger
</details>
<details> <summary>Estructura del proyecto</summary>

El proyecto está organizado de la siguiente manera:

/Controllers
    PersonaController.cs

/Data
    ApplicationDbContext.cs

/Models
    Persona.cs

/DTOs
    PersonaDTO.cs

/Services
    IPersonaService.cs
    PersonaService.cs

/Repositories
    IPersonaRepository.cs
    PersonaRepository.cs

/Utils
    Encriptacion.cs

Program.cs
appsettings.json

Cada carpeta cumple una responsabilidad específica para mantener el código limpio y mantenible.

</details>
<details> <summary>Arquitectura</summary>

Se implementa una arquitectura por capas:

Controller → Maneja solicitudes HTTP

Service → Contiene la lógica de negocio

Repository → Acceso a datos

DbContext → Configuración de base de datos

DTOs → Transferencia de datos

Esto permite escalabilidad, mantenimiento sencillo y pruebas unitarias más fáciles.

</details>
<details> <summary>Endpoints principales</summary>
📌 Personas

GET /api/personas → Obtener todas las personas

GET /api/personas/{id} → Obtener persona por ID

POST /api/personas → Crear nueva persona

PUT /api/personas/{id} → Actualizar persona

DELETE /api/personas/{id} → Eliminar persona

</details>
<details> <summary>Base de Datos</summary>

Tabla principal:

📌 Persona

Id (int, PK)

Nombre (string)

Apellido (string)

Edad (int)

La base de datos es gestionada mediante Entity Framework Core con migraciones.

</details>
<details> <summary>Seguridad de los datos</summary>

En este ejemplo de práctica, solo el primer nombre de la persona es encriptado.

El algoritmo de encriptación usado es AES y la clase que se encarga de encriptar y desencriptar los datos es Encriptacion.cs. Así, en la base de datos aparecerá una cadena de símbolos, letras y números sin ningún sentido.

Pero en el programa, esta cadena será leída y desencriptada usando la llave de encriptación asignada. Es importante que esta llave no sea modificada pues, sin ella, los datos no podrán desencriptarse.

</details>
<details> <summary>Buenas prácticas aplicadas</summary>

Uso de inyección de dependencias

Separación de responsabilidades

Uso de DTOs para evitar exponer entidades

Manejo adecuado de códigos HTTP

Documentación con Swagger

Encriptación de datos sensibles

</details>
<details> <summary>Autor</summary>

Proyecto desarrollado por Alexis Luján
Ingeniero de Sistemas

</details>
