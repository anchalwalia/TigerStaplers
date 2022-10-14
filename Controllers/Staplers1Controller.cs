using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TigerStaplers.Data;
using TigerStaplers.Models;

namespace TigerStaplers.Controllers
{
    public class Staplers1Controller : Controller
    {
        private readonly TigerStaplersContext _context;

        public Staplers1Controller(TigerStaplersContext context)
        {
            _context = context;
        }

        // GET: Staplers1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stapler.ToListAsync());
        }

        // GET: Staplers1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stapler = await _context.Stapler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stapler == null)
            {
                return NotFound();
            }

            return View(stapler);
        }

        // GET: Staplers1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Staplers1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Color,Size,Material,Price,PinsIncluded")] Stapler stapler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stapler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stapler);
        }

        // GET: Staplers1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stapler = await _context.Stapler.FindAsync(id);
            if (stapler == null)
            {
                return NotFound();
            }
            return View(stapler);
        }

        // POST: Staplers1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Color,Size,Material,Price,PinsIncluded")] Stapler stapler)
        {
            if (id != stapler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stapler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaplerExists(stapler.Id))
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
            return View(stapler);
        }

        // GET: Staplers1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stapler = await _context.Stapler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stapler == null)
            {
                return NotFound();
            }

            return View(stapler);
        }

        // POST: Staplers1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stapler = await _context.Stapler.FindAsync(id);
            _context.Stapler.Remove(stapler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaplerExists(int id)
        {
            return _context.Stapler.Any(e => e.Id == id);
        }
    }
}
