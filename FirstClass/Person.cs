using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Person // Person sınıfı oluşturuldu
    {

        private string name;
        private string surName;
        private DateTime birthdate;

        public string Name // Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için sınıftaki bilgiler ve get set metotları
        {
            get // Name özelliği get ve set metodları içerir, bu sayede name alanına güvenli ve kontrollü erişim sağlanır.
            {
                return name;
            }
            set // Name verilen değer name döner
            {
                name = value;
            }
        }

        public string SurName
        {
            get // SurName özelliği get ve set metodları içerir, bu sayede name alanına güvenli ve kontrollü erişim sağlanır.
            {
                return surName;
            }
            set // SurName verilen değer name döner
            {
                surName = value;
            }
        }

        public DateTime Birthdate
        {
            get // Birthdate özelliği get ve set metodları içerir, bu sayede name alanına güvenli ve kontrollü erişim sağlanır.
            {
                return birthdate;
            }
            set // Birthdate verilen değer name döner
            {
                birthdate = value;
            }
        }

        public Person(string ad, string soyad, DateTime dogumTarihi) // Main metodu içerisinden çağrıldığı zaman yeni nesne oluşur ve değer ataması yapılır.
        {
            Name = ad ?? "";
            SurName = soyad ?? "";
            Birthdate = dogumTarihi;
        }

       
    }

   
}

