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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
