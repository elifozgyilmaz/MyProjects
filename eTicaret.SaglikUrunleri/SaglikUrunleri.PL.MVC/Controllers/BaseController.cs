using SaglikUrunleri.BLL.Repository;
using SaglikUrunleri.DAL.Context;
using SaglikUrunleri.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaglikUrunleri.PL.MVC.Controllers
{
    public class BaseController : Controller
    {
        SaglikContext db = new SaglikContext(); //database i bağla

        // GET: Base

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Repository<Kategori> repoK = new Repository<Kategori>(db);
            ViewBag.Kategoriler = repoK.GetAll();
            base.OnActionExecuting(filterContext);
        }
    }
}