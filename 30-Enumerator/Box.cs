using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Enumerator
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Width { get; set; }

        public Box() : this(1, 1, 1) { }

        public Box(double length,double breadth,double width)
        {
            this.Length = length;
            this.Breadth = breadth;
            this.Width = width;
        }

        public static Box operator +(Box box1,Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Breadth=box1.Breadth+box2.Breadth,
                Width=box1.Width+box2.Width,
            };

            return box;
        }

        public static Box operator -(Box box1,Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Breadth = box1.Breadth - box2.Breadth,
                Width=box1.Width-box2.Width,
            };

            return box;
        }

        public static bool operator ==(Box box1,Box box2)
        {
            if((box1.Length==box2.Length) && (box1.Width==box2.Width) && (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Box box1,Box box2)
        {
            if ((box1.Length != box2.Length)&&(box1.Width != box2.Width) &&(box1.Breadth!=box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format($"Length , Breadth and Width = {this.Length} ,{this.Breadth} and {this.Width}");
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }

        public static explicit operator int (Box box)
        {
            return (int)(box.Length+box.Breadth+box.Width);
        }
    }
}
