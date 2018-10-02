using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShopping.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        //顯示幕前的購物車項目
        public ActionResult Index()
        {
            return View();
        }


        //加入產品項目到購物車，如果沒有傳入Amount，參數則預設購買數量為1
        //因為知道要透過AJAX呼叫這個Action，所以可以先標示[HttpPost]屬性
        [HttpPost]
        public ActionResult AddtoCart(int ProductId, int Amount = 1)
        {
            return View();
        }

        //移除購物車項目
        //因為知道要透過AJAX呼叫這個Action，所以可以先標示[HttpPost]屬性
        [HttpPost]
        public ActionResult Remove (int ProductId)
        {
            return View();
        }

        //更新購物車中特定項目的購買數量
        //因為知道要透過AJAX呼叫這個Action，所以可以先標示[HttpPost]屬性
        [HttpPost]
        public ActionResult UpdateAmount(int ProductId)
        {
            return View();
        }
        //TEST_HA
        //Test From  GitHub
        //Test From local
        //TestBranch2
    }
}
