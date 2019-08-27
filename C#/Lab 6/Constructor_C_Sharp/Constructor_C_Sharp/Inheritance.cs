using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_C_Sharp
{
    public class Shape
    {
        public const double PI = Math.PI;
        protected double x,y;
        public Shape()
        {

        }
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double area()
        {
            return x * y;
        } 
    }
    public class Circle : Shape
    {
        public Circle(double r) : base(r,0)
        {

        }
        public override double area()
        {
            return PI * x * x;
        }
    }
    public class Sphere : Shape
    {
        public Sphere(double r) : base(r,0)
        {

        }
        public override double area()
        {
            return 4*PI*x*x;
        }
    }

}
