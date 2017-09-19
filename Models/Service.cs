using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class Service
    {
        public Service()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public DateTime CurrentDate;
        public int ID { get; set; }
        [Display(Name = "Tax")]
        public int? TaxID { get; set; }
        public virtual Tax Tax { get; set; }
        [Display(Name = "Unit")]
        public int? UnitID { get; set; }
        public virtual Unit Unit { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }

    }
}