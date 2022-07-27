using System.Text.Json;

namespace TrainingAPI.App
{
    class Program
    {
        // Fields
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://demowebapp-hawkins-220705.azurewebsites.net/api/Associates";
        
        
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