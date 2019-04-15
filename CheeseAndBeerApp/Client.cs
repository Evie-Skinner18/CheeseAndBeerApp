using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CheeseAndBeerApp
{
    public class Client
    {
       // private static HttpClient client = new HttpClient();
       public HttpClient HttpClient { get; set; }
       
        public string GetBeersEndpoint { get; set; }


        public string GetBeers()
        {
            HttpClient.BaseAddress = new Uri("https://api.punkapi.com/v2/");
            GetBeersEndpoint = HttpClient.BaseAddress + "/beers";
           // HttpClient.DefaultRequestHeaders.Add(GetBeers());
            var beersResponse = HttpClient.GetStringAsync(GetBeersEndpoint).ToString();

            return beersResponse;
        }

    }
}
