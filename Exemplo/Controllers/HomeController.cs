using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo.Controllers
{
    public class codDelegate
    {

        delegate int Operacao(int a, int b);
        static void Main(string[] args);

    }

    class CodDelegate
    {

        delegate int Operacao(int a, int b, int c, int d);
        static void Main(string[] args)

        {

            Operacao op = (a, b, c, d) => (a + b + c + d)  *3;            
            Console.WriteLine  (op (2 + 4 + 5 + 6) * 3);
            Console.ReadLine();

        }

    }
    public class HomeController : Controller
    {
        public ActionResult Index()
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