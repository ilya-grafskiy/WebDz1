using Microsoft.AspNetCore.Mvc;

namespace WebDz1.Controllers
{
    public class Lesson9Controller : Controller
    {
        public IActionResult Index(string textik = "test")
        {
            string itog;

            ViewData["textik"] = textik;

            
            char[] obrtextik = textik.ToCharArray();
            Array.Reverse(obrtextik);
            string finaltextik = new string(obrtextik);

            if (textik == finaltextik)
            {
                ViewData["itog"] = ("Данная строка является палидромом");
            }
            else
            {
                ViewData["itog"] = ("Данная строка не является палидромом");
            }
           

            return View();
        }
    }
}
