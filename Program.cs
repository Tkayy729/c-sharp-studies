class Program
{
    static void Main()
    {
        Console.WriteLine("Choose program:");
        Console.WriteLine("1 - Lesson 1");
        Console.WriteLine("2 - Lesson 2");
        Console.WriteLine("3 - Lesson 3");
        Console.WriteLine("4 - Lesson 4");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Lesson1.Run();
                break;
            case "2":
                Lesson2.Run();
                break;
            case "3":
                Lesson3.Run();
                break;
            case "4":
                Lesson4.Run();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}