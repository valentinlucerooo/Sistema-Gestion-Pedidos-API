# Sistema-Gestion-Pedidos-API
 API Rest Desarrollada en C# .NET 8 bajo una **arquitectura en capas** (Intefaz,Logica de negocio BLL, Acceso a Datos DAL y Mappers)Conectada a una base de datos relacional en SQLServer.

 ## Tecnologia Utilizadas
 **Framework** .NET 8 (ASP.NET Core WEB API)
 **Base de datos** SQLServer /SQL Server Managment Studio( SSMS)
 **Acceso a datos** ADO.NET /Mappers Personalizados.
 **Control de Verciones** Git y GitHub

 ## Estructura del Proyecto 
 el proyecto esta organizado respetando la separacion de responsabilidades:
 **Entidades(Entities)** modelo de dominio ("Usuario","Producto","Envio","DetallePedido","Pedido").
 **Capa de Negocio(BLL)** Validaciones y reglas de negocio.
 **Capa de Datos(DAL)** Consultas SQL,procesamiento de Almacenamiento y operaciones CRUD. 
 **Mappers** transformacion de registros de base de datos ("SqlDataReader")a objetos Fuertemente Tipiados.
 **Controllers** Endopoints expuestos para la comunicacion con el front-end.
 
 ## Arquitectura y Diagramas 
 [ Diagramas del sistema](Analisis Proyecto.drawil.png).
