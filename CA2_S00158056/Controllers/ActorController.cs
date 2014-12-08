using CA2_S00158056.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CA2_S00158056.Controllers
{
    public class ActorController : Controller
    {
        CA2Entities movieDb = new CA2Entities();

        public ActionResult Index()
        {
            var x=movieDb.Actors.ToList();
            if(x==null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(x);
        }

        public PartialViewResult PopDetails(int? id)
        {
            return PartialView("_PopDetails", movieDb.Actors.Find(id));
        }

        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Actor incomingActor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db2 = new CA2Entities())
                    {
                        
                        movieDb.Actors.Add(incomingActor);
                        movieDb.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        public PartialViewResult Edit(int id)
        {
            return PartialView("_Edit", movieDb.Actors.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Actor editActor)
        {
            try
            {
                // Find the record in the db using the camp ID
                // Copy the edited one across to the retrieved one
                // Save back to database

                movieDb.Entry(editActor).State = EntityState.Modified;
                movieDb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public PartialViewResult Delete(int id)
        {
            return PartialView("_Delete", movieDb.Actors.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfimDelete(int id)
        {
            try
            {
                movieDb.Actors.Remove(movieDb.Actors.Find(id));
                var removeCast = from d in movieDb.ScreenNames
                                 where d.actorID == id
                                 select d;
                foreach (var item in removeCast)
                {
                    movieDb.ScreenNames.Remove(item);
                }
                movieDb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        public ActionResult EditCast(int? id, int? id2, string newname)
        {
            try
            {
                movieDb.ScreenNames.Find(id, id2).screenName = newname;
                movieDb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        public ActionResult RemoveCast(int? id, int? id2)
        {
            try
            {
                movieDb.ScreenNames.Remove(movieDb.ScreenNames.Find(id, id2));
                movieDb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
        }
        public PartialViewResult AddCast(int id)
        {
            ViewBag.actor = movieDb.Actors.Find(id);
            ViewBag.moviesList = movieDb.Movies.ToList();
            return PartialView("_AddCast");
        }

        [HttpPost]
        public ActionResult AddCast(ScreenName incomingScreenName)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db2 = new CA2Entities())
                    {

                        movieDb.ScreenNames.Add(incomingScreenName);
                        movieDb.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

    }
}
