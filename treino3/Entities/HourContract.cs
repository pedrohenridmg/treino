using System;

namespace treino3.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValouPerHours { get; set; }
        public int Hours { get; set; }

        public HourContract() { }

        public HourContract(DateTime date, double valouPerHours, int hours)
        {
            Date = date;
            ValouPerHours = valouPerHours;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValouPerHours;
        }
    }
}
