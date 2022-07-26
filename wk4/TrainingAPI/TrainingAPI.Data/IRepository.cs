using TrainingAPI.Model;

namespace TrainingAPI.Data
{
    public interface IRepository
    {
        Task<IEnumerable<Associate>> GetAllAssociatesAsync();

        Task<IEnumerable<Trainer>> GetAllTrainersAsync();
        Task DeleteAssociatesAsync();
        Task DeleteTrainerAsync();
    }
}
