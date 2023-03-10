using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soy adınızı giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage ="Fotografınızı yükleyin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adını girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Kullanıcı sifresini girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar girin")]
        [Compare ("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfirmedPassword { get; set; }

        [Required(ErrorMessage = "Kullanıcı mailini girin")]
        public string Mail { get; set; }
    }
}
