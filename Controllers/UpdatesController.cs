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
    public class UpdatesController : Controller
    {
        private readonly BTrackContext _context;

        public UpdatesController(BTrackContext context)
        {
            _context = context;
        }

        // GET: Updates
        public async Task<IActionResult> Index()
        {
              return _context.Update != null ? 
                          View(await _context.Update.ToListAsync()) :
                          Problem("Entity set 'BTrackContext.Update'  is null.");
        }

        // GET: Updates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Update == null)
            {
                return NotFound();
            }

            var update = await _context.Update
                .FirstOrDefaultAsync(m => m.bugId == id);
            if (update == null)
            {
                return NotFound();
            }

            return View(update);
        }

        // GET: Updates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Updates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("bugId,accountId,updateDate,updateDetails")] Update update)
        {
            if (ModelState.IsValid)
            {
                _context.Add(update);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(update);
        }

        // GET: Updates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Update == null)
            {
                return NotFound();
            }

            var update = await _context.Update.FindAsync(id);
            if (update == null)
            {
                return NotFound();
            }
            return View(update);
        }

        // POST: Updates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("bugId,accountId,updateDate,updateDetails")] Update update)
        {
            if (id != update.bugId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(update);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpdateExists(update.bugId))
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
            return View(update);
        }

        // GET: Updates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Update == null)
            {
                return NotFound();
            }

            var update = await _context.Update
                .FirstOrDefaultAsync(m => m.bugId == id);
            if (update == null)
            {
                return NotFound();
            }

            return View(update);
        }

        // POST: Updates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Update == null)
            {
                return Problem("Entity set 'BTrackContext.Update'  is null.");
            }
            var update = await _context.Update.FindAsync(id);
            if (update != null)
            {
                _context.Update.Remove(update);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UpdateExists(int id)
        {
          return (_context.Update?.Any(e => e.bugId == id)).GetValueOrDefault();
        }
    }
}
