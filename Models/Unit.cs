using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class Unit
    {
        public DateTime CurrentDate;
        public int ID{ get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public Unit()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}