using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    internal class Product
    {
        private static int _no;
        public  int No;
        public string Name { get; set; }

        private double _price;

        public double Price {  get; set; }
        
            
        

        public string Type { get; set; }
        public int Count { get; set; }

        public Product(string name,double price,string type,int count)
        {
            _no++;
            No = _no;
            Name = name;
            Price = price;
            Type = type;
            Count = count;


        }
        public override string ToString()
        {
            return $"No: {No},Adi: {Name},Qiymet: {Price},Novu: {Type},Sayi: {Count}";
        }
    }
}
