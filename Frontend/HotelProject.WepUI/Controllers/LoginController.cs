using HotelProject.EntityLayer.Concrete;
using HotelProject.WepUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WepUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto dto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "bookingAdmin");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
