using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    internal class Person
    {
        private static int _id;
        public string Fullname;
        private sbyte _age;

        public int Id;
        public sbyte Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 125)
                {
                    value = _age;
                }
            }
        }

        public double Cash { get; set; }

        public Person(string fullname,sbyte age,double cash)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Age = age;
            Cash = cash;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Adi: {Fullname}, Yas: {Age},Mebleg : {Cash}";
        }
    }
}
