using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
[ServiceContract] //compiler directives
public interface IBookService
{
    [OperationContract] //compiler directives - these are not arrays
    List<string> GetCategories();  //Returns a list of strings

    [OperationContract] //compiler directives - these are not arrays
    List<MyBook> GetBooks(string category);  //Returns a list of strings
}

[DataContract] //compiler directives
public class MyBook
{
    [DataMember]    //Without the DataMember statement the results won't be added to the output
    public string BookTitle { set; get; }
    [DataMember]
    public string ISBN { set; get; }
    [DataMember]
    public string Author { set; get; }
    [DataMember]
    public int PublishYear { get; set; }
}
