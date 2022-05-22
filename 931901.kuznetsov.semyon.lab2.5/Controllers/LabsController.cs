using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using _931901.kuznetsov.semyon.lab2._5.Models;
namespace _931901.kuznetsov.semyon.lab2._5.Controllers
{
    public class LabsController : Controller
    {
        private readonly ApplicationContext _context;

        public LabsController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Labs.ToListAsync());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address")] Labs lab)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lab);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var lab = await _context.Labs.FindAsync(id);
            if (lab == null) return NotFound();
            return View(lab);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, [Bind("Id,Name,Address")] Labs lab)
        {
            if (id != lab.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(lab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lab);
        }

        public async Task<IActionResult> Read(int? id)
        {
            if (id == null) return NotFound();
            var hospital = await _context.Labs.FindAsync(id);
            if (hospital == null) return NotFound();
            return View(hospital);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var lab = await _context.Labs.FindAsync(id);
            if (lab == null) return NotFound();
            _context.Labs.Remove(lab);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
