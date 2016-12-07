using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BeyondGovernment.Interface;
using BeyondGovernment.Web.Helpers;
using BeyondGovernment.Entities;
namespace BeyondGovernment.Web.Controllers
{
    public class AccountController : ApiController
    {
        #region Vairiables
        private readonly IAccountService _accountService=null;
        #endregion

        #region Constructor
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        #endregion


        [HttpPost]
        [ActionName("SignUp")]
        public HttpResponseMessage SignUp([FromBody]AccountEntity account)
        {
            IEnumerable<string> result = _accountService.SignUp(account.email, account.password, account.firstName, account.lastName, account.phone, account.country, account.pin, account.interestStayUpdate, account.interestHelpOthers, account.interestConnectExpert, account.expert, account.expertiseDomain, account.organizationType, account.organizationName, account.jobTitle);
            if (result != null)
                return Request.CreateResponse(HttpStatusCode.OK, result);

            throw new ApiDataException(1001, "Error Reported", HttpStatusCode.NotFound);

            throw new ApiException() { ErrorCode = (int)HttpStatusCode.BadRequest, ErrorDescription = "Bad Request..." };

        }


        [HttpGet]
        public HttpResponseMessage VerifyAccount(string email, string password)
        {
            IEnumerable<string> result = _accountService.VerifyAccount(email, password);
            if (result != null)
                return Request.CreateResponse(HttpStatusCode.OK, result);

            throw new ApiDataException(1001, "Error Reported", HttpStatusCode.NotFound);
            throw new ApiException() { ErrorCode = (int)HttpStatusCode.BadRequest, ErrorDescription = "Bad Request..." };
        }

        //[HttpGet]
        //public HttpResponseMessage ChangePassword(string email, string oldpassword, string newpassword, string name)
        //{
        //    IEnumerable<string> result = _accountService.ChangePassword(email, oldpassword, newpassword, name);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
        //    return response;
        //}

        //[HttpGet]
        ////[Route("api/AccountController/ForgotPassword")]
        //public HttpResponseMessage ForgotPassword(string email)
        //{
        //    IEnumerable<string> result = _accountService.ForgotPassword(email);
        // //   HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
        //    Utility.sendEmailViaWebApi(result.ToString());
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Mail Sent");
        //    return response;
        //}


        [HttpGet]
        public string Test()
        {
            return "Hello";
        }
    }
}