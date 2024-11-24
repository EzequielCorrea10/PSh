# PSh Game

Este proyecto es una solución para el desafío técnico que incluye una aplicación WPF con reportes y una base de datos MySQL.

## Cómo usar este proyecto

### Requisitos previos
- MySQL Server instalado.
- Visual Studio (o cualquier IDE compatible con WPF y .NET).

### Restaurar la base de datos
1. Encuentra el archivo `PSh_Database.sql` en el directorio raíz del proyecto.
2. Usa el siguiente comando para restaurar la base de datos:

**Bash**
mysql -u [root] -p psh_game < Database/PSh_Database.sql