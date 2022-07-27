using TrainingAPI.Model;

namespace TrainingAPI.Data
{
    public interface IRepository
    {
        Task<IEnumerable<Associate>> GetAllAssociatesAsync();
    }
}
