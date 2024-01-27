using System.ComponentModel.DataAnnotations;

namespace HotelProject.WepUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim giriniz")]
        public  string Name { get; set; }

        [Required(ErrorMessage = "Soyisim giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage =("Şifreler uyuşmuyor!"))]
        public string ConfirmPassword { get; set; }
    }
}
