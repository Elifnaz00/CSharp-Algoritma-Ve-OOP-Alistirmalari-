using System;

namespace c__alıstırma_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calisanlar calısan = new Calisanlar("Ali" , "Demir" , 1);
            calısan.CalisanBilgiYazdır();
            calısan.YasAzalt();
            calısan.CalisanBilgiYazdır();
        }

        class Calisanlar
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age {
                get => Age;
                set
                {
                    if(value < 0) 
                    {
                        Console.WriteLine("yas en az 1 olabilir");
                        Age = 1;
                    }
                    else
                    {
                        Age= value;
                    }
                        
                }
            }

            public Calisanlar(string name, string surname, int age) 
            {
                this.Name = name;
                this.Surname = surname;
                this.Age = age; 

            }

            public void CalisanBilgiYazdır()
            {
                Console.WriteLine("Calisan adı:" + Name);
                Console.WriteLine("Calisan soyadı:" + Surname);
                Console.WriteLine("Calisan yası:" + Age);
            }



            public void YasAzalt()
            {
                this.Age = this.Age - 2;
            }
            
            
        }
    }
}
