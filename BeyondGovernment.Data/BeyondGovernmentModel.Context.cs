﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeyondGovernment.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class BeyondGovernmentEntities : DbContext
    {
        public BeyondGovernmentEntities()
            : base("name=BeyondGovernmentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<string> USP_Account_Verification(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("USP_Account_Verification", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<string> USP_Account_InsertUpdate(string email, string password, string firstName, string lastName, string phone, string country, string pin, Nullable<bool> interestStayUpdate, Nullable<bool> interestHelpOthers, Nullable<bool> interestConnectExpert, Nullable<bool> expert, string expertiseDomain, string organizationType, string organizationName, string jobTitle)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var pinParameter = pin != null ?
                new ObjectParameter("Pin", pin) :
                new ObjectParameter("Pin", typeof(string));
    
            var interestStayUpdateParameter = interestStayUpdate.HasValue ?
                new ObjectParameter("InterestStayUpdate", interestStayUpdate) :
                new ObjectParameter("InterestStayUpdate", typeof(bool));
    
            var interestHelpOthersParameter = interestHelpOthers.HasValue ?
                new ObjectParameter("InterestHelpOthers", interestHelpOthers) :
                new ObjectParameter("InterestHelpOthers", typeof(bool));
    
            var interestConnectExpertParameter = interestConnectExpert.HasValue ?
                new ObjectParameter("InterestConnectExpert", interestConnectExpert) :
                new ObjectParameter("InterestConnectExpert", typeof(bool));
    
            var expertParameter = expert.HasValue ?
                new ObjectParameter("Expert", expert) :
                new ObjectParameter("Expert", typeof(bool));
    
            var expertiseDomainParameter = expertiseDomain != null ?
                new ObjectParameter("ExpertiseDomain", expertiseDomain) :
                new ObjectParameter("ExpertiseDomain", typeof(string));
    
            var organizationTypeParameter = organizationType != null ?
                new ObjectParameter("OrganizationType", organizationType) :
                new ObjectParameter("OrganizationType", typeof(string));
    
            var organizationNameParameter = organizationName != null ?
                new ObjectParameter("OrganizationName", organizationName) :
                new ObjectParameter("OrganizationName", typeof(string));
    
            var jobTitleParameter = jobTitle != null ?
                new ObjectParameter("JobTitle", jobTitle) :
                new ObjectParameter("JobTitle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("USP_Account_InsertUpdate", emailParameter, passwordParameter, firstNameParameter, lastNameParameter, phoneParameter, countryParameter, pinParameter, interestStayUpdateParameter, interestHelpOthersParameter, interestConnectExpertParameter, expertParameter, expertiseDomainParameter, organizationTypeParameter, organizationNameParameter, jobTitleParameter);
        }
    }
}
