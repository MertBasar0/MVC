using System.ComponentModel.DataAnnotations;
using WebApplication18_Authentication_Autorization.Models.Entities.Concrete;

namespace WebApplication18_Authentication_Autorization.Models.DTOs
{
    public class UserUpdateDTO
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz..")]
        [Display(Name = "UserName")]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi giriniz.")]
        [EmailAddress]
        [Display(Name ="Email address")]
        public string Email { get; set; }


        public UserUpdateDTO()
        {
            
        }

        public UserUpdateDTO(AppUser appUser)
        {
            UserName = appUser.UserName;
            Password = appUser.PasswordHash;
            Email = appUser.Email;
        }
    }
}
