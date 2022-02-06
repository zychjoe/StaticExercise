using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Boiling: Celsius = {TempConverter.FahrenheitToCelsius(212)}, Fahrenheit: {TempConverter.CelsiusToFahrenheit(100)}");
            Console.WriteLine($"Freezing: Celsius = {TempConverter.FahrenheitToCelsius(32)}, Fahrenheit: {TempConverter.CelsiusToFahrenheit(0)}");
            Console.WriteLine($"122F / 50C : Celsius = {TempConverter.FahrenheitToCelsius(122)}, Fahrenheit: {TempConverter.CelsiusToFahrenheit(50)}");
        }
    }
}
