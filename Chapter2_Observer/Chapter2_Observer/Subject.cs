using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Observer
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temparature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0) observers.RemoveAt(i);
        }

        public void notifyObservers()
        {
            foreach(var o in observers)
            {
                o.update(temparature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temparature, float humidity, float pressure)
        {
            this.temparature = temparature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
    public interface Subject
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObservers();
    }
}
