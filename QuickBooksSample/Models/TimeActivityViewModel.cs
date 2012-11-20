using System;

namespace QuickBooksSample.Models
{
    public class TimeActivityViewModel
    {
        public string UserName { get; set; }
        public DateTime ActivityDate { get; set; }
        public string ClientName { get; set; }
        public string ServiceName { get; set; }
        public bool IsBillable { get; set; }
        public decimal HoursWorked { get; set; }
        public string Description { get; set; }
    }
}