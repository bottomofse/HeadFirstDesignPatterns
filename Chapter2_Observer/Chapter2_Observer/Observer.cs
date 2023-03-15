using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Observer
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temparature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("現在の気象状況：温度 " + temparature + "度　湿度 " + humidity + "%");
        }

        public void update(float temparature, float humidity, float pressure)
        {
            this.temparature = temparature;
            this.humidity = humidity;
            display();
        }


    }
    
    public interface Observer
    {
        public void update(float temp, float humidity, float presure);
    }

    public interface DisplayElement
    {
        public void display();
    }

}
