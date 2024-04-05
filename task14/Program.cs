namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ramazan", 20, 500);
            Store store = new Store();
            bool check = true;
            do
            {
                Console.WriteLine("1.Mehsul elave et");
                Console.WriteLine("2.Mehsul sil");
                Console.WriteLine("3.Mehsula bax");
                Console.WriteLine("4.Type'a gore mehsullara bax");
                Console.WriteLine("5.Ada gore mehsullara bax");
                Console.WriteLine("0.Proqramdan cix");

                string a = Console.ReadLine();
                    
                switch (a)
                {
                    case "1":
                        Console.WriteLine("Ad:");
                        string name = Console.ReadLine();
                        double price;
                        do
                        {
                            Console.WriteLine("Qiymeti: ");
                        }while(!double.TryParse(Console.ReadLine(), out price));
                        Console.WriteLine("Mehsulun novu:");
                        string type = Console.ReadLine();
                        int count;
                        do
                        {
                            Console.WriteLine("Sayi daxil edin:");
                        }while(!int.TryParse(Console.ReadLine(),out count));
                        Product product1 = new Product(name,price,type,count);
                        store.AddProduct(product1);
                        break;
                    case "2":
                        int no1;
                        do
                        {
                        Console.WriteLine("Silmek ucun No daxil et");
                        } while(!int.TryParse(Console.ReadLine(),out no1));
                        store.RemoveProductByNo(no1);
                        break;
                    case "3":
                        int no;
                        do
                        {
                           Console.WriteLine("No daxil edin:");
                        } while (!int.TryParse(Console.ReadLine(), out no));
                        Product searchNo = store.GetProduct(no);
                        Console.WriteLine(searchNo);

                        break;
                    case "4":
                        Console.WriteLine("Type daxil et:");
                        string type1 = Console.ReadLine();

                        Product[] filteredType = store.FilterProductBytype(type1);
                        for(int i = 0; i < filteredType.Length; i++)
                        {
                            Console.WriteLine(filteredType[i]);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Adi:");
                        string name1 = Console.ReadLine();
                       Product[] searchname = store.FilterProductByName(name1);
                        for(int i = 0; i < searchname.Length; i++)
                        {
                            Console.WriteLine(searchname[i]);
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun daxil edin!!!!");
                        break;
                }

            }while (check);
        }
    }
}
