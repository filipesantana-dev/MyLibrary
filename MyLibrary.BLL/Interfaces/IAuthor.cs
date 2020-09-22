using MyLibrary.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BLL.Interfaces
{
    public interface IAuthor
    {
        List<Author> GetAll();
        Author GetById(int Id);
        void Insert(Author author);
        void Update(Author author);
        void Delete(Author author);
    }    
}
