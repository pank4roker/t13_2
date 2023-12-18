using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task1
                /*Edition edition = new Edition("Spirited away", "Хаяо Миядзаки",2001);
                WriteLine($"{edition.ToString()}");
                Edition edition1 = new Edition();
                edition1.Title = "";
                edition1.Authname = "";
                edition1.Year = 1400;
                WriteLine($"{edition1.ToString()}");
                Write("Enter title: ");
                string title = ReadLine();
                Write("Enter authname: ");
                string authname = ReadLine();
                Write("Enter the year of publishing: ");
                int year = Convert.ToInt32(ReadLine());
                Edition edition2 = new Edition(title,authname,year);
                WriteLine($"\n{edition2.ToString()}");
                Write("What date do you want to change the year to?\nDate: ");
                int date = Convert.ToInt32(ReadLine());
                Write($"Changed year: {edition2.Change(date)}");
                Write($"{edition2.Compare()}");*/

                //Task2
                /*Software software = new Software("Kaspersky AS", "Eugene", "200");
                software.Output();
                Software software3 = new Software();
                software3.Name = "";
                software3.Producer = "";
                software3.Usage = "0";
                software3.Output();
                Software software1 = new Software();
                Write("Enter name: ");
                string name = ReadLine();
                Write("Enter producer: ");
                string producer = ReadLine();
                Write("Enter the price: ");
                string usage = ReadLine();
                Software software2 = new Software(name,producer,usage);
                WriteLine();
                software2.Output();*/

                //Task3
                Banknote banknote = new Banknote("USD", 10, 500);
                WriteLine($"{banknote.ToString()}");
                Banknote banknote1 = new Banknote();
                banknote1.Name = "";
                banknote1.Denomination = 0;
                banknote1.Quantity = 0;
                WriteLine($"{banknote1.ToString()}");
                Write("Enter name: ");
                string name = ReadLine();
                Write("Enter denomination: ");
                int denomination = Convert.ToInt32(ReadLine());
                Write("Enter the quantity: ");
                int quantity = Convert.ToInt32(ReadLine());
                Banknote banknote3 = new Banknote(name, denomination, quantity);
                WriteLine();
                WriteLine($"{banknote3.ToString()}");
                Write("To what number do you want to change the number of bills??\nNumber: ");
                int n = Convert.ToInt32(ReadLine());
                WriteLine($"\nChange: {banknote3.Change(n)}");







            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
