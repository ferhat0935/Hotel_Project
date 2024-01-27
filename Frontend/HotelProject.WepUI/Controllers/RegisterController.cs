using HotelProject.EntityLayer.Concrete;
using HotelProject.WepUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WepUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto dto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser=new AppUser()
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email=dto.Mail,
                UserName=dto.Username
            };
            var result=await _userManager.CreateAsync(appUser,dto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
