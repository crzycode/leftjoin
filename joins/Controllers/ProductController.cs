using joins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace joins.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext db = new ProductDbContext();
        public JsonResult Index()
        {
            var data = (from p in db.products
                       join pm in db.ModelInfos on p.ModelId equals pm.ModelId
                       join pd in db.ProductDescriptions on p.ProId equals pd.ProductId
                       select new ProductInformation()
                       {
                           ProId = p.ProId,
                           ProName = p.ProName,
                           Price = p.Price,
                           ModelName = pm.ModelName,
                           ProdDetails=pd.ProdDetails
                       }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}