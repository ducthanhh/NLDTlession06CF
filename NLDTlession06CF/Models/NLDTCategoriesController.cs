using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLDTlession06CF.Models
{
   
    public class NLDTCategoriesController : Controller
    {
        private static NLDTBookStore nldtDb;
        public NLDTCategoriesController() 
        {
            nldtDb = new NLDTBookStore();
        }
        // GET: NLDTCategories
        public ActionResult NLDTIndex()
        {
            /* 
             * * khoi tao DbContext
             * * EF se tim thong tin ket noi trong file machinee.config cua .NET Feamework tren may 
             * * sau do tao csdl
             */
            // NLDTBookStore nldtDb = new NLDTBookStore();
            var NLDTCategories = nldtDb.NLDTCategories.ToList();
            return View(NLDTCategories);
        }
         public ActionResult NLDTCreate()
        {
            var NLDTCategory = new NLDTCategory();
            return View(NLDTCategory);
        }
        [HttpPost]
        public ActionResult NLDTCreate(NLDTCategory NLDTCategory)
        {
            nldtDb.NLDTCategories.Add(NLDTCategory);
            nldtDb.SaveChangesAsync();
            return RedirectToAction("NLDTIndex");
        }
    }
}