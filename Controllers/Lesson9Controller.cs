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
                ViewData["itog"] = ("Данная строка является палиндромом");
            }
            else
            {
                ViewData["itog"] = ("Данная строка не является палиндромом");
            }
           

            return View();
        }

        public string Index2(string textik = "test")
        {
            string itog;

            ViewData["textik"] = textik;


            char[] obrtextik = textik.ToCharArray();
            Array.Reverse(obrtextik);
            string finaltextik = new string(obrtextik);

            if (textik == finaltextik)
            {
                return "Данная строка является палиндромом";
            }
            else
            {
                return "Данная строка не является палиндромом";
            }

        }
    }
}
