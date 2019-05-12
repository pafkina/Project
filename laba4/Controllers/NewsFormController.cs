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

        public Boolean checkQuantityL(string abc)
        {
            if (abc.Length > 50) 
                return false;
            else
                return true;    
        }

        public Boolean checkQuantityN(string abc)
        {
            if (abc.Length > 50)
                return false;
            else
                return true;
        }

        public Boolean checkQuantityD(string abc)
        {
            if (abc.Length > 50)
                return false;
            else
                return true;
        }

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
                if (checkQuantityL(model.Locality) && checkQuantityN(model.Name) && checkQuantityD(model.Description))
                {
                    db.NewsModel.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else {
                    TempData["notice"] = "Text in the fields must not exceed 50 characters!";
                    return RedirectToAction("News", "NewsForm");
                }
                
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