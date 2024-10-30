# Sayı Karesi Hesaplama Uygulaması

## İçindekiler
- [Proje Hakkında](#proje-hakkında)
- [Gereksinimler](#gereksinimler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Kod Yapısı](#kod-yapısı)
- [Hata Yönetimi](#hata-yönetimi)


## Proje Hakkında
Bu uygulama, kullanıcıdan bir sayı girmesini isteyerek bu sayının karesini hesaplar ve ekrana yazdırır. Kullanıcı geçersiz bir giriş yaptığında uygun hata mesajları gösterilir. Uygulama, `try-catch` yapısını kullanarak hata yönetimi sağlar.

## Gereksinimler
- .NET SDK (en az .NET Core 3.1 veya .NET 5.0)
- C# geliştirme ortamı (örneğin, Visual Studio, Visual Studio Code)

## Kurulum
1. **Gereksinimleri Karşılayın**: Gerekli yazılımların kurulu olduğundan emin olun.
2. **Projenin Klonlanması**:
   ```bash
   git clone https://github.com/kullaniciadi/projeadi.git
   ```
3. **Proje Klasörüne Gitme**:
   ```bash
   cd projeadi
   ```

## Kullanım
1. **Uygulamayı Başlatın**: Terminal veya komut istemcisinde aşağıdaki komutu çalıştırın:
   ```bash
   dotnet run
   ```

2. **Kullanıcı Girdisi**: Konsolda "Lütfen bir sayı girin:" mesajını göreceksiniz. Geçerli bir sayı girin.

3. **Sonuç**: Uygulama, girdiğiniz sayının karesini hesaplayıp ekrana yazdıracaktır. Geçersiz bir giriş yaparsanız, uygun hata mesajı görüntülenecektir.

## Kod Yapısı
Aşağıda, programın temel yapısı yer almaktadır:

```csharp
while (true)
{
    try
    {
        Console.Write("Lütfen bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double kare = sayi * sayi;
        Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
    }
}
```

- **while (true)**: Kullanıcı geçerli bir giriş yapana kadar döngü devam eder.
- **try-catch Blokları**: Kullanıcıdan alınan girişin doğruluğunu kontrol eder ve hataları yakalar.

## Hata Yönetimi
- **FormatException**: Kullanıcı geçersiz bir format (örneğin, harf veya sembol) girdiğinde yakalanır ve "Geçersiz giriş! Lütfen bir sayı giriniz." mesajı gösterilir.
- **OverflowException**: Kullanıcı çok büyük veya çok küçük bir sayı girdiğinde yakalanır ve "Geçersiz giriş! Lütfen sayı giriniz." mesajı gösterilir.

