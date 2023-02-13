using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    using Contracts;

    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            Power = 100;
        }

        public override string CastAbility() => $"Warrior - {Name} hit for {Power} damage";
    }
}