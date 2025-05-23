using System;
using System.Xml.Linq;

namespace PatikaLibrary
{
	public class Library
	// Bu Class, bu sınıfa ait şekilde  oluşturulacak kitap nesnelerinin şablonudur
	// bu nesnelere ait özellikler(property) ve nesenlere özgü metotlar burada tanımlanır.
	{

		public string NameAuthor { get; set; }
		public string SurnameAuthor { get; set; }
		public string NameBook { get; set; }
		public int PageTotal { get; set; }
		public string Publisher { get; set; }
		public DateTime DateRegistry { get; set; }

		// yukarıda yer alan property'ler, nesneye özgü verilere dışarıdan kontrollü erişim sağlayan yapılardır
		//nesneye özgü verilere propertyler aracılğıyla hem değer atanır hem de bu veriler okunabilir.


        public Library()
		//bu bir default Constructor örneğidir. Parametre almaz. sınıftan newleme yoluyla nesne oluşturulduğunda, otomatik olarak çalışacak bir metottur ve burada nesneye oluşturulduğu anda o ana ait tarih ve saat bilgisini DateRegistry verisi olarak atar.
		{
            DateRegistry = DateTime.Now;
        }


        public Library(string bookname, string authorname, int totalpage, string publisher)
		//bu parametre alan alternatif constructur nesne oluşturma işlemi (newleme) sırasında parametre olarak aldığı verileri propertylere atar. 
		{
			NameBook = bookname;
			NameAuthor = authorname;
			PageTotal = totalpage;
			Publisher = publisher;
			DateRegistry = DateTime.Now;
		}

        public void ShowInfo() // bilgileri ekrana yazdıran metot
        {
            string dateTurkey = DateRegistry.ToString("dd.MM.yyyy HH:mm");//tarihin gün ay yıl şeklinde yazılmasını istediğim için toString metodu kullanıyorum.
            Console.WriteLine($"Kitabın adı: {NameBook}, yazarı: {NameAuthor} {SurnameAuthor},  sayfa sayısı {PageTotal}, yayınevi {Publisher}, sisteme kayıt tarihi {dateTurkey}");
        }
    }
}

