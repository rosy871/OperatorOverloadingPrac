using System;

namespace OperatorOverloadingPrac
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public void setLenght(double l)
        {
            length = l;
        }

        public void setBreadth(double b)
        {
            breadth = b;
        }

        public void setHeight(double h)
        {
            height = h;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }

        public static Box operator+ (Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.breadth = a.breadth + b.breadth;
            box.height = a.height + b.height;

            return box;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();
            Box b3 = new Box();

            double l, b, h, volume;
            Console.WriteLine("enter len, breadth and height of box 1");
            l = Convert.ToDouble(Console.ReadLine());
            b= Convert.ToDouble(Console.ReadLine());
            h= Convert.ToDouble(Console.ReadLine());

            b1.setLenght(l);
            b1.setBreadth(b);
            b1.setHeight(h);

            volume = b1.getVolume();
            Console.WriteLine("volume of box1 is : {0}", volume);

            Console.WriteLine("\n\nenter len, breadth and height of box 2");
            l = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
           
            b2.setLenght(l);
            b2.setBreadth(b);
            b2.setHeight(h);

            volume = b2.getVolume();
            Console.WriteLine("volume of box2 is : {0}", volume);

            b3 = b1 + b2;

            volume = b3.getVolume();

            Console.WriteLine("\n\ncalculated volume of box3 is : {0}", volume);








            Console.ReadKey();

        }
    }
}
