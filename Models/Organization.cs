﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB_App.Models
{
    public class Organization
    {
        public Organization()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public enum OrganizationType
        {
            Owner, Customer
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public OrganizationType Type { get; set; }
        public int? AddressID { get; set; }
        public virtual Address Address { get; set; }
        public string CustomNbr1 { get; set; }
        public string CustomNbr2 { get; set; }
        public string CustomNbr3 { get; set; }
        public string CustomNbr4 { get; set; }
        public string CustomNbr5 { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }

        [InverseProperty("Owner")]
        public virtual ICollection<Invoice> InvoiceOwner { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Invoice> InvoiceCustomer { get; set; }
    }
}