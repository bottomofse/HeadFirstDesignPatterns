using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Observer
{
    public class WeatherStation
    {
        public void exec()
        {
            WeatherData wd = new WeatherData();
            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(wd);

            wd.setMeasurements(27, 65, 30.4f);
            wd.setMeasurements(28, 70, 29.2f);
            wd.setMeasurements(26, 90, 29.3f);
        }
    }
}
