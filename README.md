# FlightReservationApp

Uçuş Rezervasyon Uygulaması, uçak bilgileri, lokasyonlar ve rezervasyonlar gibi uçuşla ilgili verilerin yönetimini sağlayan bir Windows Form uygulamasıdır. Kullanıcıların uçak, konum ve rezervasyon verilerini eklemelerini, güncellemelerini ve silmelerini kolaylaştıran kullanıcı dostu bir arayüz sunar. Uygulama, uçuş rezervasyonlarını ve ilgili bilgilerin yönetimini kolaylaştırmayı amaçlamaktadır. Ayrıca bu uygulama, SQLite veritabanı kullanarak verileri depolamaktadır.

----------------------
#KURULUM

* Projeyi GitHub veya benzer bir platformdan klonlayın veya projenin zip dosyasını indirin.
* Visual Studio veya benzer bir IDE kullanarak projeyi açın.
* DBContext sınıfında belirtilen SQLite veritabanı dosyasının oluşturulduğundan emin olun.
* Projeyi derleyin ve çalıştırın.

------------------------
#Kullanım Kılavuzu:

UÇAK KAYIT YÖNETİMİ

* Ana menüden AIRCRAFT MEMU' yü seçin.
* "AircraftInfo" formu aracılığıyla uçak ekleyebilir, güncelleyebilir ve silebilirsiniz.
* Uçak bilgilerini girdikten ve kayıt ettikten sonra datagridview nesnesinde o uçağı seçip güncelleme veya silme işlemi yapabilirsiniz.
* Veritabanında kaydedilmiş uçak bilgilerini görüntülemek için "AircraftInfo" formunu kullanabilirsiniz.

LOKASYON YÖNETİMİ

* Ana menüden LOCATION MEMU' yü seçin.
* "LocationInfo" formu aracılığıyla lokasyon ekleyebilir, güncelleyebilir ve silebilirsiniz.
* Lokasyon bilgilerini girdikten ve kayıt ettikten sonra datagridview nesnesinde o lokasyonu seçip güncelleme veya silme işlemi yapabilirsiniz.
* Veritabanında kaydedilmiş lokasyon bilgilerini görüntülemek için "LocationInfo" formunu kullanabilirsiniz.

REZERVASYON YÖNETİMİ

* Ana menüden REZERVATION MEMU' yü seçin.
* "ReservationInfo" formu aracılığıyla uçuş lokasyon ve kişisel bilgilerinizi girdikten sonra rezervasyon oluşturabilir ve kaydedebilirsiniz.
* Bilgiler girildikten sonra koltuk numarası seçip kayıt ediniz.
* Rezervasyonları görüntülemek için "ReservationInfo" formunu kullanabilirsiniz.

EK BİLGİLER

* TÜM FORMLAR İÇİN GEREKLİ BİLGİLER GİRİLDİKTEN SONRA KAYIT ETMEK İÇİN SAVE BUTONUNA BASILMALIDIR. 
* GİRDİĞİNİZ VERİYİ DÜZENLEMEK İÇİN DATAGRİDWİEV NESNESİNDEN İLGİLİ SATIRI SEÇİP DÜZELTMEK İSTEDİĞİNİZ YERİ DÜZELTİP "UPDATE" BUTONUNA BASIN.
* GİRDİĞİNİZ VERİYİ SİLMEK İÇİN DATAGRİDWİEV NESNESİNDEN İLGİLİ SATIRI SEÇİP "DELETE" BUTONUNA BASIN.
* 
----------------------
#GELİŞTİRİCİ NOTLARI

* Proje, C# programlama dili ve .NET Framework kullanılarak geliştirilmiştir.
* Entity Framework Core kullanılarak SQLite veritabanı işlemleri gerçekleştirilmiştir.
* Windows Forms kullanılarak masaüstü kullanıcı arayüzü oluşturulmuştur.

