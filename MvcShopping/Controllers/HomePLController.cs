using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    public class HomePLController : Controller
    {
        // GET: HomePL
        //首頁:顯示商品別清單
        public ActionResult Index()
        {
            var data = new List<ProductCategory>()
            {
                new ProductCategory() {Id=1,Name="文具" },
                new ProductCategory() {Id=2,Name="禮品" },
                new ProductCategory() {Id=3,Name="書籍" },
                new ProductCategory() {Id=4,Name="美勞用具" }
            };
            return View(data);
        }

        //商品列表
        public ActionResult ProductList(int id)
        {
            var productCategory = new ProductCategory() { Id = id, Name = "類別" + id };

            var data = new List<Product>()
            {
                new Product() {Id=1,ProductCategory=productCategory,Name="原子筆",Description="N/A",Price=30,PublishOn=DateTime.Now,Color=System.Drawing.Color.Black },
                new Product() {Id=1,ProductCategory=productCategory,Name="鉛筆",Description="N/A",Price=5,PublishOn=DateTime.Now,Color=System.Drawing.Color.Black }
            };
            return View(data);
        }

        //商品明細
        public ActionResult ProductDetail(int id)
        {
            var productCategory = new ProductCategory() { Id = 1, Name = "文具" };
            var data = new Product() { Id = id, ProductCategory = productCategory, Name = "商品" + id, Description = "N/A", Price = 30, PublishOn = DateTime.Now, Color = System.Drawing.Color.Black };
            
            return View(data);
        }
    }
}