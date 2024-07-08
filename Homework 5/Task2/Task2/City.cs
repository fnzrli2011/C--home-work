using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     class City
    {
        public int Erazi {get; set;}
        public string Name { get; set; }
        public int ehali {get; set;}
        public City(string name,int erazi)
        {
        Erazi = erazi;
        Name = name;
        }
    }
}
