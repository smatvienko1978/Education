using System;
using System.Runtime.Serialization;

namespace Video_Rental
{
    [Serializable]
    public class RentalDaysExeption : Exception
    {
   
        public RentalDaysExeption(int days)
        {
            this.Days = days;
        }
        
        public object Days { get; private set; }
    }
}