using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Core_Proje.Areas.Writer.Models
{
	public class UserLoginViewModel
	{
		[Display(Name = "Kullanıcı Adı")]
		[Required(ErrorMessage ="Kullanıcı Adını giriniz ...!")]
		public string UserName { get; set; }

		[Display(Name = "Sifre")]
		[Required(ErrorMessage = "Sifreyi giriniz ...!")]
		public string Password { get; set; }
	}
}
