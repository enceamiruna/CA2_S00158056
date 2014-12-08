using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA2_S00158056.Models;
using System.Data.Entity;
using System.Net;
using System.IO;

namespace CA2_S00158056.Controllers
{
    public class HomeController : Controller
    {

        CA2Entities movieDb = new CA2Entities();

        public ActionResult Index()
        {
            var x = movieDb.Movies.ToList();
            if (x == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(x);
        }

        public PartialViewResult PopDetails(int? id)
        {
            return PartialView("_PopDetails", movieDb.Movies.Find(id));
        }

        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

        public PartialViewResult AddCast(int id)
        {
            ViewBag.actorsList = movieDb.Actors.ToList();
            ViewBag.movie = movieDb.Movies.Find(id);
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

        [HttpPost]
        public ActionResult Create(Movie incomingMovie, HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db2 = new CA2Entities())
                    {
                        string ImageName = Path.GetFileName(file.FileName);
                        string physicalPath = Server.MapPath("~/Images/" + ImageName);
                        string extension =Path.GetExtension(physicalPath).ToUpper();
                        if (extension == ".PNG" || extension == ".JPG" || extension == ".JPEG")
                        {
                            // save image in folder
                            file.SaveAs(physicalPath);
                            incomingMovie.imageUrl = ImageName;
                            movieDb.Movies.Add(incomingMovie);
                            movieDb.SaveChanges();
                        }
                        else
                            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
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
            return PartialView("_Edit", movieDb.Movies.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie editMovie, HttpPostedFileBase file)
        {
            try
            {
                // Find the record in the db using the camp ID
                // Copy the edited one across to the retrieved one
                // Save back to database
                if (file != null)
                {
                    string ImageName = System.IO.Path.GetFileName(file.FileName);
                    string physicalPath = Server.MapPath("~/Images/" + ImageName);
                    string extension =Path.GetExtension(physicalPath).ToUpper();
                    if (extension == ".PNG" || extension == ".JPG" || extension == ".JPEG")
                    {
                        // save image in folder
                        file.SaveAs(physicalPath);
                        editMovie.imageUrl = ImageName;
                    }
                    else
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                }
                movieDb.Entry(editMovie).State = EntityState.Modified;
                movieDb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        public PartialViewResult Delete(int id)
        {
            return PartialView("_Delete", movieDb.Movies.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfimDelete(int id)
        {
            try
            {
                movieDb.Movies.Remove(movieDb.Movies.Find(id));
                var removeCast = from d in movieDb.ScreenNames
                            where d.movieID == id
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
    }
}