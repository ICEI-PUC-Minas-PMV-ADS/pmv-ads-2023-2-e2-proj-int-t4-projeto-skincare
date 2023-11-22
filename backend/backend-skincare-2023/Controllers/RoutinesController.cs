using ChatGPT.Net;
using ChatGPT.Net.DTO.ChatGPT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace backend_skincare_2023.Controllers
{
    public class RoutinesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RoutinesController> _logger;
        private readonly string _apiKey;

       
        public RoutinesController(ApplicationDbContext context, ILogger<RoutinesController> logger, IConfiguration configuration)
        {
            _context = context;
            _logger = logger;
            _apiKey = configuration.GetSection("ApiSettings:ApiKey").Value;
        }


        [Route("Routines/SkinRoutine")]
        public async Task<IActionResult> SkinRoutine()
        {
            var viewModel = new RoutineText();

            try
            {
                var bot = new ChatGpt(_apiKey, new ChatGptOptions { 
                  Model = "gpt-3.5-turbo"
                });
                viewModel.Text = await bot.Ask("Descreva uma rotina simples para pele oleosa com acne.");
                return View(viewModel);

            }
            catch (Exception e)
            {
                LogError(e, "Error");
                viewModel.ErrorMessage = "Ocorreu um erro ao obter a rotina. Por favor, tente novamente mais tarde.";
            }

            return View(viewModel);
        }

        private void LogError(Exception e, string message)
        {
            
             _logger.LogError(e, message);
        }



        // GET: Routines
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Routines.Include(r => r.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Routines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Routines == null)
            {
                return NotFound();
            }

            var routine = await _context.Routines
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RoutineId == id);
            if (routine == null)
            {
                return NotFound();
            }

            return View(routine);
        }

        // GET: Routines/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }


        // POST: Routines/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoutineId,RoutineText,CreatedAt,UserId")] Routine routine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(routine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", routine.UserId);
            return View(routine);
        }



        // GET: Routines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Routines == null)
            {
                return NotFound();
            }

            var routine = await _context.Routines.FindAsync(id);
            if (routine == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", routine.UserId);
            return View(routine);
        }


        // POST: Routines/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoutineId,RoutineText,CreatedAt,UserId")] Routine routine)
        {
            if (id != routine.RoutineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(routine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoutineExists(routine.RoutineId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", routine.UserId);
            return View(routine);
        }


        // GET: Routines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Routines == null)
            {
                return NotFound();
            }

            var routine = await _context.Routines
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RoutineId == id);
            if (routine == null)
            {
                return NotFound();
            }

            return View(routine);
        }


        // POST: Routines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Routines == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Routines'  is null.");
            }
            var routine = await _context.Routines.FindAsync(id);
            if (routine != null)
            {
                _context.Routines.Remove(routine);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoutineExists(int id)
        {
          return _context.Routines.Any(e => e.RoutineId == id);
        }
    }
}
