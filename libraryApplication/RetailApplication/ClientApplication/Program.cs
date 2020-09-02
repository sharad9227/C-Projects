using ClientApplication.ServiceReference3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ServiceReference3.Service1Client action1 = new ServiceReference3.Service1Client();
            String choice;
            //Menu for displaying
            Display();
            void Display()
            {
                Console.WriteLine("a. search for commodity");
                Console.WriteLine("b. enter new commodity");
                Console.WriteLine("c. show all laptops");
                Console.WriteLine("d. Enter exit to exit from application");
                choice = Console.ReadLine();
            }
            

           
            while (true)
            {
                switch (choice)
                {

                    case "a":
                        Console.WriteLine("Enter the feature number");

                        String feature = Console.ReadLine();
                        Console.WriteLine("Enter the type number");
                        int typeNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(action1.GetCommodityByTypeFeature(typeNo, feature));
                        Display();
                        break;
                    case "b":
                        Commodity commodity = new Commodity();
                        Console.WriteLine("Enter Commodity id");
                        commodity.idNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Commodity Name");
                        commodity.name = Console.ReadLine();
                        Console.WriteLine("Enter Commodity TypeNo");
                        commodity.type = Console.ReadLine();
                        Console.WriteLine("Enter Commodity Size");
                        commodity.size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Commodity price");
                        commodity.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Commodity Stock");
                        commodity.stock = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Commodity Brand");
                        commodity.brand = Console.ReadLine();
                        Console.WriteLine("Insert into "+action1.AddCommodity(commodity));
                        Display();
                        break;
                    case "c":
                        //  Object obj = action1.getAllLaptops();
                        foreach (ServiceReference3.Laptop l in action1.getAllLaptops())
                        {
                            Console.WriteLine(l.name);
                        }

                        Display();
                        break;

                    default:
                        Console.WriteLine("Not a valid choice.. Please enter a valid choice");
                        
                        break;
                }

              
            }
            Console.WriteLine("Do you want to quit y or n");
            if (Console.ReadLine().Equals("y"))
                Console.ReadKey();


        }
    }
}
