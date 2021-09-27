using System;

namespace Video_Rental
{
    public class Rental
    {
        private Movie movie;
        private int days;
        public Movie Movie { get => movie; }
        public int Days 
        { 
            get => this.days;
            private set 
            {
                if (value < 0)
                    throw new RentalDaysExeption(value);
                this.days = value;
            }
        }
        public Rental(Movie movie, int days)
        {
            this.movie = movie;
            this.Days = days;
        }

        public double CalculateDebt()
        {
            return Days * movie.RentalPrice;
        }

        public void AddRentalDays(int overDays = 1)
        {
            this.Days+=overDays;
        }

        public void SubstractRentalDays(int overDays=1)
        {
            this.Days-=overDays;
        }
    }
}