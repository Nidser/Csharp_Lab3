using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public interface IHasVolume
    {
        void calcVolume();
    }

    public enum Color {Red, Green, Blue};

    class Sphere : IHasVolume
    {
        public Color color {get;set;}
        public double area { get; set; }

        private double radius;
        private int p;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Sphere(Color color, double r)
        {
            this.color = color;
            radius = r;
        }

        public Sphere(double r)
        {
            radius = r;
        }

        



        public void calcVolume()
        {
            area = Math.PI * radius * radius * radius; 

        }

        public override string ToString()
        {
            return base.ToString() + " the area of the circle is " + area + " which is " + Color.Blue+ " in colour";
        }

    }
}
