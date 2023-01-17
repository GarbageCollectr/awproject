using awprojectmodels;

namespace awprojectservices
{
    public interface IQuestionsService
    {
        Task<IList<Question>> GetAllAsync();
        Task<Question?> GetAsync(int id);
        Task<int> AddOrUpdateAsync(Question question);
        Task<int> DeleteAsync(Question question);
        Task<int> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
