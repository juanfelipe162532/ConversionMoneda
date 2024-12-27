# Conversión de Moneda - Aplicación de Consola .NET

## Descripción

Esta es una aplicación de consola en C# que permite realizar la conversión de un monto en pesos colombianos (COP) a dólares estadounidenses (USD) y euros (EUR) utilizando tasas de cambio fijas. La aplicación solicita al usuario ingresar un valor en COP y luego muestra el valor convertido a USD y EUR.

## Requisitos

- .NET SDK 6.0 o superior.
- Un editor de texto como Visual Studio, Visual Studio Code o cualquier IDE compatible con C#.

## Funcionalidades

1. Solicita al usuario ingresar un monto en pesos colombianos (COP).
2. Convierte el monto ingresado a dólares estadounidenses (USD) y euros (EUR) utilizando tasas de cambio fijas:
   - 1 USD = 4000 COP
   - 1 EUR = 4500 COP
3. Muestra los resultados de las conversiones en la consola.
4. Verifica que el usuario ingrese un número válido. Si el valor ingresado no es válido, solicita al usuario que ingrese un nuevo valor.

## Instrucciones de Uso

### 1. Clonar el repositorio

Para clonar el repositorio en su máquina local, ejecutar el siguiente comando en su terminal o línea de comandos:

```bash
git clone https://github.com/juanfelipe162532/ConversionMoneda

### 2. Abrir el proyecto
Abrir el proyecto en su editor de texto o IDE preferido (por ejemplo, Visual Studio o Visual Studio Code).

### 3. Restaurar las dependencias
Antes de ejecutar el proyecto, asegúrate de que todas las dependencias estén restauradas. Abre la terminal en la raíz del proyecto y ejecuta el siguiente comando:

- dotnet restore

### 4. Ejecutar la aplicación
Para ejecutar la aplicación, usar el siguiente comando en la terminal dentro de la raíz del proyecto:

- dotnet run

## 5. Ingresar el monto en COP
La aplicación te pedirá que ingreses un monto en pesos colombianos (COP). Después de ingresar el monto, la aplicación realizará la conversión a USD y EUR y mostrará los resultados en la consola.
