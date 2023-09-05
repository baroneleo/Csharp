using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Cap10.Exercise4
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
