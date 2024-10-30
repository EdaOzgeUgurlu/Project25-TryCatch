while (true) // Sonsuz döngü, kullanıcı geçerli bir giriş yapana kadar devam edecek.
{
    try
    {
        // Kullanıcıdan sayı girmesini istiyoruz.
        Console.Write("Lütfen bir sayı girin: ");
     
        // Kullanıcının girdiği değeri double türüne dönüştürüyoruz.
        double sayi = Convert.ToDouble(Console.ReadLine());

        // Sayının karesini hesaplayıp ekrana yazdırıyoruz.
        double kare = sayi * sayi;
        Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        break; // Geçerli giriş alındığında döngüden çıkıyoruz.
    }
    catch (FormatException) // Eğer kullanıcı geçersiz bir format girerse
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
    catch (OverflowException) // Eğer kullanıcı harf veya sembol girerse
    {
        Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
    }
}
    