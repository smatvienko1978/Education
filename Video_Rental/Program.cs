using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Rental;

namespace VideoRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Alex");
            customer.Rentals.Add(new Rental(Movie.Regular("Movie 1"), 6));
            customer.Rentals.Add(new Rental(Movie.NewRelease("Movie 2"), 2));

            Console.WriteLine("Клиент {0} должен {1:C}", customer.Name, customer.CalculateDebt());

            ReportManager.CreateSimpleReport(@"d:\\test\video_rental.txt", customer);
            Console.ReadKey();
        }
    }
}
