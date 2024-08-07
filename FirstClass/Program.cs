using System;
using System.Globalization;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Hazır olan kişi listesini mi yazdırmak istiyorsanız 1'e basın\nÖğrenci oluşturmak için 2'e basın.\nÖğretmen oluşturmak için 3'e basın. ");
                string input = Console.ReadLine() ?? "";

                Person student1 = new Person("Ali", "Kaya", new DateTime(2000, 01, 01)); // Person sınıfından student1 nesnesi oluşturuyoruz.
                Person student2 = new Person("Sefa", "Yıldız", new DateTime(2000, 02, 02));

                Person teacher1 = new Person("Yusuf", "Ateş", new DateTime(1980, 01, 01)); // Person sınıfından teacher1 nesnesi oluşturuyoruz.
                Person teacher2 = new Person("Hakan", "Ercan", new DateTime(1975, 01, 01));



                if (input == "1")
                {
                    Console.WriteLine($"Öğrenci listesi \n{student1.Name} {student1.SurName} {student1.Birthdate.ToString("dd.MM.yyyy")}\n{student2.Name} {student2.SurName} {student2.Birthdate.ToString("dd.MM.yyyy")}\n" +
                        $"\nÖğretmen listesi\n{teacher1.Name} {teacher1.SurName} {teacher1.Birthdate.ToString("dd.MM.yyyy")}\n{teacher2.Name} {teacher2.SurName} {teacher2.Birthdate.ToString("dd.MM.yyyy")}");
                }

                else if (input == "2")
                {
                    Console.WriteLine("Öğrenci adını giriniz :"); // Kullanıcı yeni bir Person oluşturmak isterse ad soyad ve doğum tarihlerini alıyoruz.
                    string name = Console.ReadLine() ?? "";

                    Console.WriteLine("Öğrenci soyadını giriniz :");
                    string surName = Console.ReadLine() ?? "";

                    Console.WriteLine("Öğrenci doğum tarihini giriniz :");
                    string birthdateStr = Console.ReadLine() ?? ""; 
                    DateTime birthdate = new DateTime(); // Kullanıcı doğru tarih formatı girebilmesi için hem string değişken hemde DateTime olarak değişken oluşturuyoruz.

                    while (!DateTime.TryParseExact(birthdateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                    // Kullanıcı konsolda girdiği değerin formatı "dd.MM.yyyy" bu şekilde olursa DateTime nesnesine dönüştürme başarılı olur çıkışı bu şekilde yapar.
                    {
                        Console.Write("Geçersiz format. Lütfen bilgileri tekrar giriniz (örn: Ali Veli 15.05.2005): ");
                        birthdateStr = Console.ReadLine() ?? "";

                    }

                    Person newStudent = new Person(name, surName, birthdate); // Kullanıcının girdiği değerler ile Person oluşturulur.

                    Console.WriteLine($"Öğrencinin adı : {newStudent.Name}\nÖğrencinin soyadı : {newStudent.SurName}\nÖğrencinin doğumtarihi : {newStudent.Birthdate.ToString("dd.MM.yyyy")}");

                }

                else if (input == "3")
                {

                    Console.WriteLine("Öğretmen adını giriniz :"); // Kullanıcı yeni bir Person oluşturmak isterse ad soyad ve doğum tarihlerini alıyoruz.
                    string name = Console.ReadLine() ?? "";

                    Console.WriteLine("Öğretmen soyadını giriniz :");
                    string surName = Console.ReadLine() ?? "";

                    Console.WriteLine("Öğretmen doğum tarihini giriniz :");
                    string birthdateStr = Console.ReadLine() ?? "";
                    DateTime birthdate = new DateTime(); // Kullanıcı doğru tarih formatı girebilmesi için hem string değişken hemde DateTime olarak değişken oluşturuyoruz.

                    while (!DateTime.TryParseExact(birthdateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                    // Kullanıcı konsolda girdiği değerin formatı "dd.MM.yyyy" bu şekilde olursa DateTime nesnesine dönüştürme başarılı olur çıkışı bu şekilde yapar.
                    {
                        Console.Write("Geçersiz format. Lütfen bilgileri tekrar giriniz (örn: Ali Veli 15.05.2005): ");
                        birthdateStr = Console.ReadLine() ?? "";

                    }

                    Person newTeacher = new Person(name, surName, birthdate); // Kullanıcının girdiği değerler ile Person oluşturulur.
                    Console.WriteLine($"Öğrencinin adı : {newTeacher.Name}\nÖğrencinin soyadı : {newTeacher.SurName}\nÖğrencinin doğumtarihi : {newTeacher.Birthdate.ToString("dd.MM.yyyy")}");


                }
                else
                {
                    Console.WriteLine("Yanlış değer girdiniz");
                }

                
                Console.WriteLine("Programı tekrar başlatmak isterseniz 'y' basın çıkmak için 'n' basın");

                char continueChar;

                while (!char.TryParse(Console.ReadLine(), out continueChar) || "yn".IndexOf(continueChar) == -1)
                {
                    Console.Write("Geçerli bir tuş giriniz (y/n) = ");
                }

                run = continueChar == 'y';

            }
        }

    }
}