using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SB_App.Models
{
    public class Organization
    {

        public Organization()
        {

            Type = new Dictionary<int, string>()
            {
                { 0, "N/A"},  //show the complete egg menu to customers
                { 1, "Owner"},    //Either offer an alternative to eggs or don't show eggs on a customer's personalized dynamically generated menu

                //confirm with the customer if they want their eggs cooked their usual preferred way, i.e.
                { 2, "Customer"}
            };
        }
        public DateTime CurrentDate;
        public int ID { get; set; }
        public string Name { get; set; }
        public Dictionary<int, string> Type { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
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
    }
}