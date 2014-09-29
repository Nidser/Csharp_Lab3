using System;

namespace Test
{
    public interface IHasVolume
    {
        double calcVolume();
    }

    public enum Color {Red, Green, Blue};

    public class Sphere : IHasVolume
    {
        public Color color {get;set;}
       
        private double radius;
        private Color color1;
        public double area { get; set; }

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
            :this(Color.Blue)
        {
            radius = r;
        }

        //Default Constructor
        public Sphere()
           : this(Color.Blue, 0.0)
        {

        }

        public Sphere(Color color1)
        {
            // TODO: Complete member initialization
            this.color1 = color1;
        }


        public double calcVolume()
        {
            area = Math.PI * radius * radius * radius;
            return area;
        }

        public override string ToString()
        {
            return base.ToString() + ": The area of the circle is " + area + " which is " + Color.Blue+ " in colour";
        }

    }
}
