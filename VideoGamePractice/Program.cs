using System;

namespace VideoGamePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CrashingCastles!");
            Player player = new Player();

            player.Move();
            player.Attack();
            player.Block();
            player.UseMagicAttack();
            player.Heal();
            player.Die();
            int currentHealthPoints = player.HealthPoints;

            Player playerB = new Player();
            int playerNumber = playerB.PlayerNumber;

        }
    }
}
