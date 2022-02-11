using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calisanlar C1 = new calisanlar();
            C1.isim = "Ömer";
            C1.soyad = "Gökdaş";

            C1.yazdir();
            Console.ReadLine();


    }
    }

    public class calisanlar
    {
        public string isim { get; set; }
        public string soyad { get; set; }

        public void yazdir()
        {
            Console.WriteLine("Çalışan Kişinin Adı: {0}, Soyadı: {1}",isim,soyad);

        }
    }
}
