﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; }
    }
}