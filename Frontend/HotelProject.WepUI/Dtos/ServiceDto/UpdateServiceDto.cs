using System.ComponentModel.DataAnnotations;

namespace HotelProject.WepUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Başlık giriniz")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter giriniz!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter giriniz!")]
        public string Description { get; set; }
    }
}
