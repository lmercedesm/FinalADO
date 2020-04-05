using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalADO.Controllers
{
    public class ProveedoresController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Proveedores
        public ActionResult Index()
        {
            return View();
        }
        void ConnectionString()
        {

            con.ConnectionString = ConfigurationManager.ConnectionStrings["COVID"].ConnectionString;

        }

    }
}