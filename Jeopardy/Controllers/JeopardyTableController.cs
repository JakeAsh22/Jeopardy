using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Jeopardy.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace Jeopardy.Controllers
{
    public class JeopardyTableController : Controller
    {
        private readonly JeopardyContext _db;

        public JeopardyTableController(JeopardyContext db)
        {
            _db = db;
        }

        public ActionResult Setup()
        {
            var CategoryHolder = Category.GetCategories(6);

            foreach(Category cat in CategoryHolder)
            {
                var numCats = _db.Categories.ToList();
                if(numCats.Count >= 6)
                {
                    var firstCategory = _db.Categories.FirstOrDefault();
                    if(firstCategory != null)
                    _db.Categories.Remove(firstCategory);
                }
                _db.Categories.Add(cat);
                var QuestionHolder = Question.GetQuestions(cat.CategoryId, 5);
                var numQs = _db.Questions.ToList();
                foreach(Question q in QuestionHolder)
                {
                    if(numQs.Count >= 30)
                    {
                    var firstQuestion = _db.Questions.FirstOrDefault();
                    if(firstQuestion != null)
                    _db.Questions.Remove(firstQuestion);
                    }
                    _db.Questions.Add(q);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "JeopardyTable");
        }

        // public ActionResult Index()
        // {
        //     var CategoryHolder = Category.GetCategories(6);

        //     foreach(Category cat in CategoryHolder)
        //     {
        //         var numCats = _db.Categories.ToList();
        //         if(numCats.Count >= 6)
        //         {
        //             var firstCategory = _db.Categories.FirstOrDefault();
        //             if(firstCategory != null)
        //             _db.Categories.Remove(firstCategory);
        //         }
        //         _db.Categories.Add(cat);
        //         var QuestionHolder = Question.GetQuestions(cat.CategoryId, 5);
        //         foreach(Question q in QuestionHolder)
        //         {
        //             var firstQuestion = _db.Questions.FirstOrDefault();
        //             if(firstQuestion != null)
        //             _db.Questions.Remove(firstQuestion);
        //             _db.Questions.Add(q);
        //         }
        //         _db.SaveChanges();
        //     }
        //     ViewBag.Categories = _db.Categories.ToList();
        //     Dictionary<string, List<Category>> data = new Dictionary<string, List<Category>>();
        //     var list = _db.Questions.ToList();
        //     return View(list);
        // }
        [HttpGet]
        [Route("/JeopardyTable/box/{id}")]
        public ActionResult Box(string id)
        {
            var theQ = _db.Questions.FirstOrDefault(n => n.QuestionId == id);
            return View(theQ);
        }
        // [Route("/JeopardyTable/NewTable")]
        public ActionResult Index()
        {
            var list = _db.Questions.ToList();
            ViewBag.Categories = _db.Categories.ToList();
            return View(list);
        }
    }
}
