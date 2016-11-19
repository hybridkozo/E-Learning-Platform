using e_coding.gr.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_coding.gr.Controllers
{
    public class QuestionsController : Controller
    {

        private ApplicationDbContext _context;

        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Questions.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(question);

        }

    }
}
