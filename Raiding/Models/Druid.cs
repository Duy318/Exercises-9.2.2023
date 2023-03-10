using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    using Contracts;

    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
            Power = 80;
        }

        public override string CastAbility() => $"Druid - {Name} healed for {Power}";
    }
}