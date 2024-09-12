namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Emmett Cornies
            int roomNumber = 29;
            double price = 2.99;
            string courseName = "Computer Science";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am learning a bit about " + courseName + "!");
            Console.WriteLine();
            string name = "Emmett Cornies";
            int gradYear = 2026;
            Console.WriteLine("My name is " + name + " and I'll be graduating in " + gradYear + ".");
            Console.WriteLine();
            int rad = 3;
            double area = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine("I just found this circle that has a radius of " + rad + "cm. Let's calculate the area! " + Math.Round(area,1) + "cm\xB2");
            Console.ReadLine();
        }
    }
}
