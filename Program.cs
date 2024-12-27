using System;

class Program
{
    // Definir las tasas de cambio como constantes
    const double TasaCambioUSD = 4000; // 1 USD = 4000 COP
    const double TasaCambioEUR = 4500; // 1 EUR = 4500 COP

    static void Main()
    {
        // Mostrar el mensaje de bienvenida
        Console.WriteLine("Bienvenido a la aplicación de conversión de moneda.");
        
        // Obtener el monto en COP del usuario
        double montoCOP = ObtenerMontoCOP();

        // Realizar las conversiones
        double montoUSD = ConvertirMoneda(montoCOP, TasaCambioUSD);
        double montoEUR = ConvertirMoneda(montoCOP, TasaCambioEUR);

        // Mostrar los resultados
        MostrarResultados(montoUSD, montoEUR);
    }

    // Método para obtener el monto en COP del usuario
    static double ObtenerMontoCOP()
    {
        double montoCOP = 0;

        while (true)
        {
            Console.Write("Ingrese el monto en pesos colombianos (COP): ");
            string input = Console.ReadLine();

            // Verificar que el input no sea nulo y validarlo
            if (!string.IsNullOrEmpty(input) && ValidarEntrada(input, out montoCOP))
            {
                break; // Salir del bucle si la entrada es válida
            }
            else
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido mayor que 0.");
            }
        }

        return montoCOP;
    }

    // Método para validar la entrada del usuario
    static bool ValidarEntrada(string input, out double monto)
    {
        return double.TryParse(input, out monto) && monto > 0;
    }

    // Método para realizar la conversión de COP a la moneda deseada
    static double ConvertirMoneda(double montoCOP, double tasaCambio)
    {
        return montoCOP / tasaCambio;
    }

    // Método para mostrar los resultados de la conversión
    static void MostrarResultados(double montoUSD, double montoEUR)
    {
        Console.WriteLine($"El valor en USD es: {montoUSD:F2}");
        Console.WriteLine($"El valor en EUR es: {montoEUR:F2}");
    }
}
