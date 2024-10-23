using W3_PatikaKutuphanesi;

Kutuphane Kitap1 = new Kutuphane("Bir Kitap", "Ahmet", "Yilmaz", 320, "Alfa Yayinlari");
//parametre alan cosntructorlarda nesneleri tek satirda atayabiliriz

Kutuphane Kitap2 = new Kutuphane(); //burada parametre almayan constructor kullandigimiz icin tek tek nesneleri atamaliyiz
Kitap2.KitapAdi = "Baska Bir Kitap";
Kitap2.YazarAdi = "Ayse";
Kitap2.YazarSoyadi = "Saran";
Kitap2.SayfaSayisi = 215;
Kitap2.Yayinevi = "Beta Yayinevi ";

Kitap1.BilgiYazdir();
Kitap2 .BilgiYazdir();
