using System.ComponentModel.DataAnnotations;

namespace WebApplication18_Authentication_Autorization.Models.DTOs
{
    public class RegistorDTO
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz..")]
        [Display(Name ="UserName")]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen email adresinizi giriniz.")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
