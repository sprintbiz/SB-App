using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class Invoice
    {
        public Invoice()
        {
            CreateDate = DateTime.Now;
            SalesDate = DateTime.Now;
            PaymentDate = DateTime.Now.AddDays(14);
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
        public enum InvoiceStatus
        {
            Created, Paid
        }
        public enum InvoicePaymentMethod
        {
            Przelew, Gotówka
        }
        public int ID { get; set; }
        [Display(Name = "Owner")]
        public virtual Organization Owner { get; set; }
        public int OwnerID { get; set; }
        [Display(Name = "Customer")]
        public virtual Organization Customer { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Create Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Sales Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SalesDate { get; set; }
        [Display(Name = "Paymen Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }
        public InvoiceStatus Status { get; set; }
        [Display(Name = "Paymen Method")]
        public InvoicePaymentMethod PaymentMethod { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
    }
}