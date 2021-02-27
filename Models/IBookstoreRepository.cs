using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    //Creates IQueryable interface
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
