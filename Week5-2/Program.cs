using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week5_2
{
    internal class Program
    {
        //Very similar to Excercise 1, I'm understanding pretty well. I won't be an expert on it and may need some help for a bit, but I'm getting there.
        public class Shape
        {
            public double Area;
            //Shape simply establishes Area, universal(for each inherited class)
            public virtual void CalculateArea()
            {
                //Since CalculateArea() is overridden everytime, not really necessary to have anything here. Did it anyway :)
                Area = 0.0;
                Console.WriteLine("The area of no shape is " + Area);
            }
        }
        public class Circle : Shape
        {
            //Circle establishes radius
            public double radius {  get; set; }
            public Circle(double radius)
            {
                //I was going to have there be another variable, like radius = givenRadius, but Visual Studio autocrrected to this, and I think it makes it much easier
                //All that the this.Radius does is differentiate the incoming variable from the Main program, and changing the class's radius value to the new one
                this.radius = radius;
            }
            public override void CalculateArea()
            {
                //Also good thing that you introduced the Math. concept, cuz I would've just been stuck here a while otherwise. All it does is call the correct Math program, like pi or powers of numbers
                Area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("The area of the circle is " + Area);
            }
        }
        public class Rectangle : Shape
        {
            //Near the same as Circle and Triangle, basically (but not actually) a copy paste of the same kind of code, just adjusted for the rectangle
            public double length { get; set; }
            public double width { get; set; }
            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }
            public override void CalculateArea()
            {
                Area = length * width;
                Console.WriteLine("The area of the rectangle is " + Area);
            }
        }
        //I'm not even gonna comment on the Triangle one, just saying that I am getting it a lot more now! (But, again, I'm not perfect at it.)
        public class Triangle : Shape
        {
            public double baseValue { get; set; }
            public double height { get; set; }
            public Triangle(double baseValue, double height)
            {
                this.baseValue = baseValue;
                this.height = height;
            }
            public override void CalculateArea()
            {
                Area = 0.5 * baseValue * height;
                Console.WriteLine("The area of the triangle is " + Area);
            }
        }
        static void Main(string[] args)
        {
            //The program makes some coolShapes and gives them their values
            Circle coolCircle = new Circle(6);
            Rectangle coolRectangle = new Rectangle(8, 4);
            Triangle coolTriangle = new Triangle(5, 7);
            //And then pulls their respective methods to Calculate the Area. I saw in the instructions that it should be a loop, but I honestly didn't understand it.
            //Not sure if you wanted user input for the new shapes, and if not, then the loop would just do the same and be unneccessary. Honestly, I just needed clearer instructions, because I don't get what's being asked of me.

            //Oh, and I also tried to do that thing from last Wednesday that made it so that big decimals, like the Circle one, would be down to 2 decimal places, but I couldn't remember the exact code because it was quick and at the end of class, so the decimals are nice and long here. (Like this comment!)
            coolCircle.CalculateArea();
            coolRectangle.CalculateArea();
            coolTriangle.CalculateArea();

            //Console.ReadLine();.
            //My GOAT.
            Console.ReadLine();
        }
    }
}
