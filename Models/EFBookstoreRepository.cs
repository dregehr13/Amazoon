using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazoon.Models
{
    public class EFBookstoreRepository : IBookStoreRepository
    {
        private BookstoreContext context { get; set; }
        
        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
