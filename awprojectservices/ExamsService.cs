using awprojectmodels;
using awprojectrepositories;

namespace awprojectservices
{
    public class ExamsService : IExamsService
    {
        private IExamsRepository _examsRepository;
        public ExamsService(IExamsRepository examsRepository)
        {
            _examsRepository = examsRepository;
        }

        public async Task<IList<Exam>> GetAllAsync()
        {
            return await _examsRepository.GetAllAsync();
        }

        public async Task<Exam?> GetAsync(int id)
        {
            return await _examsRepository.GetAsync(id);
        }
        public async Task<int> AddOrUpdateAsync(Exam exam)
        {
            return await _examsRepository.AddOrUpdateAsync(exam);
        }

        public async Task<int> DeleteAsync(Exam exam)
        {
            return await _examsRepository.DeleteAsync(exam);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _examsRepository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _examsRepository.ExistsAsync(id);
        }


    }
}
