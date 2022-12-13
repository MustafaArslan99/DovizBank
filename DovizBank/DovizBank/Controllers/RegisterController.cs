using DovizBank.DAL;
using DovizBank.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DovizBank.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(User user)
        {
            using (var _context = new AppDbContext())
            {
                user.Balance = 1000;
                user.Type = "User";
                _context.Add(user);
                _context.SaveChanges();
                return "Kullanıcı Eklendi";
            }
        }
    }
}
