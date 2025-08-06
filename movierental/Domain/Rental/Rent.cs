using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rental
{
   public class Rent
    {
        public Guid RentID {  get; private set; }
        public double RentDebt { get; private set; }
        public DateTime RentRentedDay { get; private set; }
        public DateTime? RentReturningDay { get; private set; }

        public int RentPlannedDaysOfRenting { get; private set; }
        public double RentInterestRate { get; private set; } = 0;

        public Rent(double rentDebt, DateTime rentRentedDay, DateTime? rentReturningDay, int rentPlannedDaysOfRenting, double rentInterestRate)
        {


            RentID = Guid.NewGuid();
            RentDebt = rentDebt;
            RentRentedDay = rentRentedDay;
            RentReturningDay = rentReturningDay;
            RentPlannedDaysOfRenting = rentPlannedDaysOfRenting;
            RentInterestRate = rentInterestRate;
        }
    }

}
