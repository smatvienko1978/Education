using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Video_Rental;

namespace VideoRentalTests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public static void CustomerCalculateDebt()
        {
            Customer customer = new Customer("Alex");
            customer.Rentals.Add(new Rental(Movie.Regular("Movie 1"), 6));
            customer.Rentals.Add(new Rental(Movie.NewRelease("Movie 2"), 2));

            Assert.AreEqual(customer.CalculateDebt(), 12 + 6);


        }
    }
}
