using MyLibrary.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DAL.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private IBook _bookRepo;
        private IAuthor _authorRepo;


        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IBook Book
        {
            get
            {
                return _bookRepo = _bookRepo ?? new BookRepository(_context);
            }
        }

        public IAuthor Author
        {
            get
            {
                return _authorRepo = _authorRepo ?? new AuthorRepository(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}