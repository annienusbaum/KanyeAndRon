using System;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient(); //new object allowing me to make requests to the in

            var kanyeURL = "https://api.kanye.rest"; //the actual URL i'll be using for the AP

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            //client. is the instance of my http object that will use the getstringasync url 

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


            Console.WriteLine($"---------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            Console.WriteLine($"---------------");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"---------------");

        }


    }
}

