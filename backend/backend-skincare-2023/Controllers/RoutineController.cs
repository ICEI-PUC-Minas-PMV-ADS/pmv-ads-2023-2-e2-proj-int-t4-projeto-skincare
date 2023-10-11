using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_skincare_2023.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoutineController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RoutineController(ApplicationDbContext context) //construtor que recebe banco de dados
        {
            _context = context;
        }

        public async Task<IActionResult> Index() //cada funcao eh uma pagina que recebe requisicao
        {
            var dados = await _context.Routines.ToListAsync(); //pega lista de usuarios 
            return View(dados); //passa para view listar todos users
        }


       
    }
}
