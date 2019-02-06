using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGamePractice
{
    public class Player : Character
    {
        public int PlayerNumber { get; private set; }
        public void Move()
        {
            Console.WriteLine("Which way?");
            Console.ReadLine();
            Console.WriteLine("Player moves right");

        }
        public void UseMagicAttack()
        {

        }
        
        public void Heal()
        {

        }
    }
    public Player()
    {
        HealthPoints = 100;
        Die = false;
        AttackDamage = 20;
        PlayerNumber = 1;
    }
}
