  # Mini Core Filtro por Fechas

Este repositorio contiene un proyecto que abarca principalmente un pequeño Core respecto al filtro de gastos de 
una empresa por departamento dentro de un rango de fechas. 

## Funcionalidades
Por ahora el proyecto solo cuenta con la siguiente funcionalidad:
- Filtrar por fechas los gastos totales de los departamentos pertenecientes a una empresa.

## Tecnologías Utilizadas
- **ASP.NET 8.0**
- **EntityFramework:** Gestión de bases de datos desde la consola del Administrador de Paquetes NuGet.
- **SQL Server**

## Requisitos Previos

- Tener instalado Visual Studio 2022
- Tener instalado Microsoft SQL Server Management Studio 20.

## Instrucciones de Uso

1. **Clona el Repositorio:** Clona este repositorio utilizando Git:

    ```bash
    git clone https://github.com/Matex2395/Mini-Core-FiltroFechas.git
    ```

2. **Abre el Proyecto en Visual Studio 2022:** Abre Visual Studio 2022 y ejecuta el archivo que contiene la solución del proyecto, con esto podrás acceder a los archivos del proyecto.

3. **Crea la Base de Datos**

   1. Modifica la cadena de conexión en ```appsettings.json``` para que esta responda a tu base de datos en SQL Server.
   2. Si no quieres utilizar tu propia base de datos, procura dejar la cadena de conexión desplegada:
     ```// [Connection String del Proyecto en Local]```
     ```[Connection String del Proyecto Deployado]```
   3. Añade las migraciones y actualiza la Base de Datos por medio de la consola del Administrador de Paquetes NuGet:
     ```add-migration "Initial Migration"```
     ```update-database```
   4. Ejecuta el script para insertar registros en tu base de datos local

4. **Ejecuta el proyecto**

   - Pon a correr al proyecto y prueba las funcionalidades de este, en caso de que trabajes en ```localhost```.
   - Caso contrario, accede a la URL del proyecto desplegado.

## Enlace al Proyecto Desplegado
Puedes acceder a este Core por medio del siguiente enlace:
- https://mini-core-filtrofechas20250108212555.azurewebsites.net

## Créditos
La realización del Core fue posible con la ayuda de las siguientes guías:
- Mapeo de datos desde SQL a C#: https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/sql-clr-type-mapping#NumericMapping
- Creación de Tablas en SQL: https://www.w3schools.com/sql/sql_create_table.asp

## Contribuciones

¡Siéntete libre de contribuir al proyecto abriendo issues o enviando pull requests!
