# 🏦 Digital Banking Onboarding SaaS

![.NET](https://img.shields.io/badge/.NET-8.0/10.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)

Modern ve güvenli bir dijital müşteri edinimi (Digital Onboarding) simülasyonudur. Bu proje, **ASP.NET Core MVC** mimarisi kullanılarak, bankacılık standartlarındaki veri doğrulama ve iş akışı süreçlerini (Business Logic) göstermek amacıyla geliştirilmiştir.

## 🚀 Projenin Amacı ve Mimari Yaklaşım

Geleneksel "katılımcı formu" projelerinden farklı olarak bu proje, kurumsal bir finansal uygulamanın temel reflekslerini barındırır:
- **Separation of Concerns (İlgi Alanlarının Ayrılması):** Müşteri işlemleri (`ApplicationController`) ile arka ofis/admin işlemleri (`AdminController`) birbirinden tamamen izole edilmiştir.
- **Data Integrity (Veri Bütünlüğü):** C# Data Annotations kullanılarak Frontend'e güvenilmeyen, sağlam bir Backend validasyon mekanizması kurulmuştur.
- **PRG Pattern (Post-Redirect-Get):** Form gönderimlerinde mükerrer kayıtları (Double Submit) önlemek için PRG deseni uygulanmıştır.
- **Strongly-Typed Views:** Veri iletimi anonim nesnelerle değil, doğrudan Domain Model (`CustomerApplication`) üzerinden sağlanarak Compile-Time güvenliği elde edilmiştir.

## ✨ Temel Özellikler

* **🔒 Güvenli Müşteri Başvuru Formu:** TC Kimlik Numarası (RegEx), Minimum Gelir (Range) ve zorunlu alan kontrolleri içeren detaylı validasyon yapısı.
* **⚡ In-Memory Veri Yönetimi:** Geçici veritabanı simülasyonu için `static IEnumerable` tabanlı Repository Pattern kullanımı.
* **👨‍💻 Back-Office (Admin) Paneli:** * LINQ sorguları ile tüm başvuruların listelenmesi.
  * Dinamik routing (`asp-route-id`) ile ID bazlı detay sayfasına erişim.
* **🎨 Modern UI:** Bootstrap 5 ile tasarlanmış, mobil uyumlu (Responsive) kullanıcı arayüzü.

## 🗂️ Veri Modeli (Domain)

Müşteri başvuru modeli, finansal kesinlik (precision) için `decimal` ve `string` tiplerini optimize ederek kullanır:
- `Id` (int) - Otomatik atanan başvuru numarası
- `FullName` (string) - Ad Soyad
- `NationalId` (string) - 11 Haneli TC Kimlik No
- `MonthlyIncome` (decimal) - Aylık Net Gelir
- `ApplicationType` (string) - Başvurulan Ürün Türü

## ⚙️ Kurulum ve Çalıştırma

Projeyi kendi ortamınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. **Repoyu Klonlayın:**
   ```bash
   git clone [https://github.com/KULLANICI_ADIN/Banking-Digital-Onboarding.git](https://github.com/KULLANICI_ADIN/Banking-Digital-Onboarding.git)