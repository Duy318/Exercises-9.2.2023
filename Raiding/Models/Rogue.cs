using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Raiding.Models
{
    using Contracts;

    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
            Power = 80;
        }

        public override string CastAbility() => $"Rogue - {Name} hit for {Power} damage";
    }
}