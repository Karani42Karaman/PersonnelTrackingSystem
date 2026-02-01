# Personel Takip Sistemi

ASP.NET MVC ile geliştirilmiş basit bir personel yönetim uygulaması.

## Proje Hakkında

Personel kayıtlarını ekleyip düzenleyebileceğiniz, listeleyip silebileceğiniz temel bir CRUD uygulaması. Entity Framework Database First yaklaşımıyla geliştirildi.

## Kullanılan Teknolojiler

- ASP.NET MVC 5
- Entity Framework 6.4.4 (Database First)
- AutoMapper 10.1.1
- Bootstrap 5.2.3
- SQL Server
- .NET Framework 4.8

## Mimari

Katmanlı mimari kullandım:

- **UI Katmanı**: MVC ile kullanıcı arayüzü
- **BLL Katmanı**: İş mantığı katmanı (service'ler burada)
- **DAL Katmanı**: Veritabanı işlemleri
- **Entities**: DTO ve entity sınıfları

## Özellikler

- Personel listeleme
- Yeni personel ekleme
- Personel bilgilerini düzenleme
- Personel silme
- Bootstrap ile responsive tasarım
- AutoMapper ile DTO mapping

## Veritabanı

Personel tablosunda şu alanlar var:
- Id
- Ad
- Soyad
- Doğum Tarihi
- Şehir
- Adres

## Kurulum

### Gereksinimler
- Visual Studio 2019+
- SQL Server
- .NET Framework 4.8

### Nasıl Çalıştırılır

1. Repoyu klonla
```bash
git clone https://github.com/kullaniciadi/PersonnelTrackingSystem.git
```

2. SQL Server'da veritabanını oluştur

```sql
CREATE DATABASE PersonnelTrackingDb;
GO

USE PersonnelTrackingDb;
GO

CREATE TABLE Personel (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    DogumTarihi DATE,
    Sehir NVARCHAR(50),
    Adres NVARCHAR(250)
);
```

3. Connection string'i güncelle

`Web.config` ve `App.Config` dosyalarındaki connection string'i kendi bilgilerinle değiştir:

```xml
<add name="PersonnelTrackingDbContext" 
     connectionString="Data Source=localhost,1435;
                       Initial Catalog=PersonnelTrackingDb;
                       User ID=sa;
                       Password=YourPassword;
                       TrustServerCertificate=True;" 
     providerName="System.Data.SqlClient" />
```

4. NuGet paketlerini restore et

5. Projeyi çalıştır (F5)

## Not

Bu projeyi öğrenme/case amaçlı yaptım. Eksikler var ama temel mimari doğru kuruldu.
