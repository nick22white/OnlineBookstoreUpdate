using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            //Checks if pending migrations
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //Creates database with these items
            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthFirstName = "Victor",
                        AuthLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthFirstName = "Doris Kearns",
                        AuthLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthFirstName = "Alice",
                        AuthLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumPages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthFirstName = "Ronald C.",
                        AuthLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumPages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthFirstName = "Laura",
                        AuthLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumPages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthFirstName = "Michael",
                        AuthLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumPages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthFirstName = "Cal",
                        AuthLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        NumPages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthFirstName = "Michael",
                        AuthLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        NumPages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthFirstName = "Richard",
                        AuthLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthFirstName = "John",
                        AuthLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        NumPages = 642
                    },

                    new Book
                    {
                        Title = "The Count of Monte Cristo",
                        AuthFirstName = "Alexandre",
                        AuthLastName = "Dumas",
                        Publisher = "Penguin Classics",
                        ISBN = "978-0140449266",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 14.40,
                        NumPages = 1276
                    },

                    new Book
                    {
                        Title = "The Way of Kings",
                        AuthFirstName = "Brandon",
                        AuthLastName = "Sanderson",
                        Publisher = "Tor Fantasy",
                        ISBN = "978-0765365279",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 9.59,
                        NumPages = 1280
                    },

                    new Book
                    {
                        Title = "Essentialism",
                        AuthFirstName = "Greg",
                        AuthLastName = "McKeown",
                        Publisher = "Crown",
                        ISBN = "978-0804137409",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 13.43,
                        NumPages = 288
                    }



                ) ;

                //Saves changes to the database
                context.SaveChanges();
            }
        }
    }
}
