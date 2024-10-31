using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Botas.Data;
using Botas.Models;

namespace Botas.Controllers
{
    public class BotasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BotasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Botas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Bota.Include(b => b.Fornecedor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Botas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bota = await _context.Bota
                .Include(b => b.Fornecedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bota == null)
            {
                return NotFound();
            }

            return View(bota);
        }

        // GET: Botas/Create
        public IActionResult Create()
        {
            ViewData["FornecedorId"] = new SelectList(_context.Set<Fornecedor>(), "Id", "Id");
            return View();
        }

        // POST: Botas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,Category,Brand,Size,FornecedorId")] Bota bota)
        {
            if (ModelState.IsValid)
            {
                bota.Id = Guid.NewGuid();
                _context.Add(bota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FornecedorId"] = new SelectList(_context.Set<Fornecedor>(), "Id", "Id", bota.FornecedorId);
            return View(bota);
        }

        // GET: Botas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bota = await _context.Bota.FindAsync(id);
            if (bota == null)
            {
                return NotFound();
            }
            ViewData["FornecedorId"] = new SelectList(_context.Set<Fornecedor>(), "Id", "Id", bota.FornecedorId);
            return View(bota);
        }

        // POST: Botas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Description,Price,Category,Brand,Size,FornecedorId")] Bota bota)
        {
            if (id != bota.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BotaExists(bota.Id))
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
            ViewData["FornecedorId"] = new SelectList(_context.Set<Fornecedor>(), "Id", "Id", bota.FornecedorId);
            return View(bota);
        }

        // GET: Botas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bota = await _context.Bota
                .Include(b => b.Fornecedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bota == null)
            {
                return NotFound();
            }

            return View(bota);
        }

        // POST: Botas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var bota = await _context.Bota.FindAsync(id);
            if (bota != null)
            {
                _context.Bota.Remove(bota);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BotaExists(Guid id)
        {
            return _context.Bota.Any(e => e.Id == id);
        }
    }
}
