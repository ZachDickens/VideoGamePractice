using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGamePractice
{
    public class Baddy : Character
    {
        public void Move()
        {
            Console.WriteLine("Baddy moves left");
        }
        public void Attack()
        {

        }


        public Baddy()
        {
            HealthPoints = 100;
            Die = false;
            AttackDamage = 20;

        }
    }         
}
