using laba4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba4.Controllers
{
    public class NewsFormController : Controller
    {
        // GET: NewsForm
        [HttpGet]
        public ActionResult News(int id = 0)
        {
            return View(new NewsModel());
        }

        [HttpPost]
        public ActionResult News(NewsModel model)
        {
            using (DBModel db = new DBModel())
            {
                db.NewsModel.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }   
            
    
        }

        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<NewsModel> newsList = db.NewsModel.ToList<NewsModel>();
                return Json(new { data = newsList }, JsonRequestBehavior.AllowGet); 
            }
        }
        
    }
}