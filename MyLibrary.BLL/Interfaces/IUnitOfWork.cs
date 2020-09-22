using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BLL.Interfaces
{
    public interface IUnitOfWork
    {
        IBook Book { get; }
        IAuthor Author { get; }
        void Save();
    }
}
