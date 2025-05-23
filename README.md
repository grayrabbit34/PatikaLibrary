# 📚 Patika Kütüphane Uygulaması

Bu proje, Patika platformu için hazırlanan temel bir **kitap kayıt uygulamasıdır**. Uygulama, bir kitap nesnesinin sınıf yapısını ve temel nesne yönelimli programlama (OOP) kavramlarını kullanarak oluşturulmuştur.

---

## 🔧 Kullanılan Kavramlar

### ✅ `Class`
`Library` adlı sınıf, kitap nesnelerinin şablonudur. Kitaplara ait bilgiler (ad, yazar, sayfa sayısı, yayınevi, kayıt tarihi) bu sınıf içinde tanımlanır.

### ✅ `Property`
Sınıf içindeki özellikler `get; set;` şeklinde tanımlanarak dışarıdan **kontrollü erişim** sağlanır.

### ✅ `Constructor`
İki farklı yapıcı metot (constructor) tanımlanmıştır:
- **Parametresiz (default) constructor** → Yalnızca kayıt tarihi atanır.
- **Parametreli constructor** → Kitap adı, yazar adı, sayfa sayısı ve yayınevi doğrudan nesne oluştururken atanır.

Her iki constructor da kitabın `DateRegistry` özelliğini otomatik olarak `DateTime.Now` ile başlatır.

### ✅ `new` Anahtar Kelimesi
`Main` metodunda `new` anahtar kelimesi kullanılarak `Library` sınıfından bir kitap nesnesi (`book1`) oluşturulur.

---

## 🧪 Uygulama Çıktısı

```text
Kitabın adı: Adı Aylin, yazarı: Ayşe Kulin,  sayfa sayısı 398, yayınevi Remzi Kitabevi, sisteme kayıt tarihi 20.05.2025 23:11
