using Lab_Task_1__Product_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Lab_Task_1__Product_.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string connString = @"Server= DESKTOP-SLU3MPS\SQLEXPRESS; Database=PMS; Integrated Security= true";
            SqlConnection conn = new SqlConnection(connString);
            string query = String.Format("select * from Products");
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = (float) reader.GetDouble(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                };

                products.Add(p);
                
            }
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            string connString = @"Server= DESKTOP-SLU3MPS\SQLEXPRESS; Database=PMS; Integrated Security= true";
            SqlConnection conn = new SqlConnection(connString);
            string query = String.Format("Insert into Products values ('{0}','{1}','{2}','{3}')", p.Name,p.Price,p.Quantity,p.Description);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return RedirectToAction("Index");
        }
    }
}