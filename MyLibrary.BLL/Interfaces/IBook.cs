using MyLibrary.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BLL.Interfaces
{
    public interface IBook
    {
        List<Book> GetAll();
        Book GetById(int Id);
        void Insert(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}