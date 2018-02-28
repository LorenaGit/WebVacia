using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVacia.Controllers
{
    public class LorenaController : Controller
    {

        // GET /Lorena/Carvajal
        public string Carvajal()
        {
            string pagina = "";

            pagina += "<html>";

            pagina += "<head>";
            pagina += "<script>";
            pagina += "</scrpt>";
            pagina += "</head>";
            pagina += "<body>Este es el body";
            pagina += "</body>";
            pagina += "</html>";

            return pagina;
        }


    }
}