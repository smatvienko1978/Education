using System;
using NUnit.Framework;
using Video_Rental;

namespace VideoRentalTests
{
    [TestFixture]
    public class RentalTests
    {
        //[TestCase(2, 4, 8)]
        //[TestCase(2, 5, 10)]
        //[TestCase(0, 4, 0)]
        //[TestCase(2, 0, 0)]

        //public static void RentalCalculateDebt(double rentalPrice, int days, double expected)
        //{
        //    Movie movie = new Movie(rentalPrice: rentalPrice);
        //    Rental rental = new Rental(movie, days: days);
        //    Assert.AreEqual(rental.CalculateDebt(), expected);
        //}
        
        [Test]
        public static void Case1_RentalCalculateDebt()
        {
            int days = 6;

           // RegularMovie movie = new RegularMovie(name: "TestMovie");
            Rental rental = new Rental(Movie.Regular("Movie name"), days: days);

            Assert.AreEqual(rental.CalculateDebt(), rental.Movie.RentalPrice * days);
        }

        [Test]
        public static void Case_RentalAddRentalOneDay()
        {
            double rentalPrice = (double)MovieType.Regular; //2
            int days = 6;
           
            Rental rental = new Rental(Movie.Regular("Movie name"), days: days);
            rental.AddRentalDays();

            Assert.AreEqual(rental.CalculateDebt(), rentalPrice*(days+1));
        }

        [Test]
        public static void Case_RentalAddRentalManyDays()
        {
            double rentalPrice = (double)MovieType.Regular; //2
            int days = 6;
            int overDays = 2;

            Rental rental = new Rental(Movie.Regular("Movie name"), days: days);
            rental.AddRentalDays(overDays);

            Assert.AreEqual(rental.CalculateDebt(), rentalPrice * (days + overDays));
        }
        [Test]
        public static void Case_RentalSubstractRentalOneDay()
        {
            double rentalPrice = (double)MovieType.Regular; //2
            int days = 6;

            Rental rental = new Rental(Movie.Regular("Movie name"), days: days);
            rental.SubstractRentalDays();

            Assert.AreEqual(rental.CalculateDebt(), rentalPrice * (days - 1));
        }
        [Test]
        public static void Case_RentalSubstractRentalManyDays()
        {
            double rentalPrice = (double)MovieType.Regular; //2
            int days = 6;
            int overDays = 2;

            Rental rental = new Rental(Movie.Regular("Movie name"), days: days);
            rental.SubstractRentalDays(overDays);

            Assert.AreEqual(rental.CalculateDebt(), rentalPrice * (days - overDays));
        }

        [Test]
        public static void ExpectedRentalDaysExeption1()
        {
            try
            {
                Rental rental = new Rental(Movie.Regular("Movie name"), days: 6);

                rental.SubstractRentalDays(7);
                Assert.Fail();
            }
            catch (RentalDaysExeption e)
            {
                Assert.AreEqual(e.Days, -1);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        [Test]
        public static void ExpectedRentalDaysExeption2()
        {
            try
            {
                Rental rental = new Rental(Movie.Regular("Movie name"), days: -6);
                Assert.Fail();
            }
            catch (RentalDaysExeption e)
            {
                Assert.AreEqual(e.Days, -6);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public static void ChildernsMovie()
        {
            Rental rental = new Rental(Movie.Childrens("Movie name"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), (double)MovieType.Childrens * 6);
        }

        [Test]
        public static void NewReleaseMovie()
        {
            Rental rental = new Rental(Movie.NewRelease("Movie name"), days: 6);

            Assert.AreEqual(rental.CalculateDebt(), (double)MovieType.NewRelease * 6);
        }
    }
}