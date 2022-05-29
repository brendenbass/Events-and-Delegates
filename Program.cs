using System;
using System.Threading;

namespace Events_and_Delegates
{
    internal class Program
    {
        static int score = 0;

        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();

            shooter.ShotsFired += KilledEnemy;
            shooter.ShotsFired += AddScore;

            shooter.OnShoot();
        }

        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            var tempSender = sender as Shooter;

            Console.WriteLine($"I killed an enemy, and my name is: {tempSender.Name}!");
            Console.WriteLine($"Time of kill is: {e.TimeOfKill}.");
            Console.WriteLine($"My score now is: {score}.");
        }

        public static void AddScore(object sender, ShotsFiredEventArgs e)
        {
            score++;
        }
    }
}
