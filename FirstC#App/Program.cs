using System;
using System.Net;
using Newtonsoft.Json;


namespace first_c_sharp_app
{
    class Program { 
        static void Main(string[] args)
        {
            string json;

            using (var web = new System.Net.WebClient())
            {
                var url = @"https://api.coindesk.com/v1/bpi/currentprice.json";
                json = web.DownloadString(url);
                Console.WriteLine(json);
                Console.WriteLine();
            }

            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            Console.WriteLine(obj);
            Console.WriteLine();
            var currentPrice = Convert.ToDecimal(obj.bpi.USD.rate.Value);

            Console.WriteLine(currentPrice);



        }
    }
}


