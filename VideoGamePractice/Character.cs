using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGamePractice
{
    public abstract class Character
    {
        public int HealthPoints { get; set; }
        public void Move()
        {

        }
        public void Die()
        {
            HealthPoints = 0;
            Console.WriteLine("Dying!");
        }

        public void Attack()
        {
            Console.WriteLine("Attack!");
            Console.WriteLine("Your character swings their sword");
        }
        public void Block()
        {

        }


        public Character()
        {
            Console.WriteLine("Character constructor is running");
            HealthPoints = 100;
            
        }

    }
}
