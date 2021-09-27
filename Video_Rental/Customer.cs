using System;
using System.Collections.Generic;

namespace Video_Rental
{
    public class Customer
    {
        private string name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name { get => name; }
        public List<Rental> Rentals { get => rentals; }

        public double CalculateDebt()
        {
           double totalAmount =0;

            foreach (var rental in rentals)
                totalAmount += rental.Days * rental.Movie.RentalPrice;

            return totalAmount;
        }
    }
}