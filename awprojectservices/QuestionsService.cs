using awprojectmodels;
using awprojectrepositories;

namespace awprojectservices
{
    public class QuestionsService : IQuestionsService
    {
        private IQuestionsRepository _questionsRepository;
        public QuestionsService(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public async Task<IList<Question>> GetAllAsync()
        {
            return await _questionsRepository.GetAllAsync();
        }

        public async Task<Question?> GetAsync(int id)
        {
            return await _questionsRepository.GetAsync(id);
        }
        public async Task<int> AddOrUpdateAsync(Question question)
        {
            return await _questionsRepository.AddOrUpdateAsync(question);
        }

        public async Task<int> DeleteAsync(Question question)
        {
            return await _questionsRepository.DeleteAsync(question);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _questionsRepository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _questionsRepository.ExistsAsync(id);
        }
    }
}
