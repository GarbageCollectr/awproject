using awprojectdata;
using awprojectmodels;
using Microsoft.EntityFrameworkCore;

namespace awprojectrepositories
{
    public class ExamsRepository : IExamsRepository
    {
        private AwProjectDbContext _context;

        public ExamsRepository(AwProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Exam>> GetAllAsync()
        {
            var results = await _context.Exams
                .AsNoTracking()
                .OrderBy(x => x.DateTime)
                .ToListAsync();
            return results;
        }

        public async Task<Exam?> GetAsync(int id)
        {
            var result = await _context.Exams
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public async Task<int> AddOrUpdateAsync(Exam exam)
        {
            //if (exam.Id > 0)
            //{
            //    return await Update(exam);
            //}
            //return await Insert(exam);
            return 1;
        }

        public async Task<int> DeleteAsync(Exam exam)
        {
            return await DeleteAsync(exam.Id);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var existingExam = await _context.Exams.SingleOrDefaultAsync(x => x.Id == id);
            if (existingExam is null) throw new Exception("Could not delete Exam due to unable to find");

            await Task.Run(() => { _context.Exams.Remove(existingExam); });
            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Exams
                                    .AsNoTracking()
                                    .AnyAsync(x => x.Id == id);
        }
    }
}
