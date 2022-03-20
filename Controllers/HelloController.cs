using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebDz1.Controllers
{
    public class HelloController : Controller
    {
        // 
        // Вариант с простым вызовом файла Index из папки View

        /*
        public IActionResult Index()
        {
            return View();
        }
        */


        public IActionResult Index(string name, int age)
        {
                        
            ViewData["N"] = name;
            ViewData["a"] = age;
            ViewData["info"] = "Ваше имя: " + name + "возраст ваш " + age;


            return View();
        }



        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;

        /*
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        */

        // https://localhost:7285/Hello/Welcome/3?name=Rick 
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
