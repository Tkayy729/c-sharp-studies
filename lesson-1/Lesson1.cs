public class Lesson1
{
    public static void Run()
    {
        Console.WriteLine("Lesson 1 running");


        int fahrenheit = 94;
        decimal celcius = (fahrenheit - 32m) * (5m / 9m);

        Console.Write("The temperature is " + celcius + " Celsius");
    }
}
