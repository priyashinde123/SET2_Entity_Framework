using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2_Entity_Framework
{
    public class Question1
    {
        public static void execute()
        {
            using (var db= new NorthwindEntities1() )
            {
                Console.WriteLine("enter FromDate");
                DateTime from_date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
                Console.WriteLine("enter ToDate");
                DateTime to_date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

                var order = db.usp_TotalOrderCount_(from_date, to_date);
                Console.WriteLine("EmployeeName\t OrderId\t\tTotalOrderPrice");
                foreach (var item in order)
                {
                    Console.WriteLine($"{item.Empname}\t{item.OderId}\t\t{item.TotalCount}");
                }
            }
        }
    }
}
