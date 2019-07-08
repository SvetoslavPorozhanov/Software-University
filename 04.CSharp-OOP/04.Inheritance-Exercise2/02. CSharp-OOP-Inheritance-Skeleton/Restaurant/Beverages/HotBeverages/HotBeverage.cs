﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.HotBeverages
{
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {

        }
    }
}
