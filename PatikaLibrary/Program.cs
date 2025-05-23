using PatikaLibrary;

class Program
{
    static void Main(string[] args)
    {
        Library book1 = new Library("Adı Aylin", "Ayşe",398,"Remzi Kitabevi");
        //// new anahtar kelimesi ile Library sınıfından bir nesne (book1) oluşturulmuştur.
        // new kullanıldığında otomatik olarak constructor çalışır.

        book1.SurnameAuthor = "Kulin";

        book1.ShowInfo();
    
    }

}