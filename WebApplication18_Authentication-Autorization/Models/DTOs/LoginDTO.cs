using System.ComponentModel.DataAnnotations;

namespace WebApplication18_Authentication_Autorization.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz..")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
