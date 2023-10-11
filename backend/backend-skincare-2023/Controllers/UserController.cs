
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using backend_skincare_2023.Models;  // Assuming you have a User model

namespace backend_skincare_2023.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/User
        [HttpGet]
        public async Task<IActionResult> Index() //Mostra lista de todos os usuarios no banco de dados
        {
            var dados = await _context.Users.ToListAsync();
            return View(dados);
        }




        //CREATE USER -criar a view em branco, para colocar o html pronto,
        //e enviar os dados do cadastro para o banco de dados.






        //DELETE USER

        // GET: api/User/Delete/id
        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)  //Metodo para  confirmar a eliminacao dos dados
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Users.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }



        // POST: api/User/Delete/id
        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Users.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }

            _context.Users.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); // Redirect to the Index action
        }



        //VISUALIZAR DADOS- Controller
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id) //detalha os dados
        {
           
            if (id == null) { return NotFound(); }

            var dados = await _context.Users.FindAsync(id); //encontra os dados


            if (dados == null) { return NotFound(); }

            return View(dados);
        }



    }
}



