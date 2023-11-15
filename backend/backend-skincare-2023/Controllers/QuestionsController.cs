using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backend_skincare_2023.Data;
using backend_skincare_2023.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Azure;
using System.Collections.Immutable;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> af6d2b7e0085919f8745d0167cbcf497b719acd7


namespace backend_skincare_2023.Controllers
{
   
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }



        
        [Route("Questions/QuestionForm")]
        public IActionResult QuestionForm()
        {   
            Questionario questionario = new Questionario();

            return View(questionario);
        }


        //Ação para processar as respostas submetidas
        [HttpPost]
        public IActionResult EnviarRespostas(Questionario questionario)
        {

<<<<<<< HEAD

=======
            
>>>>>>> af6d2b7e0085919f8745d0167cbcf497b719acd7
            bool mensagemErroAdicionada = false;


            for (int i = 0; i < questionario.Perguntas.Count; i++)
            {
                var respostaSelecionada = Request.Form[$"respostas[{i}]"];

                if (string.IsNullOrEmpty(respostaSelecionada) && !mensagemErroAdicionada)
                {
                    ModelState.AddModelError($"respostas[{i}]", "Por favor, selecione uma resposta para esta pergunta.");
<<<<<<< HEAD
                    mensagemErroAdicionada = true;
=======
                    mensagemErroAdicionada = true; 
>>>>>>> af6d2b7e0085919f8745d0167cbcf497b719acd7

                }
            }

            if (!ModelState.IsValid)
            {
                // Se houver erros de validação, retorne para a página com os erros
                return View("QuestionForm", questionario);
            }



            // Verificar se a pergunta 3 o radio button sim foi checked

            var respostaPergunta3 = Request.Form[$"respostas[0]"];
            if (respostaPergunta3 == "Sim")
            {
                ViewBag.AlertMessage = "Você deve procurar um médico!";
                return View("QuestionForm", questionario);
            }


            return RedirectToAction("SkinRoutine", "Routines");

        }






        // GET: Questions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Questions.Include(q => q.Routine).Include(q => q.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Questions == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Routine)
                .Include(q => q.User)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (question == null)
            {
                return NotFound();
            }

            var questionClaim = new Claim("Question", $"{question.QuestionId}:{question.QuestionText}:{question.AnswerText}"); // Crie uma claim representando a pergunta.
            var claimsIdentity = new ClaimsIdentity(new List<Claim> { questionClaim }, "QuestionClaim"); // Crie um identificador com a claim.

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(claimsPrincipal); // Adicione a claim ao contexto de autenticação do usuário.

            return View(question);
        }




        // GET: Questions/Create
        public IActionResult Create()
        {

            ViewData["RoutineId"] = new SelectList(_context.Routines, "RoutineId", "RoutineText");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionId,QuestionText,AnswerText,UserId,RoutineId")] Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoutineId"] = new SelectList(_context.Routines, "RoutineId", "RoutineText", question.RoutineId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", question.UserId);
            return View(question);
        }

        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Questions == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            ViewData["RoutineId"] = new SelectList(_context.Routines, "RoutineId", "RoutineText", question.RoutineId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", question.UserId);
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionId,QuestionText,AnswerText,UserId,RoutineId")] Question question)
        {
            if (id != question.QuestionId)
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
                    if (!QuestionExists(question.QuestionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoutineId"] = new SelectList(_context.Routines, "RoutineId", "RoutineText", question.RoutineId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", question.UserId);
            return View(question);
        }

        // GET: Questions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Questions == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Routine)
                .Include(q => q.User)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Questions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Questions'  is null.");
            }
            var question = await _context.Questions.FindAsync(id);
            if (question != null)
            {
                _context.Questions.Remove(question);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.QuestionId == id);
        }
    }
}
