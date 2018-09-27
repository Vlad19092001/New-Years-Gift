using ConsoleApp5.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    public class Candy : Sweet
    {
        public TypeOfCandy TypeOfCandy;
        public Candy(string name, double weight, string typeOfSweetness, double sugar, double colories,
            string item_info, TypeOfCandy typeOfCandy) : base(name, weight, typeOfSweetness, sugar, colories, item_info)
        {
            TypeOfCandy = typeOfCandy;
            typeOfSweetness = "Candy";
        }
    }
}
