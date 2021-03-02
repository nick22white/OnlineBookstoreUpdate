using System;
using System.Collections.Generic;

namespace OnlineBookstore.Models.ViewModels
{
    public class ProjectListViewModel
    {
        //Contains the data needed for Views
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
