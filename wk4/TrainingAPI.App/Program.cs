using System.Text.Json;

namespace TrainingAPI.App
{
    class Program
    {
        // Fields
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://localhost:7059/api/Associates";
        
        
        // Methods
        static async Task Main()
        {
            string response = await client.GetStringAsync(uri);


            List<AssociateDTO> associates = JsonSerializer.Deserialize<List<AssociateDTO>>(response);

            foreach (var item in associates)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}