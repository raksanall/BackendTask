using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication
{
    public class Flight
    {
        public string Name { get; set; }
        public DateOnly Date {  get; set; }
        public TimeOnly Time { get; set; }
        public string DestinationPoint { get;set; }
        public int Seats { get; set; }

        private static int id = 1;
        public int Id { get; set; }



        public Flight(string name,DateOnly date,TimeOnly time,string destinationPoint,int seats)
        {
            Id = id++;
            Name = name;
            Date = date;
            Time = time;
            DestinationPoint = destinationPoint;
            Seats = seats;

        }
    }
}
