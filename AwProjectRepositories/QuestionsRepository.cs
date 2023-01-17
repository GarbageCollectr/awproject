using awprojectdata;
using awprojectmodels;

namespace awprojectrepositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private AwProjectDbContext _context;

        public Task<int> AddOrUpdateAsync(Question question)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Question question)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Question>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Question?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
