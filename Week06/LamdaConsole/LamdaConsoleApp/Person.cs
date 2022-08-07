using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaConsoleApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


        int test = 0;
        public int Example { get => test; set => test = value; }

        public override string ToString() => $"{Name} - {City} - {Age}"; // Inline Method
    }
}
