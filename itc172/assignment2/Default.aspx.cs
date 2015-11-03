using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Partial classes allow you to split classes into multiple files
//Other half of the class is the HTML Default.aspx file
public partial class _Default : System.Web.UI.Page
{
    //Create new db
    BookReviewDbEntities db = new BookReviewDbEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Categories (capital C) is a built in object
            var categories = from c in db.Categories
                             orderby c.CategoryName
                             select new { c.CategoryName, c.CategoryKey };

            //DropdownList is the object we created
            DropDownList1.DataSource = categories.ToList();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryKey";
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int key = int.Parse(DropDownList1.SelectedValue.ToString());
        var books = from b in db.Books
                    from a in b.Authors
                    from c in b.Categories
                    where c.CategoryKey == key
                    select new { b.BookTitle, a.AuthorName, b.BookISBN, c.CategoryName };

        GridView1.DataSource = books.ToList();
        GridView1.DataBind();
    }
}