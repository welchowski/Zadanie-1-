using System;
using System.Collections.Generic;
using System.Text;

namespace ekza
{
    class TMan
    {
        public DateTime date { get; }

        public int age { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        string adult_hood { get; set; }

        public TMan(string name, string sex, int year, int month, int day, int age)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.sex = sex;
            this.name = name;
            date = new DateTime(year, month, day);
            this.age = DateTime.Now.Year - date.Year;
            this.age = age;

        }


       
    
    public TMan() { }


    public string Adulthood()
        {

            if (age >= 16 && age <= 21)
            {
                if (age >= 17 && age <= 21 && sex == "Ч")
                {
                    adult_hood = "юнак";
                    Print("юнак");

                }

                else if (age >= 16 && age <= 20 && sex == "Ж")
                {
                    adult_hood = "юначка";
                    Print("юначка");
                }
            }

            else if (age > 21 && sex == "Ч" || age > 20 && sex == "Ж")
            {
                adult_hood = "дорослий";
                Print("дорослий");
            }
            else if (age < 16 && sex == "Ч" || age <= 15 && sex == "Ж")
            {
                adult_hood = "дитина";
                Print("дитина");
            }
            return "";
            
        }
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public string Goroscope()
        {
            string[] zodiaki = new string[] {
               "Козеріг",
                "Водолій",
                "Риби",
                "Овен",
                "Телець",
                "Близнюки",
                "Рак",
                "Лев",
                "Діва",
                "Ваги",
                "Скорпіон",
                "Стрілец"
               };

            switch (month)
            {
                case 1:
                    if (day >= 21)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[1]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[0]);
                    break;
                case 2:
                    if (day >= 19)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[2]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[1]);
                    break;
                case 3:
                    if (day >= 21)
                        Console.WriteLine("Знак зодіаку: "  + zodiaki[3]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[2]);
                    break;
                case 4:
                    if (day >= 21)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[4]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[3]);
                    break;
                case 5:
                    if (day >= 22)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[5]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[4]);
                    break;
                case 6:
                    if (day >= 22)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[6]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[5]);
                    break;
                case 7:
                    if (day >= 23)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[7]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[6]);
                    break;
                case 8:
                    if (day >= 24)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[8]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[7]);
                    break;
                case 9:
                    if (day >= 24)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[9]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[8]);
                    break;
                case 10:
                    if (day >= 24)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[10]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[9]);
                    break;
                case 11:
                    if (day >= 23)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[11]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[10]);
                    break;
                case 12:
                    if (day >= 22)
                        Console.WriteLine("Знак зодіаку: " + zodiaki[0]);
                    else Console.WriteLine("Знак зодіаку: " + zodiaki[9]);
                    break;
                    
            }
            return "";
        }


        public override string ToString()
        {            
            Console.Write($"\nІм'я: {name}\nВік: {age}  \nСтать: {sex} \nДорослість: ");
            Console.Write( Adulthood());
            Console.WriteLine( Goroscope());
            return "";

        }

    }
}








