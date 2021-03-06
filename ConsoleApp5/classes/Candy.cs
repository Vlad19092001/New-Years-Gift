﻿using ConsoleApp5.Enum;
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
        public Candy(string name, double weight, double sugar, double colories,
             TypeOfCandy typeOfCandy) : base(name, weight,  sugar, colories)
        {
            TypeOfCandy = typeOfCandy;
            
        }

        public override string TypeOfSweetness => "Candy";


        public override string ItemInfo => string.Format("{0}, weight: {1}, sugar: {2}, coloriess: {3}", Name, Colories, Vec, SugarPerUnit);
    }
}
