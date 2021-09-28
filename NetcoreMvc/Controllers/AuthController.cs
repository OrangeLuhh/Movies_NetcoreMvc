using BasicASP.NETMvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace BasicASP.NETMvc.Controllers
{
    public class AuthController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user == null || !"admin".Equals(user.UserName) || !"admin".Equals(user.PassWord))
            {
                ViewBag.Error = "UserName and PassWord is admin";
                return View();
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };

            var userPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, "UserAuth"));

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, new AuthenticationProperties
            {
                ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                IsPersistent = false,
                AllowRefresh = false
            });

            CreateAuthCookie(user.UserName);
            AddValusToSession(user.UserName);
            return RedirectToAction("Page");
        }


        //basic points 14 please make sure this action should be authed.
        [Authorize]
        public ActionResult Page()
        {
            // # homework 1 -- redirect to movies/index
            return RedirectToRoute(new {Controller = "movies", Action = "index"});
        }

        private void CreateAuthCookie(string userName)
        {
            //basic points 16 please add param into Cookie 
            // use cookie auth
            CookieOptions options = new CookieOptions();
            // 设置过期时间
            options.Expires = DateTime.Now.AddDays(1);
            HttpContext.Response.Cookies.Append("CookieUserName", userName, options);
        }

        private void AddValusToSession(string userName)
        {
            //basic points 17 Add param into Session and Seeeion key is "userName"
            HttpContext.Session.SetString("userName", userName);
        }
    }
}