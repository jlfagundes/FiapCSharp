using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tarefa_ASPNET_MVC.Models;
using Tarefa_ASPNET_MVC.Repository;
using Tarefa_ASPNET_MVC.Repository.Context;

namespace Tarefa_ASPNET_MVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalRepository animalRepository;

        public AnimalController()
        {
            animalRepository= new AnimalRepository();

        }

        // GET: Animal
        public async Task<IActionResult> Index()
        {
            var listarAnimais = animalRepository.Listar();
              return View(listarAnimais);
        }

        /*
        // GET: Animal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ANIMAL == null)
            {
                return NotFound();
            }

            var animal = await _context.ANIMAL
                .FirstOrDefaultAsync(m => m.IdAnimal == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // GET: Animal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Animal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAnimal,Nome,Especie,Peso")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        // GET: Animal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ANIMAL == null)
            {
                return NotFound();
            }

            var animal = await _context.ANIMAL.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        // POST: Animal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAnimal,Nome,Especie,Peso")] Animal animal)
        {
            if (id != animal.IdAnimal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalExists(animal.IdAnimal))
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
            return View(animal);
        }

        // GET: Animal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ANIMAL == null)
            {
                return NotFound();
            }

            var animal = await _context.ANIMAL
                .FirstOrDefaultAsync(m => m.IdAnimal == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // POST: Animal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ANIMAL == null)
            {
                return Problem("Entity set 'DataBaseContext.ANIMAL'  is null.");
            }
            var animal = await _context.ANIMAL.FindAsync(id);
            if (animal != null)
            {
                _context.ANIMAL.Remove(animal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalExists(int id)
        {
          return _context.ANIMAL.Any(e => e.IdAnimal == id);
        }
        */
    }
}
