using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        public List<Book> myList { get; set; }

        public BooksController()
        {
            myList = new List<Book>() {new Book() { author = "JB", title = "india", year = 1982 },
                new Book() { author = "jimit", title = "uk", year = 1982 }};
        }

        // GET: Books
        public string get(string id)
        {
            return "hello world" + id;
        }

        public ActionResult get2()
        {
            return View("Error");
        }

        public ActionResult Edit(string id)
        {
            Book temp = myList.Find(bk => bk.title == id);
            return View("Edit", temp);
                
        }

        public void EditItem(string id,string t)
        {
            Book temp = myList.Find(bk => bk.title == id);
            temp.title = t;       
            
        }

        public ActionResult GetBooks()
        {
            return View("BookList",myList);
        }

        public ActionResult Details(string id)
        {
            Book temp = myList.Find(bk => bk.title == id);
            return View("Details", temp);
        }
    }
}