using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise5
{
    public class RadioPlayerApp
    {
        // In-memory collection of stations
        List<RadioStation> stations = new List<RadioStation>
        {
            new RadioStation{ RStation = "RTE Radio 1",
                              Content = RadioContent.General,
                              Freqeuncy = 89},
            new RadioStation{ RStation = "RTE 2FM",
                              Content = RadioContent.Music,
                              Freqeuncy = 90},
            new RadioStation{ RStation = "Newstalk",
                              Content = RadioContent.News,
                              Freqeuncy = 104.4},
            new RadioStation{ RStation = "FM 104",
                              Content = RadioContent.Music,
                              Freqeuncy = 104.4},
            new RadioStation{ RStation = "98 FM",
                              Content = RadioContent.Music,
                              Freqeuncy = 98}
        };

        List<RadioStation> favouriteStations;
        public List<RadioStation> FavouriteStations 
        {
            get 
            {
                return favouriteStations;
            }
        }

        public string RadioPlayerName { get; set; }
        public RadioPlayerApp(string setRadioPlayerName)
        {
            RadioPlayerName = setRadioPlayerName;
            favouriteStations = new List<RadioStation>();
        }

        public void Like(string stationName)
        {
            // Come back later to fix validation
            favouriteStations.Add(stations.Find(s => s.RStation == stationName));
        }

        //public void DisplayFavouriteStations()
        //{
        //    foreach (var item in FavouriteStations)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public List<RadioStation> this[RadioContent contentGenre]
        {
            get
            {
                return stations.FindAll(s => s.Content == contentGenre).OrderByDescending(f => f.Freqeuncy).ToList();
            }
        }
    }
}
