using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public int Wheel;
        public int Door;
        public int Window;
        public int Engine;
        public string Color;
        public int Horsepower;
        public bool run;
        public int speed;

        public Car(int Wheel, int Door, int Window, int Engine, string Color, int Horsepower, bool run, int speed)
        {
            this.Wheel = Wheel;
            this.Door = Door;
            this.Window = Window;
            this.Engine = Engine;
            this.Color = Color;
            this.Horsepower = Horsepower;
        }
    }
}
