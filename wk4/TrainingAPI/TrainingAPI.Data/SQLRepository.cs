using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using TrainingAPI.Model;

namespace TrainingAPI.Data
{
    public class SQLRepository : IRepository
    {
        // Fields
        private readonly string _connectionString;
        private readonly ILogger<SQLRepository> _logger;

        // Constructor
        public SQLRepository(string connectionString, ILogger<SQLRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        // Methods
        public async Task<IEnumerable<Associate>> GetAllAssociatesAsync()
        {
            List<Associate> result = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string cmdText = "SELECT Id, Name, Batch FROM Training.Associates;";

            using SqlCommand cmd = new(cmdText, connection);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string? batch = reader.IsDBNull(2) ? "" : reader.GetString(2);

                Associate tmpAssociate = new Associate(id, name, batch);
                result.Add(tmpAssociate);
            }

            await connection.CloseAsync();

            _logger.LogInformation("Executed GetAllAssociatesAsync, returned {0} results", result.Count);

            return result;
        }

    }
}
