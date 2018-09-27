using ConsoleApp5.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    public abstract class Sweet : ISweetness
    {
        public string TypeOfSweetness { get; }

        public double Vec { get; }

        public string ItemInfo { get; }

        public double SugarPerUnit { get; }

        public string Name { get; }

        public double Colories { get; }

        public Sweet(string name, double weight, string typeOfSweetness, double sugar, double colories,
            string item_info)
        {
            Name = name;
            Colories = colories;
            Vec = weight;
            TypeOfSweetness = typeOfSweetness;
            SugarPerUnit = sugar;
            ItemInfo = item_info;
        }
    }
    
}
