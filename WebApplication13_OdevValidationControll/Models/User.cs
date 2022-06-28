using System.ComponentModel.DataAnnotations;

namespace WebApplication13_OdevValidationControll.Models
{
    public class User
    {
        [Required(ErrorMessage ="Lütfen boş bırakmayın.")]
        [StringLength(30,ErrorMessage ="Karakter fazla olmamalıdır.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayın.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayın.")]
        [StringLength(500, ErrorMessage = "Karakter fazla olmamalıdır.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayın.")]
        [EmailAddress(ErrorMessage ="Mail adresinizi doğru giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayın.")]
        [Phone(ErrorMessage ="Telefon numaranızı doğru giriniz.")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayın.")]
        [CreditCard(ErrorMessage ="Kart numaranız doğru değildir.")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = "Lütfen boş bırakmayın.")]
        [Range(100,250,ErrorMessage ="Boy doğru aralıkta değildi.")]
        public string Height { get; set; }
    }
}
