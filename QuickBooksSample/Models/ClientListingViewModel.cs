using System.Collections.Generic;

namespace QuickBooksSample.Models
{
    public class ClientListingViewModel
    {
        public string AccountName { get; set; }
        public List<string> ClientList { get; set; }
        public List<string> ServicesList { get; set; }
    }
}