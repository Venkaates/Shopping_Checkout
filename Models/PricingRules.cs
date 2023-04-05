using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping_Checkout.Models;

namespace Shopping_Checkout.Models
{
    public class PricingRules
    {
        public double checkOffers(string _product, double _qty, Products prices, int offer)
        {
            double actualItemPrice = 0.0, _totalPrice = 0.0;

            if (_product == "Super iPad") { actualItemPrice = prices.IPD; }
            else if (_product == "MacBook Pro") { actualItemPrice = prices.MBP; }
            else if (_product == "Apple TV") { actualItemPrice = prices.ATV; }
            else if (_product == "VGA adapter") { actualItemPrice = prices.VGA; }
            else { actualItemPrice = 0.00; }

            _totalPrice = actualItemPrice * _qty;

            if (offer == 1)
            {
                double eligibleFreeAtvs = Math.Floor(_qty / 3);
                double eligibleExtraAtvs = (_qty % 3) - 1;

                if (eligibleFreeAtvs >= 1)
                {
                    double priceOfAtv = prices.ATV;
                    _totalPrice = _totalPrice - priceOfAtv * eligibleFreeAtvs;
                }
            }

            if (offer == 2)
            {
                double priceOfVGA = _qty * prices.VGA;
                _totalPrice = _totalPrice - priceOfVGA;

            }
            if (offer == 3)
            {
                if (_qty >= 4)
                {
                    _totalPrice = _totalPrice - _qty * 50;
                }
            }
            return _totalPrice;
        }
    }
}