using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Værvarsel2
{
    class Weather
    {
        #region PrivVars
        private string time;
        private int temp = 0;
        private double prec = 0;
        private double wind = 0;
        #endregion

        #region Constructors
        public Weather() { }

        public Weather(string dateTime, string temperature, string precipitation, string windSpeed)
        {
            time = dateTime;

            temp = Convert.ToInt16(temperature);

            try { prec = Convert.ToDouble(precipitation); }
            catch (FormatException)
            { prec = Convert.ToDouble(precipitation.Replace('.', ',')); }

            try
            { wind = Convert.ToDouble(windSpeed); }
            catch (FormatException)
            { wind = Convert.ToDouble(windSpeed.Replace('.', ',')); }
        }
        #endregion

        #region GetSet
        public string Hour
        {
            get => GetHour();
        }

        public int Temperature
        {
            get => temp;
        }

        public double Precipitation
        {
            get => prec;
        }

        public double WindSpeed
        {
            get => wind;
        }
        #endregion

        #region Private methods
        private string GetHour()
        {
            return time.Split('T')[1].Split(':')[0];
        }
        #endregion 
    }
}
