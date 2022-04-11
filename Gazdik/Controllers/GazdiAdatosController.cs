using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gazdik.Data;
using Gazdik.Models;

namespace Gazdik.Controllers
{
    public class GazdiAdatosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GazdiAdatosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GazdiAdatos
        public async Task<IActionResult> Index(int IdKeres, string NevKeres)
        {
            /*GazdiAdatok elso = new GazdiAdatok();

            elso.GazdiId = new SelectList(await _context.GazdiAdatok.Select(x => x).Distinct().ToListAsync());
            var adatok = _context.GazdiAdatok.Select(x => x);

            if (!string.IsNullOrEmpty(IdKeres))
            {
                if (IdKeres == "GazdiId") adatok = adatok.Where(x => string.IsNullOrEmpty(x.GazdiId));
                else adatok = adatok.Where(x => x.GazdiId == IdKeres);
            }

            if (!string.IsNullOrEmpty(NevKeres))
                adatok = adatok.Where(x => x.Nev == NevKeres);


            */
            return View(await _context.GazdiAdatok.ToListAsync());
        }

        // GET: GazdiAdatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gazdiAdatok = await _context.GazdiAdatok
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gazdiAdatok == null)
            {
                return NotFound();
            }

            return View(gazdiAdatok);
        }

        // GET: GazdiAdatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GazdiAdatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GazdiId,Nev,Cim,Telefonszam,Email")] GazdiAdatok gazdiAdatok)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gazdiAdatok);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gazdiAdatok);
        }

        // GET: GazdiAdatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gazdiAdatok = await _context.GazdiAdatok.FindAsync(id);
            if (gazdiAdatok == null)
            {
                return NotFound();
            }
            return View(gazdiAdatok);
        }

        // POST: GazdiAdatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GazdiId,Nev,Cim,Telefonszam,Email")] GazdiAdatok gazdiAdatok)
        {
            if (id != gazdiAdatok.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gazdiAdatok);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GazdiAdatokExists(gazdiAdatok.Id))
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
            return View(gazdiAdatok);
        }

        // GET: GazdiAdatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gazdiAdatok = await _context.GazdiAdatok
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gazdiAdatok == null)
            {
                return NotFound();
            }

            return View(gazdiAdatok);
        }

        // POST: GazdiAdatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gazdiAdatok = await _context.GazdiAdatok.FindAsync(id);
            _context.GazdiAdatok.Remove(gazdiAdatok);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GazdiAdatokExists(int id)
        {
            return _context.GazdiAdatok.Any(e => e.Id == id);
        }
    }
}
