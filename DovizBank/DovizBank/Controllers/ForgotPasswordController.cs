using DovizBank.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DovizBank.Controllers
{
    public class ForgotPasswordController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        private string CreatePassword()
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(0,11);
            int randomchars = rnd.Next(0, 29);
            int randomspecialcharacters = rnd.Next(0, 6);

            int randomnumber2 = rnd.Next(0, 11);
            int randomchars2 = rnd.Next(0, 29);
            int randomspecialcharacters2 = rnd.Next(0, 6);

            int randomnumber3= rnd.Next(0, 11);
            int randomchars3= rnd.Next(0, 29);
            int randomspecialcharacters3 = rnd.Next(0, 6);

            string numbers = "0123456789";
            string Chars = "abcçdefgğhıijklmnoöprsştuüvyz";
            string specialcharacters = "@$!%&?";

            return "" + numbers[randomnumber] + Chars[randomchars] + specialcharacters[randomspecialcharacters] +
                   numbers[randomnumber2] + Chars[randomchars2] + specialcharacters[randomspecialcharacters2] +
                   numbers[randomnumber3] + Chars[randomchars3] + specialcharacters[randomspecialcharacters3];
        }

        [HttpPost]
        public string Index(string Username, string Email)
        {
            using (var _context = new AppDbContext())
            {
                var user = _context.Users.Where(u => u.Username == Username && u.Email == Email).SingleOrDefault();

                if (user != null)
                {
                    user.Password = CreatePassword();
                    _context.SaveChanges();

                    //Mail Gönderilecek.


                    return "Yeni şifreniz : " + user.Password + "\n İstediğiniz zaman hesap sayfasından değiştirebilirsiniz.";

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
