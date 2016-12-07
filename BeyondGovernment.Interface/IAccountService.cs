using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondGovernment.Entities;

namespace BeyondGovernment.Interface
{
    public interface IAccountService
    {
       
        IEnumerable<string> SignUp(string email,string password, string firstName, string lastName, string phone, string country, string pin, bool interestStayUpdate, bool interestHelpOthers, bool interestConnectExpert, bool expert, string expertiseDomain, string organizationType, string organizationName, string jobTitle);
        IEnumerable<string> VerifyAccount(string email, string password);
      //  IEnumerable<string> ChangePassword(string email, string oldPassword,string newPassword,string name);
        //IEnumerable<string> ForgotPassword(string email);
     
    }
}
