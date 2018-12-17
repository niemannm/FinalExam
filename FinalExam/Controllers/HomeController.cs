using FinalExam.DAL;
using FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FinalExam.Controllers
{
    public class HomeController : Controller
    {
        public static int userRole = 0;
        private GroceryStoreContext db = new GroceryStoreContext(); //need to add this inorder to grab information from the databse
       

        public ActionResult Index(string username)
        {
            ViewBag.user = username;
            return View();
        }
    
        public ActionResult HomeLogin(string username)
        {
            ViewBag.user = username;
            return View("HomeLogin");
        }


        public ActionResult SelectProduct()
        {
            return View(db.Products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password, bool RememberMe)
        {
            var currentUser = db.Database.SqlQuery<User>(
            "Select * " +
            "FROM [User] " + //NOTE add the square brackets for this query to work because User is a reserved word
            "WHERE Username = '" + Username + "' AND " +
            "Password = '" + Password + "'");


        
            if (currentUser.Count() > 0)// added the elementat(3) inorder to grab the results in the third field
            {

                //string sql = "SELECT UserRole FROM [User] WHERE Username='" + Username + "' AND " + "Password = '" + Password + "'";
                //cm = new SqlCommand(sql);
                //var dr = cm.ExecuteReader();
                //if (dr.Read()) // Read() returns TRUE if there are records to read, or FALSE if there is nothing
                //{
                //    SqlDataReader rdr = cm.ExecuteReader();

                //}

                //IEnumerable<User> data = db.Database.SqlQuery<User>(sql);
                // if (data.ElementAt(0).ToString() == "Admin")
                //{
                //    userRole = 1;
                //}
                //if (data.Count() > 0)
                //{

                    var adminStatus = db.Database.SqlQuery<User>(
                    "Select * " +
                    "FROM [User] " + //NOTE add the square brackets for this query to work because User is a reserved word
                    "WHERE UserRole = 'Admin' AND Username = '" + Username + "' AND " +
                    "Password = '" + Password + "'");

                    if(adminStatus.Count() > 0)
                {
                    userRole = 1;
                }
                    else
                {
                    userRole = 0;
                }
                              
                FormsAuthentication.SetAuthCookie(Username, RememberMe);
                return RedirectToAction("HomeLogin", "Home", new { username = Username });//use this to display a "Welcome 1268876
            }
            else
            {
                return View();
            }
            
        }
    }
}