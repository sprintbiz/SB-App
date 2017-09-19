using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SB_App.DAL;
using SB_App.Models;

namespace SB_App.Controllers
{
    public class InvoiceServicesController : Controller
    {
        private SprintbizContext db = new SprintbizContext();

        // GET: InvoiceServices
        public ActionResult Index()
        {
            var invoiceServices = db.InvoiceServices.Include(i => i.Invoice).Include(i => i.Service);
            return View(invoiceServices.ToList());
        }

        // GET: InvoiceServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InvoiceService invoiceService = db.InvoiceServices.Find(id);
            if (invoiceService == null)
            {
                return HttpNotFound();
            }
            return View(invoiceService);
        }

        // GET: InvoiceServices/Create
        public ActionResult Create()
        {
            ViewBag.InvoiceID = new SelectList(db.Invoices, "ID", "SalesDate");
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "Name");
            return View();
        }

        // POST: InvoiceServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,InvoiceID,ServiceID,Quantity,CustomNbr1,CustomNbr2,CustomNbr3,CustomNbr4,CustomNbr5,Created,Updated")] InvoiceService invoiceService)
        {
            if (ModelState.IsValid)
            {
                db.InvoiceServices.Add(invoiceService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InvoiceID = new SelectList(db.Invoices, "ID", "SalesDate", invoiceService.InvoiceID);
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "Name", invoiceService.ServiceID);
            return View(invoiceService);
        }

        // GET: InvoiceServices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InvoiceService invoiceService = db.InvoiceServices.Find(id);
            if (invoiceService == null)
            {
                return HttpNotFound();
            }
            ViewBag.InvoiceID = new SelectList(db.Invoices, "ID", "SalesDate", invoiceService.InvoiceID);
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "Name", invoiceService.ServiceID);
            return View(invoiceService);
        }

        // POST: InvoiceServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,InvoiceID,ServiceID,Quantity,CustomNbr1,CustomNbr2,CustomNbr3,CustomNbr4,CustomNbr5,Created,Updated")] InvoiceService invoiceService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invoiceService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InvoiceID = new SelectList(db.Invoices, "ID", "SalesDate", invoiceService.InvoiceID);
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "Name", invoiceService.ServiceID);
            return View(invoiceService);
        }

        // GET: InvoiceServices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InvoiceService invoiceService = db.InvoiceServices.Find(id);
            if (invoiceService == null)
            {
                return HttpNotFound();
            }
            return View(invoiceService);
        }

        // POST: InvoiceServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InvoiceService invoiceService = db.InvoiceServices.Find(id);
            db.InvoiceServices.Remove(invoiceService);
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
