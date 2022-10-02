using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2_Entity_Framework
{
    public class Question3
    {
        public static void execute()
        {
            using (var db = new NorthwindEntities1())
            {

                Console.WriteLine("enter Product Name");
                string product_name = Console.ReadLine();
                Console.WriteLine("enter Month");
                string month = Console.ReadLine();
                Console.WriteLine("enter Year");
                string year = Console.ReadLine();

                var product = db.usp_Monthly_Report(product_name,month,year);

                Console.WriteLine($"Product Name \t Month\t Total Order Price");
                foreach (var item in product)
                {
                    Console.WriteLine($"{item.ProductName}\t\t{item.Month}\t{item.TotalOrderPrice}");

                }
            //    Console.WriteLine($"{product.ProductName}\t\t{.Month}\t{item.total_order_price}");

            }
        }
    }
}
