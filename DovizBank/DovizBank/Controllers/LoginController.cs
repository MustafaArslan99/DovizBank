using DovizBank.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DovizBank.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //Index.html sayfasında şifremi unuttum butonu yapılacak.

        [HttpPost]
        public string Index(string Username, string Password)
        {
            using (var _context = new AppDbContext())
            {
                var user = _context.Users.Where(u => u.Username == Username && u.Password == Password).SingleOrDefault();

                if (user != null)
                {
                    if (user.Type == "Admin")
                    {
                        return "Admin Sayfasına Gidilecek";
                    }
                    else
                    {
                        return "Kulanıcı Sayfasına Gidilecek";
                    }
                }
                else
                {
                    //kayıt ekranına gönderilecek
                    return "User Bulunamadı";
                }
            }
        }
    }
}
