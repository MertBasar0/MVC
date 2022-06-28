using Microsoft.AspNetCore.Identity;
using WebApplication18_Authentication_Autorization.Models.Entities.Interfaces;

namespace WebApplication18_Authentication_Autorization.Models.Entities.Concrete
{
    public class AppUser : IdentityUser,IBaseEntity
    {
        //IdentityUser => Microsoft.Extansion.Identity.Store sahip paket yüklenir.
        //AspNetCore.Identity bize hazır olarak sunulmuş bir sınıftır.
        //Asp.NetCore.Identity => Aracılığı ile işlemlerimizi hızlıca yürütürüz.
        //İçerisinde kullanıcıların tüm işlemlerini yürütebileceğimiz crud metotları ve migration ile hızlı veritabanı
        //gönderebileceğimiz sınıflar bulunmaktadır.Kullanıcı işlemleri için veritabanı ve uygulama tarafında bize identity altından
        //gelen 8 farklı sınıf aracılığıyla bizlere sunulmaktadır.

        public string Occupation { get; set; }

        private DateTime _created = DateTime.Now;

        public DateTime CreateDate { get=> _created; set => _created=value; }
        public DateTime? UpdateDate { get ; set ; }
        public DateTime? DeleteDate { get ; set ; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
