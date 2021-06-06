using System;

namespace ekza
{
    class Program
    {
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            TMan man_1 = new TMan("Михайло", "Ч", 2011, 8, 25, 18);
            TMan man_2 = new TMan("Аріна", "Ж", 2010, 12, 8, 78);
           

            Print(man_1.date.ToString());
            Print(man_2.date.ToString());

            man_1.ToString();
            man_2.ToString();
                        
            Print(man_2.name);
            Print(man_2.sex);
            Print(man_2.age.ToString());
            Print(man_2.year.ToString());
            Print(man_2.month.ToString());
            man_2.Goroscope();
            man_2.Adulthood();


            Men man = new Men();
            man[0] = new TMan {name="Маріна", sex = "Ж", year = 1999, month = 10, day = 8, age=20 };
            man[1] = new Men { name = "Саша", sex = "Ч", year = 2003, month = 11, day = 8, age = 18 };
            man[2] = new Men { name = "Павло", sex = "Ч", year = 2004, month = 11, day = 8, age = 17 };
            man[3] = new Men { name = "Микита", sex = "Ч", year = 2005, month = 1, day = 8, age = 16 };
            man[4] = new Men { name = "Влад", sex = "Ч", year = 2006, month = 12, day = 8, age = 15 };
            man[5] = new Men { name = "Аліна", sex = "Ж", year = 2007, month = 4, day = 11, age = 14 };
            man[6] = new Men { name = "Іра", sex = "Ж", year = 2008, month = 5, day = 8, age = 13 };

            man[0].ToString();
            man[1].ToString();
            man[2].ToString();
            man[3].ToString();
            man[4].ToString();
            man[5].ToString();
            man[6].ToString();

            Print(man[6].name.ToString());
            Print(man[6].date.ToString());
            Print(man[6].age.ToString());
            Print(man[6].year.ToString());
            Print(man[6].month.ToString());
            man[6].Goroscope();
            man[6].Adulthood();

        }
    }
}
