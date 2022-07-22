using System.Text.Json;
namespace NewsAPI.App
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("News API Consumer Starting...");

            string apikey = "7d4477ba34634881b7ec79a13c825a7f";
            string source = "bbc-news";
            HttpClient client = new HttpClient();
            string uri = "https://newsapi.org/v2/top-headlines?sources=bbc-news&apiKey=7d4477ba34634881b7ec79a13c825a7f";

            string response = await client.GetStringAsync(uri);

                
            DTO.Headline headline = JsonSerializer.Deserialize<DTO.Headline>(response);

            int count = 1;
            foreach (var item in headline.articles)
            {
                Console.WriteLine(count + ": " + item.title);
            }
        }
    }
}