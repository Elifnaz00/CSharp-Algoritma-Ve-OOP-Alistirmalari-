using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Class1
    {
        public string marka;
        private string model;
        private int en;
        private int boy;

        public string Model { get => model; set => model = value; }
        public int En { get => en; set => en = value; }

        public int getBoy()
        {
            return this.boy;
        }
    }
}
