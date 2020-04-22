using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderEntry_Bundle.Models;
namespace OrderEntry_Bundle.Areas.Accountant.Controllers
{

    // Muhasebe => Muhasebe sadece toplam sipariş ve toplam geliri görüntülesin.
    // İnsan Kaynakları => sadece çalışanları görsün
    // Bilgi İşlem (IT) => Bütün tabloları görüntülesin
    // Satış Pazarlama => ÜRünleri görüntülesin ve siparişleri
    // Yönetim => herşeyi görüntülesin.
    public class OrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Accountant/Order
        public ActionResult Orders(string p)
        {
            var values = from d in db.Orders select d;
            
            List<Order> orders = db.Orders.ToList();
            return View(orders);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return RedirectToAction("Orders");



        }
        public ActionResult Delete(int id)
        {
            var deleted = db.Orders.Find(id);
            db.Orders.Remove(deleted);
            db.SaveChanges();
            return RedirectToAction("Orders");

        }
    }
}