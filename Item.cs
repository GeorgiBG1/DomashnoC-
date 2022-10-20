using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovProekt
{
    public class Item
    {
        public string Name { get; private set; }
        public double Attack { get; private set; }
        public double Defence { get; private set; }
        public Item(string name, double atk, double def)
        {
            Name = name;
            Attack = atk;
            Defence = def;
            if (atk < 0 || atk > 10 || def<0 || def>10)
            {
                
                Console.WriteLine("Invalid Attack / Defence item value");
            }
        }
        
        public void UpgradeAttack(double atk)
        {
            Attack += atk;
            if (atk > 50 || atk < 0)
            {
                Console.WriteLine("Invalid Attack improvement value.");
            }
        }

        public void UpgradeDefence(double def)
        {
            Defence += def;
            if(def < 0 || def>50)
            {
                Console.WriteLine("Invalid Defence improvement value.");
            }
        }
    }
}
