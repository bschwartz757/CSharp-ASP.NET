using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BookReviewDbEntities db = new BookReviewDbEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var cats = from c in db.Categories
                       orderby c.CategoryName
                       select new { c.CategoryName };

            DropDownList1.DataSource = cats.ToList();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var bks = from b in db.Books
                  from c in b.Categories
                  orderby b.BookTitle
                  where c.CategoryName == DropDownList1.SelectedItem.Text
                  select new { b.BookTitle, b.BookISBN, b.BookEntryDate };

        GridView1.DataSource = bks.ToList();
        GridView1.DataBind();
    }
}