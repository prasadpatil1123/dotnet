namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            Player ravan = new Player();
            Console.WriteLine(ravan.GetName());
            Console.WriteLine(ravan.GetHealth());

            Console.WriteLine();

            ravan.SetName("Jai Shree Ram");
            ravan.SetHealth(7000);

            Console.WriteLine();

            Console.WriteLine(ravan.GetName());
            Console.WriteLine(ravan.GetHealth());

            Console.ReadLine();
        }
    }
}