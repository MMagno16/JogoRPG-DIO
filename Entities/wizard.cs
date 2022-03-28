using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_em_c_.Entities
{
    public class wizard : Hero
    {

        public wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia !";
        }

        public string Attack(int Bonus)
        {
            //encapsulamento
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}