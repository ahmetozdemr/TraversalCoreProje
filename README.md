# TraversalCoreProje

İlk aşamada Business,Entity,Dataaccess ve Presentation katmanları oluşturuluyor

# Veritabanı kurulumu için gerekli paketler;

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.Tools

 Proje için diğer paketler
 
* FluentValidation (nesnelerin koyduğumuz kurallara uyup uymadığı kontrol ediliyor)

Veritabanı bağlantısı için gerekli bağlantılar

# Connection string;

* Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;TrustServerCertificate =true;

 Migration codes;
 - n tier katmanlı mimaride package manager code default project olarak Dataccess katmanını seçiyoruz.
 - Dataccess katmanı entity ve presentation katmanlarının referansını alması gerekiyor

* Add-Migration "mig1"
* Update-Database

*Remove-Migration (kaldırmak istenirse)


Dataaccess katmanımızda Generic interface ve Repository sınıflarımızı oluşturuyoruz

# Idenditiy paketleri

* Microsoft.AspNetCore.Identity.EntityFrameworkCore
* Microsoft.AspNetCore.Identity



# Resources

1. [Gençay Yıldız](https://www.youtube.com/@GencayYildiz)
2. [Murat Yücedağ](https://www.youtube.com/@MurattYucedag)
