using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public enum RadioContent{
        General, Music, News
    }
    public class RadioStation : IStreamable
    {
        private double freqeuncy;
        public double Freqeuncy 
        {
            get 
            {
                return freqeuncy;
            }
            set 
            { 
                if(value >= 87.5 && value <= 108)
                {
                    freqeuncy = value;
                }
                else
                {
                    throw new ArgumentException("Frequency out of range");
                }
            } 
        }

        public string RStation { get; set; }
        public RadioContent Content { get; set; }

        public RadioStation(string setStationName, RadioContent setContent, double setFrequency)
        {
            RStation = setStationName;
            Content = setContent;
            Freqeuncy = setFrequency;
        }
        public RadioStation()
        {

        }
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Radio Statio: {RStation}\n" +
                   $"Radio Content: {Content}\n" +
                   $"Frequency: {Freqeuncy}"; 
        }
    }
}
