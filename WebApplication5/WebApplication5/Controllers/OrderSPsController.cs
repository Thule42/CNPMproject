using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class OrderSPsController : Controller
    {
        private FoodCompanyEntities db = new FoodCompanyEntities();

        // GET: OrderSPs
        public ActionResult Index()
        {
            return View(db.OrderSPs.ToList());
        }

        // GET: OrderSPs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderSP orderSP = db.OrderSPs.Find(id);
            if (orderSP == null)
            {
                return HttpNotFound();
            }
            return View(orderSP);
        }

        // GET: OrderSPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderSPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,ExportID,ProductID,ProductName,Quantity,Price,TotalPrice,AgentID,Address")] OrderSP orderSP)
        {
            if (ModelState.IsValid)
            {
                db.OrderSPs.Add(orderSP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderSP);
        }

        // GET: OrderSPs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderSP orderSP = db.OrderSPs.Find(id);
            if (orderSP == null)
            {
                return HttpNotFound();
            }
            return View(orderSP);
        }

        // POST: OrderSPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,ExportID,ProductID,ProductName,Quantity,Price,TotalPrice,AgentID,Address")] OrderSP orderSP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderSP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderSP);
        }

        // GET: OrderSPs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderSP orderSP = db.OrderSPs.Find(id);
            if (orderSP == null)
            {
                return HttpNotFound();
            }
            return View(orderSP);
        }

        // POST: OrderSPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OrderSP orderSP = db.OrderSPs.Find(id);
            db.OrderSPs.Remove(orderSP);
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
