//using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double num1, num2, resultado = 0;
            string operador;

            Console.WriteLine("--- Calculadora en C# ---");

            // Entrada del primer número
            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Entrada del operador
            Console.Write("Introduce el operador (+, -, *, /): ");
            operador = Console.ReadLine();

            // Entrada del segundo número
            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Lógica de la operación
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    // Validación para no dividir entre cero
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                        return; // Finaliza el programa
                    }
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    return;
            }

            // Mostrar el resultado final
            Console.WriteLine($"\nEl resultado de {num1} {operador} {num2} es: {resultado}");
            
            // Esperar a que el usuario presione una tecla para cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}