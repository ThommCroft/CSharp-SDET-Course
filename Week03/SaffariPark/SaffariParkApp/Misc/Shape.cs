using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaffariParkApp.Misc
{
    //abstract classes can have concrete and abstract methods in them.
    //Concrete classes can only have concrete methods.
    public abstract class Shape
    {
        //abstract method has no implementation(no method body)
        public abstract int CalculateArea();

        public override string ToString()
        {
            return "This is a shape";
        }
    }

    public class Rectangle : Shape
    {
        private int _length;
        private int _width;

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        public override string ToString()
        {
            return "This is a Rectangle";
        }

        public override int CalculateArea()
        {
            return _length * _width;
        }
    }
}
