# 🏠 RealEstate - Gayrimenkul Web Uygulaması

## 📌 Proje Hakkında

Bu proje, **Murat Yücedağ** tarafından hazırlanan *RealEstate* eğitim serisi temel alınarak geliştirilmiş, üzerine çeşitli iyileştirmeler ve eklemeler yapılmış bir **Gayrimenkul Web Sitesi** uygulamasıdır. Proje, gerçek hayat senaryoları göz önünde bulundurularak tasarlanmış olup hem **Admin**, hem **Emlakçı**, hem de **Ziyaretçi** kullanıcılar için ayrı paneller içermektedir.

Kullanıcılar sisteme kayıt olduktan sonra otomatik olarak **Emlakçı rolü**yle giriş yapar ve kendi ilanlarını **ekleyebilir, düzenleyebilir, silebilir ve yönetebilir**. Ayrıca, her ilana **birden fazla görsel yükleme** imkânı ve sistem içi **kullanıcılar arası mesajlaşma** özelliği de bulunmaktadır.

**Back-End** tarafı tamamen **.NET 8.0 Web API** ile geliştirilmiş ve bu API, **Front-End** tarafında bir **MVC projesi** içerisinde tüketilmiştir. Veritabanı işlemlerinde **Dapper ORM** tercih edilmiştir.

Bu projenin yazılım alanında kendimi geliştirdiğim bu süreçte bana çok şey kattığını söyleyebilirim. Yeni teknolojiler, teorik bilgiler ve genel .Net çevresiyle alakalı çok kıymetli bilgiler ve tecrübe edindim. 

**Proje Hakkında Detaylı Bilgiler**
---

## 🧰 Kullanılan Teknolojiler

### ⚙️ Backend
- ASP.NET Core 8.0 Web API  
- Dapper ORM  
- MSSQL Server  
- Swagger  
- JWT (Json Web Token)  
- SQL Trigger  

### 🎨 Frontend
- ASP.NET Core 8.0 MVC  
- HTML / CSS  
- Bootstrap  
- JavaScript  

---

## 🚀 Proje Özellikleri
- ✅ Katmanlı mimari yapısı  
- ✅ JWT ile kimlik doğrulama sistemi  
- ✅ Rol bazlı erişim kontrolleri (Admin, Emlakçı)  
- ✅ Her ilan için çoklu görsel yükleme  
- ✅ API üzerinden CRUD işlemleri  
- ✅ PagedList ile sayfalama sistemi  
- ✅ Gelişmiş mesajlaşma altyapısı  
- ✅ Admin panelinden içerik ve kullanıcı yönetimi  
- ✅ Dapper ile performans odaklı veritabanı erişimi  

---

## 🛠️ Admin Paneli İşlevleri
- Kullanıcı yönetimi (rol atama dahil)  
- İlan ve ilan görselleri yönetimi  
- Site içerik yönetimi (Hakkımızda, İletişim, Hizmetler)  
- Gelen kutusu yönetimi (iletişim formu)  
- Günün ilanı belirleyebilme  
- Yapılacaklar listesi  
- Detaylı istatistik ekranı  
- Profil güncelleme  

---

## 🧑‍💼 Emlakçı Paneli İşlevleri
- İlan ekleme / düzenleme / silme  
- Aktif / pasif ilan kontrolü  
- Kendi ilanları için görsel yönetimi  
- Gelen mesajları görüntüleyip yanıtlayabilme  
- Profil bilgilerini güncelleme  
- Panel içi istatistik ekranı  

---

## 📷 Projeden Bazı Görseller

### 🏠 Ana Sayfa
![MainPageTop](https://raw.githubusercontent.com/miractrkylmz/RealEstate-Dapper-WebAPI-NetCore8.0/master/RealEstate_Dapper_UI/wwwroot/ProjectScreenShots/mainPageTop.png)
![MainPage](https://raw.githubusercontent.com/miractrkylmz/RealEstate-Dapper-WebAPI-NetCore8.0/master/RealEstate_Dapper_UI/wwwroot/ProjectScreenShots/MainPage.png)

### 🧭 Emlakçı Paneli Lokasyonlar Sayfası
![Agent Panel Locations](https://raw.githubusercontent.com/miractrkylmz/RealEstate-Dapper-WebAPI-NetCore8.0/master/RealEstate_Dapper_UI/wwwroot/ProjectScreenShots/agentPanelLocations.png)

### 🗂️ Veritabanı Diyagramı
![Db Diagram](https://raw.githubusercontent.com/miractrkylmz/RealEstate-Dapper-WebAPI-NetCore8.0/master/RealEstate_Dapper_UI/wwwroot/ProjectScreenShots/dbDiagram.png)

### 🏘️ İlanlar Sayfası
![Properties Page](https://raw.githubusercontent.com/miractrkylmz/RealEstate-Dapper-WebAPI-NetCore8.0/master/RealEstate_Dapper_UI/wwwroot/ProjectScreenShots/propertiesPage.png)

### 📝 Detay Sayfası
![Property Details](https://raw.githubusercontent.com/miractrkylmz/RealEstate-Dapper-WebAPI-NetCore8.0/master/RealEstate_Dapper_UI/wwwroot/ProjectScreenShots/propertyDetails.png)
