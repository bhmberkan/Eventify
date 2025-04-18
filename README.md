# 📌 Eventify

**Eventify**, ASP.NET Core teknolojisi kullanılarak geliştirilen bir etkinlik yönetim sistemidir. Katmanlı mimari prensibiyle inşa edilen bu proje; ölçeklenebilir, sürdürülebilir ve genişletilebilir bir yapı sunar. Etkinliklerin listelenmesi, yönetilmesi ve kullanıcılarla paylaşılması gibi temel işlemleri API tabanlı olarak sunmaktadır.
Bir veri tabanı oluşturulmamış, Entity frameworke ait InMemory kullanılmıştır. Pagination gibi konular ele alınmıştır. 

## 🚀 Proje Özellikleri

- 🔹 ASP.NET Core ile geliştirilmiş Web API
- 🔹 Katmanlı mimari (Core, Infrastructure, API)
- 🔹 C# dili ile yazılmış temiz ve okunabilir kod yapısı
- 🔹 Repository ve Unit of Work desenlerine uygun yapı
- 🔹 Genişletilebilir Entity yapısı ve servis katmanları

## 🧱 Katmanlar

### 🔸 Core
- Domain modelleri, servis arayüzleri ve genel iş kuralları burada yer alır.

### 🔸 Infrastructure
- Veri erişim işlemleri (Entity Framework, DbContext, Repository implementasyonları)

### 🔸 Presentation (Eventify.API)
- API Controller'ları ve HTTP endpoint'leri

## 💼 Kullanılan Teknolojiler

- ASP.NET Core Web API
- C#
- Entity Framework Core
- Katmanlı Mimari
- SOLID Prensipleri

## 📷 Fotograflar

![image](https://github.com/user-attachments/assets/914f66b0-1d6e-4729-b480-c6bd043348b4)
<br>
![image](https://github.com/user-attachments/assets/240f6c92-4ac4-417d-95a5-55ca04b22417)
<br>



## ⚙️ Kurulum

1. **Projeyi klonlayın:**
   ```bash
   git clone https://github.com/bhmberkan/Eventify.git
   ```

2. **Visual Studio veya VS Code ile açın.**

3. **NuGet paketlerini geri yükleyin:**
   ```bash
   dotnet restore
   ```

4. **Veritabanını oluşturun:**
   - `appsettings.json` içinde veritabanı bağlantınızı ayarlayın.
   - Ardından aşağıdaki komutlarla migration işlemlerini gerçekleştirin:
     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

5. **Projeyi çalıştırın:**
   ```bash
   dotnet run --project Eventify.API
   ```


## 🤝 Katkıda Bulunma

Katkıda bulunmak isterseniz pull request gönderebilir veya issue oluşturabilirsiniz. Projeyi beğendiyseniz ⭐ vererek destek olabilirsiniz!

---

📌 **Berkan Burak Turgut** tarafından geliştirilmiştir.



