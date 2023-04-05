using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping_Checkout.Models;

namespace Shopping_Checkout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Products prds)
        {
            prds.productsList.Add(new SelectListItem { Text = "Super iPad", Value = "1" });
            prds.productsList.Add(new SelectListItem { Text = "MacBook Pro", Value = "2" });
            prds.productsList.Add(new SelectListItem { Text = "Apple TV", Value = "3" });
            prds.productsList.Add(new SelectListItem { Text = "VGA adapter", Value = "4" });

            prds.productsQuantityList.Add(new SelectListItem { Text = "1", Value = "1" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "2", Value = "2" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "3", Value = "3" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "4", Value = "4" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "5", Value = "5" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "6", Value = "6" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "7", Value = "7" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "8", Value = "8" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "9", Value = "9" });
            prds.productsQuantityList.Add(new SelectListItem { Text = "10", Value = "10" });

            prds.selectOffers.Add(new SelectListItem { Text = "3 for 2 deal on Apple TVs", Value = "1" });
            prds.selectOffers.Add(new SelectListItem { Text = "Get free VGA on Mackbook Pro", Value = "2" });
            prds.selectOffers.Add(new SelectListItem { Text = "Buy 4 Ipd get 50 Off on each", Value = "3" });
            prds.selectOffers.Add(new SelectListItem { Text = "No Offers", Value = "4", Selected = true });

            
            return View(prds);
        }

        [HttpPost]
        public ActionResult AddItemsToCart(FormCollection form, Products prds, PricingRules r)
        {
            
            string pname = ViewBag.productName;
            int? qt = ViewBag.quantity;
            double? pri = ViewBag.price;

            string selectedPrdName = prds.ProductName;
            double prdQtys = Convert.ToDouble(form["Quantity"]);
            int offer = Convert.ToInt32(form["Offers"]);

            double total = r.checkOffers(selectedPrdName, prdQtys, prds, offer);

            prds.ProductName = selectedPrdName;
            prds.Quantity = Convert.ToInt32(prdQtys);
            prds.Price = total;

            return RedirectToAction("Index", prds);

        }
    }
}
