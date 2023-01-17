using awprojectmodels;

namespace awprojectrepositories
{
    public interface IStatesRepository
    {
        Task<IList<State>> GetAllAsync();
        Task<State> GetAsync(int id);
        Task<int> AddOrUpdateAsync(State state);
        Task<int> DeleteAsync(State state);
        Task<int> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}