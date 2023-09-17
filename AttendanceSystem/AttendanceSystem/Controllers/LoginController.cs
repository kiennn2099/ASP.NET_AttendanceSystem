using AttendanceSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceSystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection f)
        {
            string username = f["user"].ToString();
            string password = f["password"].ToString();
            AttendanceSystemContext con = new AttendanceSystemContext();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.ErrorMessage0 = "Vui lòng nhập tài khoản & mật khẩu.";
                return View();
            }
            else
            {
                var st = con.Students.FirstOrDefault(s => s.Email == username && s.Password == password);
                if (st != null)
                {
                    return Redirect("/Home/index");
                }
                var tc = con.Teachers.FirstOrDefault(t => t.Email == username && t.Password == password);
                if (tc != null)
                {
                    return Redirect("/Teacher/Home"); 
                }
                var stf = con.Staff.FirstOrDefault(t => t.Email == username && t.Password == password);
                if (stf != null)
                {
                    return Redirect("/Admin/Home");
                }

                ViewBag.ErrorMessage = "Sai tài khoản & mật khẩu.";
                return View();
                
            }
                       
        }

    }
}
