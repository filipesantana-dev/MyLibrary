using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLibrary.BLL.Models;
using MyLibrary.DAL;

namespace MyLibrary.WEB.Controllers
{
    public class BooksByAuthor : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksByAuthor(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AuthorBooks
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AuthorBooks.Include(a => a.Author).Include(a => a.Book);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AuthorBooks/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId");
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId");
            return View();
        }

        // POST: AuthorBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorId,BookId")] AuthorBook authorBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", authorBook.AuthorId);
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", authorBook.BookId);
            return View(authorBook);
        }
    }
}