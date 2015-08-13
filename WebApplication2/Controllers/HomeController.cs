using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostParam(string Name)
        {

            ViewBag.name = Name;   
            return View("~/Views/Shared/View.cshtml");
        }

        public ActionResult PostParam1()
        {
            string Name = Request.QueryString["Name1"].ToString();


            ViewBag.name = Name;
            return View("~/Views/Shared/View.cshtml");
        }


        public ActionResult PostParam2(FormCollection fc)
        {
            string Name = fc["Name2"].ToString();


            ViewBag.name = Name;
            TempData["name"] = Name;
            
            //sample redirecting to other action
            return RedirectToAction("Index", "NewAction");
        }

        public ActionResult conn()
        {


           MySqlConnection  con = new MySqlConnection("server=us-cdbr-iron-east-02.cleardb.net;database=ad_55b0f9c367ab0d1;uid=ba331630319965;pwd=603b8557");
            MySqlDataReader dr;
            try
            {
                con.Open();

                //MySqlCommand cmd = new MySqlCommand("create table Service_Application(service_id int, firstname varchar(50),middlename varchar(50),lastname varchar(50) )", con);
                MySqlCommand cmd = new MySqlCommand("select * from Service_Application", con);
                //cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                string result = string.Empty;
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                        result+= dr.GetValue(i).ToString() + ", ";
                }
                
                

                

                TempData["name"] = result;
                return View("~/Views/Shared/View.cshtml");

            }
            finally
            {
                con.Dispose();
            }




            
        }


    }
}