using System;
namespace OnlineBookstore.Models.ViewModels
{
    public class PagingInfo
    {
        //Data about pages
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
