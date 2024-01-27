using System.ComponentModel.DataAnnotations;

namespace HotelProject.WepUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {

        [Required(ErrorMessage = "İkon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage ="Hizmet başlığı giriniz")]
        [StringLength(100,ErrorMessage ="En fazla 100 karakter giriniz!")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
