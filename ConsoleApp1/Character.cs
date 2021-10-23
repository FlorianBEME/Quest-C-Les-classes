using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character
    {

        public string name;
        public int lifePoint;
        public int attack;
        public int defense;

        public Character(string aName, int aLifePoint, int aAttack, int aDefense)
        {
            name = aName;
            lifePoint = aLifePoint;
            attack = aAttack;
            defense = aDefense;
        }

        public int Attack(Character Attaquant, Character Attaqué)
        {
            return Attaqué.lifePoint = (Attaqué.lifePoint) - (Attaquant.attack - Attaqué.defense) ;
           
        }

        public bool IsAlive()
        {
            if(this.lifePoint > 0)
            {
                return true;
            }
            return false;
        }
    }
}
