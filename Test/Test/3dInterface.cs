using System;
using System.Globalization;

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
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ApplicationException("radius must be greater than zero");
                }
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


        public virtual double calcVolume()
        {
            area = Math.PI * radius * radius * radius;
            return area;
        }

        public override string ToString()
        {
            return "A Sphere of radius: " + radius.ToString() + " with an area of " + calcVolume().ToString("0.00", CultureInfo.InvariantCulture);  
           // return base.ToString() + ": The area of the circle is " + area + " which is " + Color.Blue+ " in colour";
        }


        /* Test class example of a for loop of Shape objects
         * // collection of sphere objects referenced by HasVolume refs
        Shape.IHasVolume[] collection = { new Shape.Sphere(), new Shape.Sphere(10) };

        foreach (Shape.IHasVolume s in collection)
        {
            Console.WriteLine(s + " volume: " + s.CalcVolume());
        }
         * */
    }
}
