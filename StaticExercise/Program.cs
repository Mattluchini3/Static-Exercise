namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68); //20
            var farenheit = TempConverter.CelciusToFarenheit(20); //68

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"farenheit {farenheit}");
            
        }
    }
}




//Now create a static class called TempConverter.
//The class should have at least 2 methods, one called FahrenheitToCelsius
//that will require a double as a parameter and return a double, the other
//CelsiusToFahrenheit which will also require a double as a parameter and
//return a double.