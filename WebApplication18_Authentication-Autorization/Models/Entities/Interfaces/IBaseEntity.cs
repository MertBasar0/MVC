namespace WebApplication18_Authentication_Autorization.Models.Entities.Interfaces
{
    public enum Status { Active = 1, Modified = 2, Passive= 3 }
    //IBaseEntity.cs interfaceinde yada daha önce hazırladığımız base sınıf mantığında her zaman id'yi ilgili ata sındılardan dağıtırdık.
    //Bu projede bunu yapmayacağız. Çünkü AppUser.cs sınıfında IdentityUser sınıfın bize sunduğu hazır varlıklardan faydalanıyor olacağız.
    //Bu hazır varlıkların kendi id'leri ve iyi bir şekilde düşünülmüş kullanıcı bazlı üyeleri bulunmaktadır. Bu yüzden IBaseEntity içerisinde
    //Id barındırmadık. Şayet bunu yapsaydık IdentityUser ile IBaseEntity üzerindeki id'lerimizz çakışacaktır.

    //Ayrıca arayüzlerde bu şekilde üye tanımlamanın yazılım dünyasında hoş karşılanmayacağını unutmayınız ama bizim uygulamamızdaki
    //appuser sınıfı concrete olan identity sınıdından miras alacağından dolayı burada appuser'ın soyutlanmaya bağlı kalması açısından
    //interface kullandık.
    
    public interface IBaseEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; }
    }
}
