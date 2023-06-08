using System;
using System.Collections.Generic;
using System.Text;

namespace News.Models
{

    public class Weather

    {
        public int Id { get; set; }

        public string Main { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }
    }

    public class Main

    {
        public double Temp { get; set; }

        public double Feels_like { get; set; }

        public double temp_min { get; set; }

        public double Wtemp_max { get; set; }

        public int Pressure { get; set; }

        public double Humidity { get; set; }

    }

    public class Wind
    {
        public double Speed { get; set; }

        public int Deg { get; set; }

        public double Gust { get; }
    }

    public class Cloud
    {
        public int All { get; set; }
    }


    public class WeatherResult

    {
        public DateTime Dt { get; set; }

        public List<Weather> Weather { get; }


    }
}
