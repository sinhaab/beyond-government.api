
namespace BeyondGovernment.Entities
{
    public class AccountEntity
    {
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string pin { get; set; }
        public bool interestStayUpdate { get; set; }
        public bool interestHelpOthers { get; set; }
        public bool interestConnectExpert { get; set; }
        public bool expert { get; set; }
        public string expertiseDomain { get; set; }
        public string organizationType { get; set; }
        public string organizationName { get; set; }
        public string jobTitle { get; set; }
     }
}
