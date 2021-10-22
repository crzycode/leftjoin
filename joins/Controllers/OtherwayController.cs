using joins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace joins.Controllers
{
    public class OtherwayController : Controller
    {
        // GET: Otherway
        ProductDbContext db = new ProductDbContext();
        public JsonResult Index()
        {
            var data = db.products.Join(db.ModelInfos, p => p.ModelId, m => m.ModelId, (p, m) => new { p, m })
                .Join(db.ProductDescriptions, p => p.p.ProId, pd => pd.ProductId, (p, pd) => new { p, pd }
                )
                .Select(res => new ProductInformation()
                {
                    ProId = res.p.p.ProId,
                    ProName = res.p.p.ProName,
                    Price = res.p.p.Price,
                    ModelName = res.p.m.ModelName,
                    ProdDetails = res.pd.ProdDetails

                }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}