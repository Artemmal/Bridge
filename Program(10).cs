using System;

namespace HW23._4
{
    abstract class Figure
    {
        public abstract void Type();
    }
    class Circle : Figure
    {
        public override void Type()
        {
            Console.WriteLine("Circle");
        }
    }
    class Square : Figure
    {
        public override void Type()
        {
            Console.WriteLine("Square");
        }
    }
    class Rectangle : Figure
    {
        public override void Type()
        {
            Console.WriteLine("Rectangle");
        }
    }

    abstract class Colour
    {
        protected Figure figure;
        public Figure Figure
        {
            set { figure = value; }
        }
        public Colour(Figure fig)
        {
            figure = fig;
        }
        public virtual void FigureType()
        {
            figure.Type();
        }
        public abstract void Paint();
    }

    class Red : Colour
    {
        public Red(Figure fig) : base(fig)
        {
        }
        public override void Paint()
        {
            Console.WriteLine("Red");
        }
    }

    class Blue : Colour
    {
        public Blue(Figure fig) : base(fig)
        {
        }
        public override void Paint()
        {
            Console.WriteLine("Blue");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Colour red = new Red(new Circle());
            red.FigureType();
            red.Paint();
            red.Figure = new Square();
            red.FigureType();
            red.Paint();
            Colour blue = new Blue(new Rectangle());
            blue.FigureType();
            blue.Paint();
            blue.Figure = new Square();
            blue.FigureType();
            blue.Paint();
        }
    }
}
