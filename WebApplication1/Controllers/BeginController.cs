using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BeginController : Controller
    {
        private MvcBasicContext db = new MvcBasicContext();

        /// <summary>
        /// Listを返す
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View(db.Members);
        }

        /// <summary>
        /// Listを返す
        /// </summary>
        /// <returns></returns>
        public ActionResult List2()
        {
            return View(db.Companies);
        }

        // GET: Begin
        public ActionResult Index()
        {
            return View();
        }
    }
}