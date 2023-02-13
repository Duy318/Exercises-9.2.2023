﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    using WildFarm.Models.FoodTypes;

    public class Tiger : Feline
    {
        private const double WEIGHT_MODIFIER = 1;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }

        public override string AskForFood() => "ROAR!!!";

        public override void Feed(Food food)
        {
            if (food.GetType() != typeof(Meat))
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");

                return;
            }

            Weight += food.Quantity * WEIGHT_MODIFIER;

            FoodEaten += food.Quantity;
        }
    }
}