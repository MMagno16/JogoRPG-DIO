using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_em_c_.Entities
{
    public class knight : Hero
    {
        public knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }
    }
}