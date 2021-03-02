using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;

namespace OnlineBookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookstoreRepository repository;

        //Constructor
        public NavigationMenuViewComponent (IBookstoreRepository r)
        {
            repository = r;
        }

        //Drop partial view
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
