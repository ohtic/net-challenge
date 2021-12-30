# .NET Developer Challenge

En este repositorio podrás encontrar todo el material necesario para realizar la prueba técnica para la posición de .NET Developer!

# **1- Stark Analyzer**

Desde Stark Industries nos han pedido un analizador de secuencias para poder incluirlo en las últimos trajes de la compañía.

## **1.1 Requerimientos**

El jefe de tecnología nos ha pedido que para dar como bueno el analizador debe cumplir los siguientes requerimientos:

- El *input* del analizador será una `List<string>` de un longitud variable.
- El *input* puede variar y es inestable, se debe excluir el conocido *ruido molecular* representado con el carácter R (no debe contar para el % final, ver más adelante)
- El *output* debe ser un objeto del tipo `AnalyzerResult`, el cual deberá mostrar la cantidad de:
    - Partículas X
    - Partículas Y
    - Partículas Z
    - Ruído Excluido R
- En ese reporte debe mostrar también el porcentaje de apariciones de cada una y además , desde Stark Industries dicen que podemos modificar el objeto añadiendo lo necesario, *up to you* !!
- En Stark Industries se toman muy en serio la seguridad, con lo que nos piden al menos **tres** tests para asegurarnos que todo irá bien.
- Desde Stark nos dicen que si queremos extender funcionalidad, adelante, que no nos pongamos techo! 🚀.
- Debe primer el código limpio y mantenible para el futuro, debe ser sencillo de leer y seguir

## 1.2 Ejemplo

Para una secuencia como XXXYYRRYRYYXXZZZ deberíamos extraer:

- Partículas X : 5
- Partículas Y : 5
- Partículas Z : 3
- Ruído Excluido R : 3
- % de cada una de las anteriores.

## 1.3 Entegable

Para poder entregar el proyecto en condiciones óptimas nos piden un fork del proyecto en GitHub y pasarles la URL para que puedan revisarlo con su departamento de tecnología.

# 2- Stark Services API

Una vez entregado el analizador, desde Stark quieren ser capaces de exponer su tecnología a cualquier cliente que quiera beneficiarse de ella, para esto han pensado en exponer una API para ser consumida fácilmente.

## 2**.1 Requerimientos**

Nos han entregado una API base, con algunos avances, debemos finalizarlo y para ello nos indican lo siguiente:

- Se debe añadir autenticación a la API, el endpoint de Login está creado, pero no finalizado, debe ser consumible de forma **anónima.**
- Hay configurado un acceso a BBDD pero al parecer **no está funcionando** del todo, con lo que hemos de arreglarlo.
- No todo el código existente sigue buenos estándares a nivel de *Clean Code*, tenemos que refactorizar algunas partes.
- En `AvengersController` se deben exponer métodos para un CRUD de vengadores.
- De nuevo y siguiendo su filosofía desde Stark nos vuelven a indicar que añadamos todo lo que queramos extra a estos requerimientos base, **no hay techo** 🚀**!**
- Tanto el `AvengersController` como cualquier otro endpoint que queramos añadir deben ser solo accesibles **utilizando el Token generado** por el `AuthController`.
- Implementar manejo de excepciones.

## 2.2 Tips y consejos

- Como BBDD utilizar una InMemory de EF Core.
- Añade todas la tablas necesarias para el correcto funcionamiento.
- Importante revisar firma, audience, issuer y expiration en las validaciones del Token.

## 2.2 Entregable

Para poder entregar el proyecto en condiciones óptimas nos piden un fork del proyecto en GitHub y pasarles la URL para que puedan revisarlo con su departamento de tecnología.