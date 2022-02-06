using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double fahr)
        {
            return (fahr - 32) * (5.0 / 9.0);

        }

        public static double CelsiusToFahrenheit(double cels)
        {
            return (cels * (9.0/5.0)) + 32;
        }
    }
}
