//Bu örnekte her sınıfa en az 2 arayüz (interface) uygulanacak.
//Senaryomuz: Evdeki bireylerin farklı rolleri var.

//Senaryo:
//Baba: Çalışır ve araba sürer, tuvalete gider.
//Anne: Yemek yapar ve çocuğa bakar, tuvalete gider.
//Çocuk: Ders çalışır ve oyun oynar, tuvalete gider.
//Bu sınıfların her biri en az 2 arayüzü uygulayacak.

// Nesneleri oluşturalım
using interFaceOrnek;

Baba baba = new Baba();
Anne anne = new Anne();
Cocuk cocuk = new Cocuk();

// Babanın görevleri
baba.Calisabilir();
baba.ArabaSuren();
baba.TuvaleteGiden();
Console.WriteLine();

// Annenin görevleri
anne.YemekYapan();
anne.CocukBakan();
anne.TuvaleteGiden();
Console.WriteLine();

// Çocuğun görevleri
cocuk.DersCalisan();
cocuk.OyunOynayan();
cocuk.TuvaleteGiden();

Console.ReadLine();
