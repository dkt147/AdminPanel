using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Controllers;
using System.Data.SqlClient;
using AdminPanel.Models;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
       
        Database1Entities1 db = new Database1Entities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMainJobs()
        {
            return View();
        }
        public ActionResult ViewMainJobs()
        {
            return View();
        }
        public ActionResult AddSubJobs()
        {
            return View();
        }
        public ActionResult ViewSubJobs()
        {
            return View();
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        public ActionResult ViewCategory()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(Users user)
        {
            User u = new User();
            u.Name = user.Name;
            u.Email = user.Email;
            u.Phone = user.Phone;
            u.Address = user.Address;
            u.Password = user.Password;

            db.Users.Add(u);

            
            return RedirectToAction("Index");
        }

        public ActionResult ViewUser()
        {
            return View();
        }
        public ActionResult Alerts()
        {
            return View();
        }
        public ActionResult Inventory()
        {
            return View();
        }
        public ActionResult PurchaseRequest()
        {
            return View();
        }
        public ActionResult PurchaseMRN()
        {
            return View();
        }
        public ActionResult PurchaseOrder()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();
        }
        public ActionResult Consumption()
        {
            return View();
        }
        public ActionResult Bill()
        {
            return View();
        }
        public ActionResult PaymentVoucher()
        {
            return View();
        }
        public ActionResult RecievedVoucher()
        {
            return View();
        }
        public ActionResult GeneralEntries()
        {
            return View();
        }
        public ActionResult VoucherReports()
        {
            return View();
        }
        public ActionResult AccountStatement()
        {
            return View();
        }
        public ActionResult BalanceSheet()
        {
            return View();
        }
        public ActionResult TrialBalance()
        {
            return View();
        }
        public ActionResult BankReports()
        {
            return View();
        }
        public ActionResult StockReports()
        {
            return View();
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
    }
}