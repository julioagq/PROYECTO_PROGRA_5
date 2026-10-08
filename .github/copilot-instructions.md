# Instrucciones para GitHub Copilot

## Proyecto

Este proyecto es una aplicación ASP.NET Core desarrollada con:

- .NET 10 LTS
- C#
- ASP.NET Core
- Entity Framework Core
- Visual Studio Community 2026
- Git

El proyecto debe mantenerse compatible con .NET 10 LTS.

## Idioma

Responde al desarrollador en español.

El código debe utilizar las convenciones estándar de C#:
- Clases, métodos y propiedades en inglés.
- PascalCase para clases, métodos y propiedades.
- camelCase para variables y parámetros.

## Regla principal

Antes de modificar código:

1. Analiza la estructura existente.
2. Identifica los archivos relacionados con la tarea.
3. Comprende la arquitectura existente.
4. No modifiques archivos innecesarios.
5. Explica brevemente qué vas a cambiar.

No reconstruyas partes del proyecto que ya funcionan.

## ASP.NET Core

Utiliza las prácticas recomendadas actuales de ASP.NET Core.

Preferencias:

- Inyección de dependencias.
- async/await para operaciones de entrada/salida.
- Separación de responsabilidades.
- Validación de datos.
- Manejo apropiado de errores.
- Configuración mediante appsettings.json y Options cuando corresponda.
- Códigos HTTP apropiados para APIs.

No coloques lógica de negocio compleja directamente en Controllers.

## Entity Framework Core

Cuando trabajes con Entity Framework Core:

- Utiliza consultas asíncronas.
- Evita consultas innecesarias.
- Evita problemas N+1.
- Utiliza AsNoTracking cuando corresponda.
- Respeta las relaciones existentes entre entidades.
- Respeta las migraciones existentes.
- No elimines migraciones existentes sin una razón clara.
- No introduzcas SQL inseguro o concatenación de strings para consultas.

Antes de modificar una entidad:

1. Revisa el modelo.
2. Revisa el DbContext.
3. Revisa las configuraciones.
4. Revisa las migraciones existentes.

## C#

Utiliza código moderno, claro y mantenible.

Preferencias:

- Nullable Reference Types.
- async/await.
- Pattern matching cuando mejore la claridad.
- Records cuando sean apropiados.
- Inmutabilidad cuando sea conveniente.
- Métodos pequeños y con responsabilidades claras.

Evita:

- Código duplicado.
- Métodos excesivamente largos.
- Variables innecesarias.
- Captura de excepciones sin tratamiento.
- Uso innecesario del operador !.
- Código complejo cuando exista una solución sencilla.

## Seguridad

Siempre revisa:

- Validación de entradas.
- Autenticación.
- Autorización.
- XSS.
- CSRF.
- Inyección SQL.
- Protección de información sensible.
- Manejo seguro de excepciones.
- Logging seguro.

Nunca introduzcas:

- Contraseñas en el código.
- API keys en el código.
- Tokens en el código.
- Connection strings con credenciales reales dentro del código fuente.

## Base de datos

Antes de realizar cambios relacionados con la base de datos:

1. Examina el modelo actual.
2. Examina el DbContext.
3. Examina las relaciones.
4. Examina las migraciones.
5. Mantén compatibilidad con el diseño existente.

No cambies el esquema de la base de datos sin explicar primero el impacto.

## Pruebas

Cuando implementes una funcionalidad importante:

- Propón pruebas.
- Considera casos normales.
- Considera casos límite.
- Considera errores.
- No elimines pruebas existentes para hacer que el código pase.

## Debugging

Cuando aparezca un error:

1. Identifica la causa raíz.
2. No te limites a ocultar el error.
3. Explica por qué ocurre.
4. Propón la solución más pequeña y segura.
5. Implementa la solución.
6. Compila nuevamente.
7. Comprueba que no haya errores nuevos.

## Cambios realizados por el agente

Después de modificar código:

1. Revisa los archivos modificados.
2. Compila la solución.
3. Corrige errores de compilación.
4. Ejecuta las pruebas relevantes.
5. Revisa posibles problemas de seguridad.
6. Revisa posibles problemas de rendimiento.
7. Resume los cambios realizados.

## Dependencias

No agregues paquetes NuGet nuevos sin una razón clara.

Antes de agregar una dependencia:

- Comprueba si .NET 10 o ASP.NET Core ya proporciona la funcionalidad.
- Comprueba las dependencias existentes.
- Explica por qué la nueva dependencia es necesaria.

## Arquitectura

Respeta la arquitectura existente del proyecto.

No introduzcas automáticamente:

- Clean Architecture.
- CQRS.
- MediatR.
- Repository Pattern.
- Microservicios.

Solo utiliza estos patrones si realmente son necesarios y están justificados por el proyecto.

## Calidad del código

Prioriza:

1. Correctitud.
2. Seguridad.
3. Mantenibilidad.
4. Rendimiento.
5. Simplicidad.

No escribas código solamente para satisfacer la solicitud si ese código introduce un problema de seguridad o arquitectura.

## Regla para tareas grandes

Para tareas que involucren varios archivos:

1. Analiza primero.
2. Propón un plan.
3. Espera confirmación si el cambio es potencialmente destructivo.
4. Implementa.
5. Compila.
6. Prueba.
7. Revisa.
8. Resume.

## Regla importante

No inventes APIs, clases, métodos, propiedades, paquetes o configuraciones.

Si no puedes confirmar que algo existe en el proyecto, dilo claramente y revisa el código antes de utilizarlo.
