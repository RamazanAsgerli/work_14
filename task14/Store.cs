using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    internal class Store
    {
        private static int _id;
        public static int Id { get; set; }
        public Product[] Products;

        public Store()
        {
            _id++;
            Id = _id;
            Products = new Product[0];
        }

        public void RemoveProductByNo(int no)
        {
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Array.Resize(ref Products, Products.Length - 1);
                    break;
                }
            }
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product GetProduct(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    return Products[i]; 
                }
            }
            return null;
            
        }

        public Product[] FilterProductBytype(string type)
        {
            Product[] searchType = new Product[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref searchType, searchType.Length + 1);
                    searchType[Products.Length - 1] = Products[i];
                }
            }
            return searchType;
        }

        public Product[] FilterProductByName(string name)
        {
            Product[] searchName = new Product[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref searchName, searchName.Length + 1);
                    searchName[Products.Length - 1] = Products[i];
                }
            }
            return searchName;
        }

        public void Sale(int no,Person person) 
        {
            Product product = null;
            if (person != null)
            {
                if (person.Cash >= product.Price)
                {
                    product.Count--;
                    person.Cash -= product.Price;

                }
                else { Console.WriteLine("pul catmir!!!!"); }
            }
        }
    }
}
