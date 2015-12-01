using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OutOfTheBox.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookDBContext> 
    {
        //override the seed method by deriving from DropCreateDatabaseAlways<T>
        protected override void Seed(BookDBContext context )
        {
            context.Books.Add(new Book()
            {
                Name = "Learning Web Design",
                PubDate = new DateTime(1999, 1, 1),
                Price = 17.99m,
                Genre = "Programming"
            });

            context.Books.Add(new Book()
            {
                Name = "BFG",
                PubDate = new DateTime(1968, 5, 11),
                Price = 17.99m,
                Genre = "Fantasy"
            });

            context.Books.Add(new Book()
            {
                Name = "The Little Prince",
                PubDate = new DateTime(1978, 2, 9),
                Price = 6.99m,
                Genre = "Kids"
            });

            base.Seed(context); 
        }
    }
}