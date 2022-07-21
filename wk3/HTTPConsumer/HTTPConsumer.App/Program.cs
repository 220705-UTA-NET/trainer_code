using System;
using System.Net.Http;
using System.Text.Json;
using HTTPConsumer.DTO;

namespace HTTPConsumer.App
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Application starting...");

            // send a request to http://jsonplaceholder.typicode.com/posts/1

            HttpClient client = new HttpClient();

            // wait and listen for the response
            // accept the response (in whatever format it comes back in)
            int count = 2;
            string? uri = "http://jsonplaceholder.typicode.com/posts";
            string response = await client.GetStringAsync(uri); 

            // the use of "asyc" and "await" requires that the containing method be asynchronous
            // any async method must return a Task (an object denoting if the method has completed or not)
            // in addition to any object that the method would oherwise return

            // Console.WriteLine(response);

            Console.WriteLine("Deserializing to Post object...");

            List<DTO.Post> newPost = JsonSerializer.Deserialize<List<DTO.Post>>(response);
            // convert (deserialize) from the response to an object i can use...

            int line = 1;
            foreach (var item in newPost)
            {
                Console.WriteLine(line + ": " + item.title);
                line++;
            }


        }
    }
}