using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    using Contracts;

    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        {
            Power = 100;
        }

        public override string CastAbility() => $"Paladin - {Name} healed for {Power}";
    }
}