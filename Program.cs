using System.Threading.Channels;
using OgrenciListe;

Helper Operations = new Helper();

bool yes = true;

while (true)
{
    Console.WriteLine("\n--- ÖĞRENCİ YÖNETİM SİSTEMİ ---");
    Console.WriteLine("1 - Öğrenci Ekle");
    Console.WriteLine("2 - Öğrencileri Listele");
    Console.WriteLine("3 - Öğrenci Sil");
    Console.WriteLine("4 - Çıkış");
    Console.Write("Seçiminiz: ");
    string secim = Console.ReadLine();

    if (secim == "1")
    {
        Console.Clear();
        Operations.StudentAdd();
    }

    else if (secim == "2")
    {
        Console.Clear();
        Operations.StudentsList();
        break;
    }
    else if (secim == "3")
    {
        Console.Clear();
        Operations.StudentsDelete();
    }
    else if (secim == "4")
    {   
        Console.Clear();
        yes = false;
        break;
    }

    else
    {
        Console.WriteLine("Tekrar denemek için entera basınız.");
        Console.ReadLine();
    }

}
