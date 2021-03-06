using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jeopardy.Models;

namespace Jeopardy.Controllers
{
    public class AnswerController : Controller
    {

        private readonly JeopardyContext _db;

        public AnswerController(JeopardyContext db)
        {
            _db = db;
        }

        [HttpGet("/JeopardyTable/box/{id}/answer")]
        public ActionResult Index(string id)
        {
            Question thisQuestion = _db.Questions.FirstOrDefault(questions => questions.QuestionId == id);
            return View(thisQuestion);
        }

        [HttpPost]
        public ActionResult IndexPost()
        {
            return RedirectToAction("Index", "JeopordyTable");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
