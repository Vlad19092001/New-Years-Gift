using ConsoleApp5.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy Konfetka = new Candy( "Барбариски", 10,   50,  100,  Enum.TypeOfCandy.Caramel);
            Candy Konfetka1 = new Candy( "Бешенная пчелка", 15,   60, 250,  Enum.TypeOfCandy.Dgele);
            Candy Konfetka2 = new Candy("Ириска",  20,   75, 300,  Enum.TypeOfCandy.Iric);
            Candy Konfetka3 = new Candy( "Чупа-чупс",  30,   65,  150, Enum.TypeOfCandy.Caramel);
            Candy Konfetka4 = new Candy( "Коровка",  25,    65,  220,  Enum.TypeOfCandy.Milk);
            Candy Konfetka5 = new Candy("Грильяж",  20,  35, 350,  Enum.TypeOfCandy.Grillage);
            Candy Konfetka6 = new Candy( "Свежая капля",  13,   40,  70,  Enum.TypeOfCandy.Milk);
            Chocolate chocolate = new Chocolate( "Аленка",  100,   60,  540, Enum.TypeOfChocolate.Milk);

            Console.WriteLine(Konfetka.ItemInfo);
            Console.WriteLine(Konfetka1.ItemInfo);
            Console.WriteLine(Konfetka2.ItemInfo);
            Console.WriteLine(Konfetka3.ItemInfo);
            Console.WriteLine(Konfetka4.ItemInfo);
            Console.WriteLine(Konfetka5.ItemInfo);
            Console.WriteLine(Konfetka6.ItemInfo);
            Console.WriteLine(chocolate.ItemInfo);
            Console.ReadKey();

            Console.ReadKey();

        }
    }
}
