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
        [Display(Name = "NIP")]
        public string CustomNbr1 { get; set; }
        [Display(Name = "PESEL")]
        public string CustomNbr2 { get; set; }
        [Display(Name = "REGON")]
        public string CustomNbr3 { get; set; }
        [Display(Name = "Additional #1")]
        public string CustomNbr4 { get; set; }
        [Display(Name = "Additional #2")]
        public string CustomNbr5 { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
    }
}