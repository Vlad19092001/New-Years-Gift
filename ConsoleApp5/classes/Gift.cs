using ConsoleApp5.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    public class Gift : IGift

    {
        public double Vec { get; }

        public int CountOfSweet { get; }

        public string NameGift { get; }

        public Gift(double vec, int countofsweet, string namegift)
        {
            Vec = vec;
            CountOfSweet = countofsweet;
            NameGift = namegift;

        }

        void IGift.AddSweet(Sweet sweet)
        {
            throw new NotImplementedException();
        }

        void IGift.RemoveSweet(Sweet sweet)
        {
            throw new NotImplementedException();
        }
    }
}
