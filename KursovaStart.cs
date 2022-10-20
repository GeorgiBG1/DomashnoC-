using System;
using KursovProekt;
namespace KursovProekt
{
    class KursovaStart
    {
        static void Main(string[] args)
        {
            Item weapon1 = new Item("sword", 9, 0);
            Item weapon2 = new Item("bow", 2, 0);
            Item weapon3 = new Item("spear", 9, 3);
            Item weapon4 = new Item("claymore", 5, 4);
            Item weapon5 = new Item("magicbook", 3, 5);
            Item armor1 = new Item("helmet", 0, 8);
            Item armor2 = new Item("chestplate", 7, 10);
            Item armor3 = new Item("leggings", 0, 5);
            Item armor4 = new Item("boots", 2, 3);

            Hero player1 = new("Xiao", Fraction.Knight);
            player1.LevelUp();
            player1.LevelUp();
            player1.LevelUp();
            player1.LevelUp();

            player1.ItemSet.Add(weapon3);
            player1.ItemSet.Add(armor1);
            player1.ItemSet.Add(armor2);
            player1.ItemSet.Add(armor3);
            player1.ItemSet.Add(armor4);
            Hero player2 = new("Ganyu", Fraction.Rogue);
            player2.Fraction = Fraction.Ranged; //Тест
            player2.LevelUp();
            player2.LevelUp();
            
            player2.ItemSet.Add(weapon2);
            player2.ItemSet.Add(armor1);
            player2.ItemSet.Add(armor2);
            player2.ItemSet.Add(armor3);
            player2.ItemSet.Add(armor4);

            weapon1.UpgradeAttack(14);
            weapon2.UpgradeAttack(14);
            weapon3.UpgradeAttack(14);
            weapon4.UpgradeAttack(67); //Тест
            weapon5.UpgradeAttack(14);
            armor1.UpgradeDefence(35);
            armor2.UpgradeDefence(35);
            armor3.UpgradeDefence(55); //Тест
            armor4.UpgradeDefence(35);

            Console.WriteLine("Weapon1:\nAttack: " + weapon1.Attack + "\nDefence: " + weapon1.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon2:\nAttack: " + weapon2.Attack + "\nDefence: " + weapon2.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon3:\nAttack: " + weapon3.Attack + "\nDefence: " + weapon3.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon4:\nAttack: " + weapon4.Attack + "\nDefence: " + weapon4.Defence);
            Console.WriteLine();
            Console.WriteLine("Weapon5:\nAttack: " + weapon5.Attack + "\nDefence: " + weapon5.Defence);

            Console.WriteLine();
            Console.WriteLine($"\tPlayer1\nLevel: {player1.Level},\nHero name: {player1.Name},\nHealth: {player1.Health},\nMana: {player1.Mana},\nStamina: {player1.Stamina},\nFraction: {player1.Fraction},\nDamage: {player1.GetAttack()},\nDefence: {player1.GetDeffence()}");
            Console.WriteLine();
            Console.WriteLine($"\tPlayer2\nLevel: {player2.Level},\nHero name: {player2.Name},\nHealth: {player2.Health},\nMana: {player2.Mana},\nStamina: {player2.Stamina},\nFraction: {player2.Fraction},\nDamage: {player2.GetAttack()},\nDefence: {player2.GetDeffence()}");

        }
    }
}
