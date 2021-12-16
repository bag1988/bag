using bag.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace bag.Areas.Admin.Controllers
{
    public class ModulesController : Controller
    {
        //private BAGBase db = new BAGBase();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult Index(string urlPartial)
        {
            if (!System.IO.File.Exists(Server.MapPath("~/views/modules/" + urlPartial + ".cshtml")))
                return null;
            return PartialView(urlPartial);
            
        }

        //[HttpPost]
        //public async Task<ActionResult> insertModule(int idModule, string urlpage)
        //{
        //    string action = HttpContext.Request.RequestContext.RouteData.Values["action"].ToString();
        //    module m = new module();
        //    m = await db.modules.FindAsync(idModule);
        //    if (m == null)
        //        return HttpNotFound("Отсутствует идентификатор расширения");
        //    pageModule p = new pageModule();

        //    int idpage = db.pages.First(x => x.urlPage == urlpage).idPage;
        //    if (idpage == 0)
        //        return HttpNotFound("Отсутствует идентификатор страницы");
        //    p.idPage = idpage;
        //    p.idModule = m.idModule;
        //    p.htmlOrText = m.defaultHtml;
        //    p.urlCss = m.defaultCss;
        //    p.yindex = db.pageModules.Any(x => x.idPage == idpage) ? db.pageModules.Where(x => x.idPage == idpage).Max(x => x.yindex) + 1 : 1;
        //    db.pageModules.Add(p);
        //    await db.SaveChangesAsync();

        //    return RedirectToAction(p.module.urlModule, new { idPageModule = p.idPageModule });

        //}

        //public ActionResult container(int? idPageModule)
        //{
        //    if (idPageModule == null)
        //        return View("Error");
        //    pageModule p = db.pageModules.Find(idPageModule);
        //    return PartialView("container", p);

        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //public class ChildOnlyAttribute : ActionFilterAttribute
        //{
        //    //выполняется до
        //    public override void OnActionExecuting(ActionExecutingContext filterContext)
        //    {
        //        if (!filterContext.IsChildAction)
        //        {
        //            //filterContext.Result = new HttpNotFoundResult();
        //            filterContext.Result = new ViewResult
        //            {
        //                ViewName = "Error",
        //                ViewData = { Model = new HandleErrorInfo(new Exception("Invalid Request !!"), filterContext.Controller.ToString(), filterContext.ActionDescriptor.ToString()) }
        //            };
        //        }
        //    }

        //    //выполняется после
        //    public override void OnActionExecuted(ActionExecutedContext filterContext)
        //    {
        //        //timer.Stop();
        //        //filterContext.HttpContext.Response.Write(
        //        //        string.Format("<div>Время обработки результата: {0:F6}</div>",
        //        //            timer.Elapsed.TotalSeconds));
        //    }
        //    public override void OnResultExecuting(ResultExecutingContext filterContext)
        //    {

        //        //timer.Stop();
        //        //filterContext.HttpContext.Response.Write(
        //        //        string.Format("<div>Время обработки результата: {0:F6}</div>",
        //        //            timer.Elapsed.TotalSeconds));
        //    }
        //}
    }
}