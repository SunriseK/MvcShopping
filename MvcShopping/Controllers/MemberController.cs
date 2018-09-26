using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcShopping.Models;
using System.Web.Security;

namespace MvcShopping.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        //顯示會員註冊頁面
        public ActionResult Register()
        {
            return View();
        }

        //寫入會員資料
        //因為在View裡面移除了RegisterOn與AuthCode欄位，所以在接收註冊資料的另一個Register動作方法的模型繫結參數加入[Bind]屬性，
        //排除掉這兩個欄位的模型繫結。
        [HttpPost]
        public ActionResult Register([Bind(Exclude = "RegisterOn,AuthCode")] Member member) 
        {
            return View();
        }

        //顯示會員登入頁面
        public ActionResult Login(string returnUrl)
        {
            return View();
        }

        //執行會員登入 :此處使用了ASP.NET標準的表單驗證功能
        [HttpPost]
        public ActionResult Login(string email, string password, string returnUrl)
        {
            if (ValidateUser(email, password))
            {
                FormsAuthentication.SetAuthCookie(email, false);

                if (string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "HomePL");
                } else
                {
                    return Redirect(returnUrl);
                }
            }
            //??
            ModelState.AddModelError("", "您輸入的帳號或密碼錯誤");
            return View();
        }

        private bool ValidateUser(string email, string password)
        {
            //??
            throw new NotImplementedException();
        }

        //執行會員登出
        public ActionResult Logout()
        {
            //清楚表單驗證的Cookies
            FormsAuthentication.SignOut();

            //清除所有曾經寫入過的session資料
            Session.Clear();

            return RedirectToAction("Index", "Home");
        }

    }
}