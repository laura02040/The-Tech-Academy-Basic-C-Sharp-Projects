using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsurreeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insurree
        public ActionResult Index()
        {
            return View(db.Insurrees.ToList());
        }

        // GET: Insurree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurree insurree = db.Insurrees.Find(id);
            if (insurree == null)
            {
                return HttpNotFound();
            }
            return View(insurree);
        }

        // GET: Insurree/Create
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Insurree insuree)
        {
            if (ModelState.IsValid)
            {   
                decimal quote = 50m;
                var age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth > DateTime.Now.AddYears(-age))
                {
                    age--;
                }
                if (age <= 18)
                {
                    quote += 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    quote += 50;
                }
                else if (age >= 26)
                {
                    quote += 25;
                }
                if (insuree.CarYear < 2000)
                {
                    quote += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    quote += 25;
                }
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        quote += 25;
                    }
                }
                quote += insuree.SpeedingTickets * 10;
                if (insuree.DUI)
                {
                    quote *= 1.25m;
                }
                if (insuree.CoverageType)
                {
                    quote *= 1.50m;
                }
                insuree.Quote = quote;
                db.Insurrees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }
        public ActionResult Admin()
        {
            var insurees = db.Insurrees.ToList();
            return View(insurees);
        }


        // POST: Insurree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Createe([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurree insurree)
        {
            if (ModelState.IsValid)
            {
                db.Insurrees.Add(insurree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurree);
        }

        // GET: Insurree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurree insurree = db.Insurrees.Find(id);
            if (insurree == null)
            {
                return HttpNotFound();
            }
            return View(insurree);
        }

        // POST: Insurree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurree insurree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurree);
        }

        // GET: Insurree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurree insurree = db.Insurrees.Find(id);
            if (insurree == null)
            {
                return HttpNotFound();
            }
            return View(insurree);
        }

        // POST: Insurree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurree insurree = db.Insurrees.Find(id);
            db.Insurrees.Remove(insurree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
