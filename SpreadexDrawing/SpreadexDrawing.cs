
namespace SpreadexDrawing
{
    public abstract class Widget
    {
        public int X { get; }
        public int Y { get; }

        protected Widget(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract override string ToString();
    }

    public class Rectangle : Widget
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "Width must be positive.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "Height must be positive.");

            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }

    public class Square : Widget
    {
        public int Size { get; }

        public Square(int x, int y, int size) : base(x, y)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException(nameof(size), "Size must be positive.");

            Size = size;
        }

        public override string ToString()
        {
            return $"Square ({X},{Y}) size={Size}";
        }
    }

    public class Ellipse : Widget
    {
        public int HorizontalDiameter { get; }
        public int VerticalDiameter { get; }

        public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
        {
            if (horizontalDiameter <= 0)
                throw new ArgumentOutOfRangeException(nameof(horizontalDiameter), "Horizontal diameter must be positive.");
            if (verticalDiameter <= 0)
                throw new ArgumentOutOfRangeException(nameof(verticalDiameter), "Vertical diameter must be positive.");

            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public override string ToString()
        {
            return $"Ellipse ({X},{Y}) diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
        }
    }

    public class Circle : Widget
    {
        public int Diameter { get; }

        public Circle(int x, int y, int diameter) : base(x, y)
        {
            if (diameter <= 0)
                throw new ArgumentOutOfRangeException(nameof(diameter), "Diameter must be positive.");

            Diameter = diameter;
        }

        public override string ToString()
        {
            return $"Circle ({X},{Y}) size={Diameter}";
        }
    }

    public class Textbox : Widget
    {
        public int Width { get; }
        public int Height { get; }
        public string Text { get; }

        public Textbox(int x, int y, int width, int height, string text) : base(x, y)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "Width must be positive.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "Height must be positive.");
            Text = text ?? throw new ArgumentNullException(nameof(text));

            Width = width;
            Height = height;
            Text = text;
        }

        public override string ToString()
        {
            return $"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
        }
    }

    class SpreadexDrawing
    {
        static void Main(string[] args)
        {
            var widgets = new List<Widget>
            {
                new Rectangle(10, 10, 30, 40),
                new Square(15, 30, 35),
                new Ellipse(100, 150, 300, 200),
                new Circle(1, 1, 300),
                new Textbox(5, 5, 200, 100, "sample text")
            };

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");
            foreach (var widget in widgets)
            {
                Console.WriteLine(widget.ToString());
            }
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}