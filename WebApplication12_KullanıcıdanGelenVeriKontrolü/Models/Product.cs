using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12_KullanıcıdanGelenVeriKontrolü.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Lütfen ProductName alanını doldurunuz.")] // Eğer ilgili alan boş geçilmeye çalışılırsa hata mesajı verilecek.
        [StringLength(100,ErrorMessage ="Lütfen ürün adını en fazla 100 karakter giriniz.")]
        public string ProductName { get; set; }

        
        public int Quantity { get; set; }

        [RegularExpression(@"^[\w -\.] +@([\w -] +\.)+[\w-]{2,4}$", ErrorMessage ="mail adresini doğru giriniz.")]
        [EmailAddress(ErrorMessage ="Lüften mail adresinizi doğru giriniz.")]
        public string EkleyenEmail { get; set; }
    }
}


//Validation : bir deperin içinde bulunduğu şartlara uygun olması durumudur. Belirlenen koşullara ve amaca uygun olup olmama durumunun kontrol edilmesidir.
//Validation iki taraflı yapılabilir.
//Serverda yapılırsa => server side validation
//Client'da yapılırsa => Client side validation

//İkisini bir arada kullanmalıyız. Bu şekilde yapılırsa server yorulmadan önden bazı filtrelemeleri yapabilmiş oluruz.



//Örnek Çalışma =>>
//Kullanıcı Kayıt için bir form oluştur. bootstrapdan alabilirsin.
//Kullanıcı adi (KullaniciAdi 30 karakterden fazla olamasın) ve kulalnıcı adi a herfi ile başlamalı
//adress (500 max karakter)
//mail
//telefon
//kredikartı
//Height aralığı (cm cinsinde 1.00--2.50 aralığı olabilsin) 
//ve senin ekleyebileceğin ne varsa..


//değerleri alabilen bir form oluştur.
//Bu forma data post edildiğinde ilgili validations doğrulamaları gerçekleşsin.
//Bütün bilgiler doğru bir şekilde post işlemi gerçekleşsin. Eğer hata ile karşılaşırsa validation içerisindeki error message'ları ilgili text alanlarının yanında görelim.
