using MyLibrary.BLL.Interfaces;
using MyLibrary.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.DAL.Repositories
{
    public class AuthorRepository : IAuthor
    {

        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int Id)
        {
            return _context.Authors.FirstOrDefault(a => a.AuthorId == Id);
        }

        public void Insert(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Update(Author author)
        {
            _context.Authors.Update(author);
        }
    }
}
