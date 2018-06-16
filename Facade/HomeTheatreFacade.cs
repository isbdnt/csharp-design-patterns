using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HomeTheatreFacade
    {
        Dimmer dimmer;
        Dvd dvd;
        DvdPlayer dvdPlayer;

        public HomeTheatreFacade(Dimmer dimmer, Dvd dvd, DvdPlayer dvdPlayer)
        {
            this.dvd = dvd;
            this.dimmer = dimmer;
            this.dvdPlayer = dvdPlayer;
        }

        public void WatchMovie()
        {
            dimmer.Dim(5);
            dvdPlayer.On();
            dvdPlayer.Insert(dvd);
            dvdPlayer.Play();
        }

        public void Pause()
        {
            dimmer.Dim(10);
            dvdPlayer.Pause();
        }

        public void Resume()
        {
            dimmer.Dim(5);
            dvdPlayer.Resume();
        }
    }
}
