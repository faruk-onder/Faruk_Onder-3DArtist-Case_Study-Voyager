# Unity Project - README

## 📌 Genel Bilgiler
Bu proje **Mac** ve **Windows** ortamlarında test edilmiştir.  
Proje açıldığında **boş sahne** ile başlar. Ana sahneye ulaşmak için şu yolu izleyin:  
`Assets > Scenes > SampleScene`  
Bu sahne, projenin asıl çalışma sahnesidir.

---

## 🖥 Platform Notları

### **Mac**
- Çok düşük bir ihtimalle **Console** üzerinde hata mesajları görünebilir.  
- Bu hatalar oyunun çalışmasını engellemez, genellikle **Clear** ile temizlenir ve tekrar oluşmaz.

### **Windows**
- Bazı Windows bilgisayarlarda (özellikle **Windows Defender** kaynaklı) oyunun çalışmasını engelleyen console hataları oluşabilir.
- **Çözüm Önerisi:**
  1. **Package Manager** üzerinden güncellemeleri kontrol edin.  
  2. Güncelleme yoksa ve paket kenarlarında **kırmızı ünlem** (örneğin: *recorder* paketinde) görüyorsanız:
     - Ünlem bulunmayan bir paketi kaldırın (**Remove**).
     - Tekrar yükleyin (**Install**).
  3. Bu işlem genellikle hataları temizler.
- Bu durum yalnızca **tek bir Windows PC**'de gözlemlenmiştir. Proje tekrar açıldığında sorun tekrarlamamıştır.

---

## 🎨 UI Düzeni
- Tüm UI öğeleri **Hierarchy** üzerinde şu konumda yer almaktadır:  
  `3D-Canvas > UICanvas-3D`
- `(HLG)` ve `(VLG)` etiketleri, kullanılan komponentlere dikkat çekmek amacıyla eklenmiştir. İnceleyebilirsiniz.

---

## 📦 Release Bilgisi
- **Release** bölümünde `.zip` dosyası bulunmaktadır (isteğe bağlı indirilebilir).
- Mac ve Windows üzerinde test edildi, bilinen bir problem yok.  
- Eğer tespit edilmemiş bir sorunla karşılaşırsanız, çözüm için iletişime geçebilirsiniz.

---

## ⚠ Geçici UI Durumu
- Oyunda ilk açılışta **açık olmaması gereken** bazı paneller şu an açık olarak bırakılmıştır.  
  - Örneğin: *Bottom Panel* oyun başladığında açılacak, ancak **Play ekranında** görünmeyecek.
- Bu durum **developer ile düzenlenecek** ve final versiyonda düzeltilmiş olacaktır.  
- Şu anda bu panellerin **görünür** bırakılmasının amacı, dikkat çekmektir.

---

## 💬 İletişim
Herhangi bir sorun, hata veya öneriniz varsa doğrudan iletişime geçebilirsiniz.

İletişim için: `me.farukonder@gmail.com` 
