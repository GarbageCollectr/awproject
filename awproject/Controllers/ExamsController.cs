using Microsoft.EntityFrameworkCore;
using awprojectdata;
using awprojectmodels;
using awproject.Models;
using Microsoft.Extensions.Caching.Memory;
using awprojectservices;
using Microsoft.AspNetCore.Mvc;

namespace awproject.Controllers
{
    public class ExamsController : Controller
    {
        private readonly IExamsService _examsService;
        private readonly IQuestionsService _questionsService;
        
        public ExamsController(IExamsService examsService,IQuestionsService questionsService)
        {
            _examsService = examsService;
            _questionsService = questionsService;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _examsService.GetAllAsync();
            return View(contacts);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _examsService.GetAsync((int)id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _examsService.GetAsync((int)id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _examsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ExamExists(int id)
        {
            return await _examsService.ExistsAsync(id);
        }
    }
}
