using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace CheeseAndBeerApp
{
    class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cheese and beer zone! Please enter your favourite cheese to begin.");
            ProcessBeers().Wait();
        }

        private static async Task ProcessBeers()
        {

        }
    }
}
