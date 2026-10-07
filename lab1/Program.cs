namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");

            Console.WriteLine("Ahmed");
            Console.WriteLine("Computer Engineering");
            Console.WriteLine("Year 2");

            Console.WriteLine("Date & Time: " + DateTime.Now);

            Console.Write("Enter temperature in Celsius: ");
            string input = Console.ReadLine();
            double celsius = Convert.ToDouble(input);
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
    }
}