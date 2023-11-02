using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTrack.Data;
using BTrack.Models;

namespace BTrack.Controllers
{
    public class BugsController : Controller
    {
        private readonly BTrackContext _context;

        public BugsController(BTrackContext context)
        {
            _context = context;
        }

        // GET: Bugs
        public async Task<IActionResult> Index()
        {
              return _context.Bugs != null ? 
                          View(await _context.Bugs.ToListAsync()) :
                          Problem("Entity set 'BTrackContext.Bugs'  is null.");
        }

        // GET: Bugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bugs == null)
            {
                return NotFound();
            }

            var bugs = await _context.Bugs
                .FirstOrDefaultAsync(m => m.bugId == id);
            if (bugs == null)
            {
                return NotFound();
            }

            return View(bugs);
        }

        // GET: Bugs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("bugId,bugStatus,bugTitle,bugDescription,bugPriority")] Bugs bugs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bugs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bugs);
        }

        // GET: Bugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bugs == null)
            {
                return NotFound();
            }

            var bugs = await _context.Bugs.FindAsync(id);
            if (bugs == null)
            {
                return NotFound();
            }
            return View(bugs);
        }

        // POST: Bugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("bugId,bugStatus,bugTitle,bugDescription,bugPriority")] Bugs bugs)
        {
            if (id != bugs.bugId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugsExists(bugs.bugId))
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
            return View(bugs);
        }

        // GET: Bugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bugs == null)
            {
                return NotFound();
            }

            var bugs = await _context.Bugs
                .FirstOrDefaultAsync(m => m.bugId == id);
            if (bugs == null)
            {
                return NotFound();
            }

            return View(bugs);
        }

        // POST: Bugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bugs == null)
            {
                return Problem("Entity set 'BTrackContext.Bugs'  is null.");
            }
            var bugs = await _context.Bugs.FindAsync(id);
            if (bugs != null)
            {
                _context.Bugs.Remove(bugs);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugsExists(int id)
        {
          return (_context.Bugs?.Any(e => e.bugId == id)).GetValueOrDefault();
        }
    }
}
