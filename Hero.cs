using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovProekt
{
    public class Hero
    {
        private double attackCoef = 15;
        private double defenceCoef = 20;
          

        public string Name { get;  set; }
        public Fraction Fraction { get; set; }
        public int Level { get; private set; }
        public double Health { get; private set; }
        public double Stamina { get; private set; }
        public double Mana { get; private set; }
        

        public List<Item> ItemSet { get; }

        public Hero(string Name, Fraction fraction)
        {
            Level = 0;
            Health = 100;
            Stamina = 100;
            Mana = 100;
            ItemSet = new List<Item>();
            this.Name = Name;
            Fraction = fraction;
        }

        public double LevelUp()
        {
            Level += 1;
            Health = 100;
            Stamina = 100;
            Mana = 100;
            return Level;
            
        }
        public double GetAttack()
        {
            double getAttack = ItemSet.Sum(i => i.Attack);            
            return  getAttack += Level * attackCoef;
        }
        public double GetDeffence()
        {
            double getDefence = ItemSet.Sum(i => i.Defence);            
            return getDefence += Level * defenceCoef;
        }
        
        
    }
}
