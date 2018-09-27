using ConsoleApp5.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{

    public class Chocolate : Sweet
    {
        public TypeOfChocolate TypeOfChocolate;
        public Chocolate(string name, double weight, string typeOfSweetness, double sugar, double colories,
            string item_info, TypeOfChocolate typeOfChocolate) : base(name, weight, typeOfSweetness, sugar, colories, item_info)
        {
            TypeOfChocolate = typeOfChocolate;
            typeOfSweetness = "Chocolate";
        }
    }
}
