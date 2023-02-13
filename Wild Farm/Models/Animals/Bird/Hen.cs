using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double WEIGHT_MODIFIER = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize) { }

        public override string AskForFood() => "Cluck";

        public override void Feed(Food food)
        {
            Weight += food.Quantity * WEIGHT_MODIFIER;

            FoodEaten += food.Quantity;
        }
    }
}