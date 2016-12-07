using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondGovernment.Entities;
using BeyondGovernment.Interface;
using BeyondGovernment.Data;
using System.Data.Entity;
using BeyondGovernment.Data;

namespace BeyondGovernment.Service
{
    public class AccountService : IAccountService
    {
        #region Variable
        private readonly IDbContextFactory _dbContext;
        #endregion

        #region Constructor
        public AccountService(IDbContextFactory dbContextFactory)
       {
        _dbContext = dbContextFactory;
       }
       #endregion

       #region Action

        public IEnumerable<string> SignUp(string email,string password, string firstName, string lastName, string phone, string country, string pin, bool interestStayUpdate, bool interestHelpOthers, bool interestConnectExpert, bool expert, string expertiseDomain, string organizationType, string organizationName, string jobTitle)
       {
           using (var db = _dbContext.GetDbContext())
           {
              return db.USP_Account_InsertUpdate(email, password, firstName, lastName, phone,  country,  pin,  interestStayUpdate,  interestHelpOthers,  interestConnectExpert,  expert,  expertiseDomain,  organizationType,  organizationName,  jobTitle).ToList();
           }
        }

      
       public IEnumerable<string> VerifyAccount(string email, string password)
       {
           using (var db = _dbContext.GetDbContext())
           {
               return db.USP_Account_Verification(email, password).ToList();
           }
       }


       //public IEnumerable<string> ChangePassword(string email, string oldPassword, string newPassword, string name)
       //{
       //    using (var db = _dbContext.GetDbContext())
       //    {
       //        return db.USP_Account_ChangePassword(email, oldPassword, newPassword, name).ToList();
       //    }
       //}

       //public IEnumerable<string> ForgotPassword(string email)
       //{
       //    using (var db = _dbContext.GetDbContext())
       //    {
       //       return db.USP_ForgetPassword_Select(email).ToList();
       //    }

       // }

    

       #endregion

        #region Helper

        #endregion
    }
}
