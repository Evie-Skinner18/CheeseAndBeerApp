using System;


namespace CheeseAndBeerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the cheese and beer zone! Enter 'beers' to see some beers.");

            var userInput = Console.ReadLine().ToLower();
            if (userInput == "beers")
            {
                var client = new Client();
                Console.WriteLine(client.GetBeers());
            }

            Console.ReadKey();

        }



    }
}
