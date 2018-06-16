using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player powered on");

        Dvd dvd;
        int time = 0;

        public void Insert(Dvd dvd)
        {
            this.dvd = dvd;
            Console.WriteLine($"Inserting {dvd.Movie}");

        }

        public void Play() => Console.WriteLine($"Playing {dvd.Movie}");

        public void Pause()
        {
            Console.WriteLine($"Pausing at {time = (new Random()).Next(time, time + 120)}");
        }

        public void Resume()
        {
            Console.WriteLine($"Resuming from {time}");
        }
    }
}
