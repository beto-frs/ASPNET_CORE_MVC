using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model_View_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_View_Controller.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Context _context;

        public PessoasController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoas.ToListAsync());
        }

        [HttpGet]    
        public IActionResult CriarPessoa() 
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> CriarPessoa (Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            else return View(pessoa);
        }

        [HttpGet]
        public IActionResult AtualizarPessoa(int? id)
        {
            if (id != null)
            {
                Pessoa pessoa = _context.Pessoas.Find(id);
                return View(pessoa);
            }
            else return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> AtualizarPessoa (int? id, Pessoa pessoa)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Update(pessoa);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(pessoa);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirPessoa(int? id)
        {
            if (id != null)
            {
                Pessoa pessoa = _context.Pessoas.Find(id);
                return View(pessoa);
            }
            else return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> ExcluirPessoa(int? id, Pessoa pessoa)
        {
            if (id != null)
            {
                _context.Remove(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
