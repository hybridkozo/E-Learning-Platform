using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using e_coding.gr.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace e_coding.gr.Controllers
{
    // [Authorize]
    public class AdministratorController : Controller
    {

        private ApplicationDbContext _context;

        public AdministratorController(ApplicationDbContext context)
        {
            _context = context;
        }


        //[Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            return View(_context.Questions.ToList()); ;
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



        public async Task<IActionResult> Edit(int? questionID)
        {
            if (questionID == null)
            {
                return NotFound();
            }

            var question =await _context.Questions.SingleOrDefaultAsync(m => m.QuestionID == questionID);

            if (question == null)
            {
                return NotFound();
            }

            return View(question);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int questionID, [Bind("QuestionID","QuestionStr","Level","SourceUrl","Section")] Question question)
         {
            if (questionID != question.QuestionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                  
                    
                        throw;
                    
                }
                return RedirectToAction("Index");
            }
            return View(question);
        }



       
        public async Task<IActionResult> Delete(int? questionID)
        {
            if (questionID == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.SingleOrDefaultAsync(model => model.QuestionID == questionID);

            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int questionID, [Bind("QuestionID", "QuestionStr", "Level", "SourceUrl", "Section")] Question question)
        {
            if (questionID != question.QuestionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var deleteItem = await _context.Questions.SingleOrDefaultAsync(m => m.QuestionID == questionID);
                    if (deleteItem != null)
                    {
                        _context.Questions.Remove(deleteItem);
                        await _context.SaveChangesAsync();
                    }
                    
                }
                catch (DbUpdateConcurrencyException)
                {


                    throw;

                }
                return RedirectToAction("Index");
            }
            return View(question);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ViewAnswers(int questionID, [Bind("AnswerID", "AnswerStr", "CorrectAnswer", "QuestionID")] Answer answer)
        {
            if (questionID != answer.QuestionID)
            {
                return NotFound();
            }

            var answers = await _context.Answers.SingleOrDefaultAsync(m => m.QuestionID == questionID);

            return View(answers);
        }

    }
}