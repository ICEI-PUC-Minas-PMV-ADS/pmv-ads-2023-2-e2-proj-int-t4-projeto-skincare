using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using ChatGPT.Net;
using ChatGPT.Net.DTO.ChatGPT;



namespace backend_skincare_2023.Controllers
{
   
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RoutinesController> _logger;
        private readonly string _apiKey;


        public QuestionsController(ApplicationDbContext context, ILogger<RoutinesController> logger, IConfiguration configuration)
        {
            _context = context;
            _logger = logger;
            _apiKey = configuration.GetSection("ApiSettings:ApiKey").Value;
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


            bool mensagemErroAdicionada = false;
           


            for (int i = 0; i < questionario.Perguntas.Count; i++)
            {
                var respostaSelecionada = Request.Form[$"respostas[{i}]"];

                if (string.IsNullOrEmpty(respostaSelecionada) && !mensagemErroAdicionada)
                {
                    ModelState.AddModelError($"respostas[{i}]", "Por favor, selecione uma resposta para esta pergunta.");

                    mensagemErroAdicionada = true;


                }
                
            }

            if (!ModelState.IsValid)
            {
               
                return View("QuestionForm", questionario);
            }


            // Acessar valor pergunta 3
            int indiceDaPergunta3 = 2;
            string valorDaResposta3 = "Sim"; 

            var respostaPergunta3 = Request.Form[$"respostas[{indiceDaPergunta3}]"];

            if (!string.IsNullOrEmpty(respostaPergunta3) && respostaPergunta3 == valorDaResposta3)
            {
                ViewBag.AlertMessage = "Recomendamos que procure a ajuda de algum especialista!";
                return View("QuestionForm", questionario);
            }


            // valores respostas selecionadas no form
            List<string> respostasPerguntas1e4 = new List<string>();
            for (int i = 0; i < questionario.Perguntas.Count; i++)
            {
                if (i == 0 || i == 3)
                {
                    string resposta = questionario.Respostas[i];
                    System.Diagnostics.Trace.WriteLine($"Resposta da pergunta {i + 1}: {resposta}");
                    respostasPerguntas1e4.Add(resposta);
                }
            }

           
            //envia os valores clicados na url
            return RedirectToAction("Rotina", "Questions", new { respostas = string.Join(",", respostasPerguntas1e4) });

        }



        //api rotina 
        [Route("Questions/Rotina")]
        public async Task<IActionResult> Rotina(string respostas)
        {
            var viewModel = new RoutineText();

            try
            {

                var bot = new ChatGpt(_apiKey, new ChatGptOptions
                {
                    Model = "gpt-3.5-turbo",
                    MaxTokens = 1400
                }); ;

                viewModel.Text = await bot.Ask($"Descreva uma rotina de skincare completa com base nessas respostas: {respostas}");


                return View(viewModel);


            }
            catch (Exception e)
            {
                
                viewModel.ErrorMessage = "Ocorreu um erro ao obter a rotina. Por favor, tente novamente mais tarde.";
            }

            return View(viewModel);


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
