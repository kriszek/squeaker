using Squeaker.Model;
using System;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace Squeaker.UI.MVC.Controllers
{
    [Authorize]
    public class SqueakController : Controller
    {
        // GET: Squeak
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Squeak model)
        {
            if (ModelState.IsValid)
            {
                model.ID = 0;
                model.CreationDate = DateTimeOffset.UtcNow;
                model.OwnerID = User.Identity.GetUserId();

                using (DataAccess.SqueakerContext db = new DataAccess.SqueakerContext())
                {
                    db.Squeaks.Add(model);
                    db.SaveChanges(); 
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }
    }
}