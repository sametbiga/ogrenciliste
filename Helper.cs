using System.Threading.Channels;

namespace OgrenciListe;

public class Helper
{
    public List<Student> Students;

    public Helper()
    {
        Students = new List<Student>();
        StudentsAdd();
    }

    public void StudentsAdd()
    {
        Students.Add(new Student { FirsName = "samet", LastName = "biga", Age = 20, Gender = "erkek", TCKN = "11111111111" });
        Students.Add(new Student { FirsName = "atahan", LastName = "atasoy", Age = 22, Gender = "erkek", TCKN = "11111111112"});
        Students.Add(new Student { FirsName = "hatice", LastName = "yildirim", Age = 24, Gender = "kadın", TCKN = "11111111113"});
        Students.Add(new Student { FirsName = "ayca", LastName = "ozturk", Age = 20, Gender = "kadın", TCKN = "11111111114"});
        Students.Add(new Student { FirsName = "atakan", LastName = "ceylan", Age = 19, Gender = "erkek", TCKN = "11111111115"});
    }

    public void StudentAdd()
    {
        Console.WriteLine("Öğrencinin adını giriniz:");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Öğrencinin soyadını giriniz:");
        string LastName = Console.ReadLine();
        Console.WriteLine("Öğrencinin TCKN'sini giriniz:");
        string TCKN = Console.ReadLine();
        Console.WriteLine("Öğrencinin yaşını giriniz:");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Öğrencinin cinsiyetini giriniz:");
        string Gender = Console.ReadLine();
        Students.Add(new Student
        {
            FirsName = FirstName,
            LastName = LastName,
            Age = Age,
            TCKN = TCKN,
            Gender = Gender
        }); 
        Console.WriteLine("Öğrenciyi eklediniz!");
    }
    
    public void StudentsList()
   
    {
        foreach (var Student in Students)
            
            {
                Console.WriteLine($"-{Student.FirsName} {Student.LastName} {Student.Age} yaşında {Student.Gender}");
            }    
        
    }

    public void StudentsDelete()
    {
        Console.WriteLine("silmek istediğiniz öğrencinin TCKN giriniz:");
        string tckn = Console.ReadLine();

        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].TCKN == tckn)
            {
                Students.RemoveAt(i);
                Console.WriteLine("Öğrenciyi silindi!");
                return;
            }
            else
            {
                Console.WriteLine("girdiğiniz tckn bulunamadı!");
            }   
        }
    }
}