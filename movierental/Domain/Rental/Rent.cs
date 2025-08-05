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

        public Rent(double RentDebt, DateTime RentRentedDay, DateTime? RentReturningDay, int RentPlannedDaysOfRenting, double RentInterestRate)
        {


            this.RentID = Guid.NewGuid();
            this.RentDebt = RentDebt;
            this.RentRentedDay = RentRentedDay;
            this.RentReturningDay = RentReturningDay;
            this.RentPlannedDaysOfRenting = RentPlannedDaysOfRenting;
            this.RentInterestRate = RentInterestRate;
        }
    }

}
