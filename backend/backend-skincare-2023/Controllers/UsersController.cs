using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backend_skincare_2023.Data;
using backend_skincare_2023.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata.Ecma335;

namespace backend_skincare_2023.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
              return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }



       

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FirstName,LastName,Email,BirthDate,PasswordKey")] User user)
        {
            //Verifica se o user tem menos de 16 anos
            var age = DateTime.Today.Year - user.BirthDate.Year;
            var isLessThan16 = age < 16;

            if (isLessThan16)
            {
                ViewBag.ShowAgeAlert = true;
                return View(user);
            }


            if (ModelState.IsValid)
            {

           
                user.PasswordKey = BCrypt.Net.BCrypt.HashPassword(user.PasswordKey);

                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }


        public IActionResult Login()
        {
            return View();
        }


        //Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            var dados = await _context.Users
                .Where(u => u.Email == user.Email)
                .FirstOrDefaultAsync();

            if (dados == null)
            {
                ViewBag.Message = "Usuário ou senha inválidos";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(user.PasswordKey, dados.PasswordKey);

            if (senhaOk)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, dados.FirstName),
            new Claim(ClaimTypes.NameIdentifier, dados.UserId.ToString()),
            new Claim("isAdmin", dados.isAdmin.ToString()) 
        };

                var claimsIdentity = new ClaimsIdentity(claims, "login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(claimsPrincipal, authProperties);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Usuário ou senha inválidos";
            }

            return View();
        }




        //Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Users");
        }




        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,Email,BirthDate,PasswordKey")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.PasswordKey = BCrypt.Net.BCrypt.HashPassword(user.PasswordKey);
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
            }
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
          return _context.Users.Any(e => e.UserId == id);
        }
    }
}
