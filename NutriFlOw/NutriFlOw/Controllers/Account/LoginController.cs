using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BootstrapMvcSample.Controllers;
using NutriFlOw.Domain.Services;
using NutriFlOw.Models.Account;

namespace NutriFlOw.Controllers.Account
{
    public class LoginController : BootstrapBaseController
    {
        private readonly IReadOnlyRepository _readOnlyRepository;
        private readonly IWriteOnlyRepository _writeOnlyRepository;

        public LoginController(IReadOnlyRepository readOnlyRepository, IWriteOnlyRepository writeOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
            _writeOnlyRepository = writeOnlyRepository;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginModel());
        }

        //[HttpPost]
        //public ActionResult LogIn(LoginModel model)
        //{
        //    var passwordEncripted = EncriptacionMD5.Encriptar(model.Password);
        //    var result = _readOnlyRepository.First<Account>(x => x.EMail == model.EMail && x.Password==passwordEncripted);

        //    if (result != null)
        //    {
        //        if (result.IsBlocked)
        //        {
        //            Error(
        //                "Your account has been blocked by the Admin due to violation of the terms of usage of this site!");
        //            return View();
        //        }

        //        if (result.IsArchived)
        //        {
        //            Error("Your account is inactive, to activate it again send an e-mail to support@minidropbox.com");
        //            return View();
        //        }
                
        //        var roles = result.IsAdmin
        //            ? new List<string>(new[] {"Admin"})
        //            : new List<string>(new[] {"User"});

        //        FormsAuthentication.SetAuthCookie(model.EMail, model.RememberMe);
        //        SetAuthenticationCookie(model.EMail, roles);
             
            
        //        if (result.IsAdmin)
        //        {
        //            return RedirectToAction("RegisteredUsersList", "RegisteredUsersList");
        //        }

        //        Session["ActualPath"] = string.Empty;
        //        Session["ActualFolder"] = string.Empty;
        //        return RedirectToAction("ListAllContent", "Disk");
        //    }
                
           
        //    Error("E-Mail or Password is incorrect!!!");
        //    return View();
        //}

        public ActionResult SignUp()
        {
            return null;
            //return RedirectToAction("AccountSignUp", "AccountSignUp", new { token = 0 });
        }

        public ActionResult PasswordRecovery()
        {
            return null;
            //return RedirectToAction("PasswordRecovery", "PasswordRecovery");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return null;
            //return RedirectToAction("LogIn", "Account");
        }
        

    }
}
