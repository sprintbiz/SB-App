using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class InvoiceService
    {
        public InvoiceService()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int ID { get; set; }
        [Display(Name = "Invoice")]
        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }
        [Display(Name = "Service")]
        public int ServiceID { get; set; }
        public virtual Service Service { get; set; }
        public decimal Quantity { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
    }
}