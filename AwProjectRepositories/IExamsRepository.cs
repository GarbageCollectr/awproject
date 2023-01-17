using awprojectmodels;

namespace awprojectrepositories
{
    public interface IExamsRepository
    {
        Task<IList<Exam>> GetAllAsync();
        Task<Exam?> GetAsync(int id);
        Task<int> AddOrUpdateAsync(Exam exam);
        Task<int> DeleteAsync(Exam exam);
        Task<int> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
