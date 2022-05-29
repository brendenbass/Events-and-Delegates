using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public class Shooter
    {
        private string name = "billy";
        private Random rng = new Random();

        public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    ShotsFired?.Invoke(this, new ShotsFiredEventArgs(DateTime.Now));
                }
                else
                {
                    Console.WriteLine("I missed.");
                }
                Thread.Sleep(500);
            }
        }
    }
}
