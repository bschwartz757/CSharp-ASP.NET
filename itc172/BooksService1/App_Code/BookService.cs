using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
public class BookService : IBookService  //BookService is the service, IBookService is the interface
{
    //implemented IBookService interface; calls the methods from BookService
    //Implements the contracts in IBookService
    BookReviewDbEntities db = new BookReviewDbEntities();
    public List<string> GetCategories()
    {
        var cats = from c in db.Categories
                   orderby c.CategoryName
                   select new { c.CategoryName };

        List<string> categories = new List<string>();

        foreach(var c in cats)
        {
            categories.Add(c.CategoryName.ToString());
        }

        return categories;
    }

    public List<MyBook> GetBooks(string category)
    {
        var book = from b in db.Books
                   from c in b.Categories
                   from a in b.Authors
                   where c.CategoryName.Equals(category)
                   select new { b.BookTitle, a.AuthorName, b.BookISBN, b.BookEntryDate };

        List<MyBook> books = new List<MyBook>();
        foreach (var b in book)
        {
            MyBook bk = new MyBook();
            bk.BookTitle = b.BookTitle;
            bk.Author = b.AuthorName;
            bk.ISBN = b.BookISBN;
            books.Add(bk);
        }
        return books;
    }
}
