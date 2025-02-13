# OnionBackendTemplate

**OnionBackendTemplate** es una plantilla de arquitectura de software Onion para ASP.NET.

## Tecnologías Utilizadas

- **ASP.NET Core para APIs web**: Framework de código abierto y multiplataforma para la creación de aplicaciones web modernas y APIs de alto rendimiento.
- **Microsoft Entity Framework Core**: ORM (Object-Relational Mapper) que simplifica el acceso a bases de datos relacionales.
- **Microsoft Entity Framework Core Design**: Extensión que facilita la creación y el mantenimiento de la estructura de la base de datos mediante la línea de comandos, permitiendo automatizar tareas como la generación de migraciones y la actualización de esquemas de base de datos.
- **Microsoft Entity Framework Core SqlServer**: Extensión específica de EF Core para la integración y optimización del acceso a bases de datos SQL Server, proporcionando características avanzadas.
- **Microsoft Entity Framework Core Tools**: Herramientas de línea de comandos que permiten realizar tareas comunes relacionadas con las bases de datos, como migraciones y actualizaciones de esquemas.
- **SQL Server**: Elegido por su robustez, fiabilidad y características esenciales para el backend de una aplicación empresarial de alto rendimiento como AndonNg.

## Descripción de las Capas de la Arquitectura Onion

### Sección API

Esta capa maneja las solicitudes provenientes de los clientes. Una API RESTful permite que el sistema sea accesible desde diferentes plataformas, ya sea desde aplicaciones móviles, aplicaciones de escritorio o sistemas de terceros. Es responsable de recibir las peticiones, procesarlas y devolver respuestas al cliente.

### Sección Application

La capa Application funciona como intermediaria entre las solicitudes de los clientes y las operaciones en la base de datos. Aquí se encuentran los servicios de negocio, lógica de validación y procesamiento de datos, asegurando que las peticiones sean gestionadas antes de interactuar con la base de datos. Esta capa también orquesta procesos complejos que involucren múltiples entidades o sistemas externos.

### Sección Core

La capa Core define las entidades que representan los objetos de dominio del sistema y sus interacciones. Implementa las reglas de negocio esenciales del software, sin depender de detalles técnicos de la infraestructura o las bases de datos, garantizando que el sistema sea fácil de testear y modificar a largo plazo.

### Sección Infrastructure

La capa Infrastructure se encarga de la comunicación con la base de datos y otros servicios externos. Gestiona las implementaciones específicas de acceso a datos, como el uso de EF Core para las operaciones CRUD en la base de datos. También maneja las actualizaciones del esquema de la base de datos y la implementación de conexiones a otros servicios como APIs externas, sistemas de mensajería o almacenamiento en la nube.
