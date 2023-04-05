using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel;

namespace Shopping_Checkout.Models
{
    public class Products
    {
        public Products()  
        {  
            productsList = new List<SelectListItem>();
            productsQuantityList = new List<SelectListItem>();
            selectOffers = new List<SelectListItem>();
        }  
  
        public List<SelectListItem> productsList { get;set; }
        public List<SelectListItem> productsQuantityList { get;set; }
        public List<SelectListItem> selectOffers { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }


        public List<Products> lstProducts { get; set; }

        public int chkI { get; set; }
        
        private double ipd = 549.99;
        private double mbp = 1399.99;
        private double atv = 109.50;
        private double vga = 30.00;

        public double IPD 
        {
            get { return ipd; }
            set { ipd = value; }
        }
        public double MBP
        {
            get { return mbp; }
            set { mbp = value; }
        }
        public double ATV
        {
            get { return atv; }
            set { atv = value; }
        }
        public double VGA
        {
            get { return vga; }
            set { vga = value; }
        }
    }
}