using System;
using System.Net;
using Newtonsoft.Json;

namespace request
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_URL = "https://jsonplaceholder.typicode.com/posts";
            var client = new WebClient();
            var data = client.DownloadString(API_URL);

            dynamic posts = JsonConvert.DeserializeObject(data);

            foreach(var post in posts){
                Console.WriteLine(post.id + ": " + post.title);
            }

        }
    }
}
