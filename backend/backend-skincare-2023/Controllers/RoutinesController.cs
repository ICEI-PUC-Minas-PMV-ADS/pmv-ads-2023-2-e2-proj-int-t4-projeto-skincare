using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backend_skincare_2023.Data;
using backend_skincare_2023.Models;

namespace backend_skincare_2023.Controllers
{
    public class RoutinesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoutinesController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Rota pagina rotina gerada com api
        [Route("Routines/SkinRoutine")]
        public IActionResult SkinRoutine()
        {
            var viewModel = new RoutineText
            {
                Text = "Limpeza Matinal:\nUse um limpador facial suave formulado para pele oleosa. Evite sabonetes que podem ressecar a pele, pois isso pode estimular ainda mais a produção de óleo.\n\nTônico:\nAplique um tônico adstringente para ajudar a equilibrar o pH da pele e reduzir a oleosidade. Procure por ingredientes como ácido salicílico para combater a acne e controlar a produção de óleo.\n\nHidratação:\nOpte por um hidratante oil-free e não comedogênico. Gel ou loções leves são boas opções para manter a pele hidratada sem adicionar excesso de oleosidade.\n\nProteção Solar:\nUse um protetor solar de amplo espectro com FPS 30 ou superior. Escolha uma fórmula livre de óleo para evitar o excesso de brilho.\n\nLimpeza Noturna:\nRemova a maquiagem e limpe a pele com um limpador suave. Considere o uso de produtos de limpeza que contenham ácidos suaves para esfoliação suave.\n\nTratamento Específico:\nSe necessário, adicione um tratamento específico para pele oleosa, como um sérum com ácido salicílico para controlar a acne. Lembre-se de que a consistência é fundamental em qualquer rotina de skincare. Adapte os produtos com base na resposta da sua pele e, se possível, consulte um dermatologista para obter recomendações personalizadas v Limpeza Matinal:\nUse um limpador facial suave formulado para pele oleosa. Evite sabonetes que podem ressecar a pele, pois iss Limpeza Matinal:\nUse um limpador facial suave formulado para pele oleosa. Evite sabonetes que podem ressecar a pele, pois iss Limpeza Matinal:\nUse um limpador facial suave formulado para pele oleosa. Evite sabonetes que podem ressecar a pele, pois iss Limpeza Matinal:\nUse um limpador facial suave formulado para pele oleosa. Evite sabonetes que podem ressecar a pele, pois iss Limpeza Matinal:\nUse um limpador facial suave formulado para pele oleosa. Evite sabonetes que podem ressecar a pele, pois iss ."
            };

            return View(viewModel);
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
