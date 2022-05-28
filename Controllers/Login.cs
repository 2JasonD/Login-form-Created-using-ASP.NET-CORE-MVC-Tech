                                                                                                                                  using Microsoft.AspNetCore.Mvc;
using Login_Form2.Models;
using Login_Form2.Services;

namespace Login_Form2.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
            if(securityService.IsValid(userModel))
            {
                return View("LoginSuccess", userModel);
            }else
            
            {                                                                                                                                                                             
                return View("LoginFailure", userModel);
            }
            
        }



    }
}
