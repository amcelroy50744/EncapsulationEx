using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert degrees in Fahrenheit ");
            var celcius = TempCoverter.FahrenheitTOCelsius(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine("Please insert degrees in Celcius");
            var fahrenheit = TempCoverter.CelsiusToFahrenheit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
