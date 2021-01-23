using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Çağrı");
            ogrenciler.Add("Jale");
            ogrenciler.Add("Engin");
            ogrenciler.Add("Murat");
            ogrenciler.Add("Ali");
            Console.WriteLine(ogrenciler.Count);


            MyDictionary<string>ogrenciler1=new MyDictionary<string>();
            ogrenciler1.Add("Rana");
            ogrenciler1.Add("Ferhat");
            ogrenciler1.Add("Yunus");
            ogrenciler1.Add("Berkay");
            ogrenciler1.Add("Kenan");
            ogrenciler1.Add("Ahmet");
            Console.WriteLine(ogrenciler1.Count);

        }
    }
}
