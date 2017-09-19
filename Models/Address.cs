using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class Address
    {
        public Address()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public enum AddressType
        {
            Primary, Secondary
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public AddressType Type { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
    }
}