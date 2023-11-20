using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace C__ALISTIRMA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            kullanıcıListesi.Add(new Kullanıcılar()
            {
                Name = "Ali",
                Surname = "Demir",
                Age = 20
            });
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Name = "Ayşe";
            kullanıcı1.Surname = "Yıldız";
            kullanıcı1.Age = 30;

            Kullanıcılar kullanıcılar2 = new Kullanıcılar();
            kullanıcılar2.Name = "Ayşe";
            kullanıcı1.Surname = "Yıldız";
            kullanıcı1.Age = 30;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcılar2);

            ArrayList list= new ArrayList();
            list.Add("Ayse");
            list.Add(2);

            string[] renkler = { "kırmızı", "sarı", "yesil" };
            List<int> sayilar = new List<int>() { 2, 7, 4, 10, 6, }; 

            list.AddRange(renkler);
            list.AddRange(sayilar);
            
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            sayilar.Sort();
            foreach(var item in sayilar)
            { Console.WriteLine(item); }


           

        }
        public class Kullanıcılar
        {
            //private string name;
            //private string surname;
            //private int age;


            public string Name { get; set; }

            public string Surname { get; set; }

            public int Age { get; set; }
        }
    }
}