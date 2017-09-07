using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class Tax
    {
        public DateTime CurrentDate;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public Tax()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}