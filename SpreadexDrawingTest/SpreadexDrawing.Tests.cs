using SpreadexDrawing;


namespace SpreadexDrawingTest
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ValidParameters_CreatesRectangle()
        {
            var rectangle = new Rectangle(10, 20, 30, 40);

            Assert.Multiple(() =>
            {
                Assert.That(rectangle.X, Is.EqualTo(10));
                Assert.That(rectangle.Y, Is.EqualTo(20));
                Assert.That(rectangle.Width, Is.EqualTo(30));
                Assert.That(rectangle.Height, Is.EqualTo(40));
            });
        }

        [Test]
        public void Constructor_NegativeWidth_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(10, 20, -30, 40));
        }

        [Test]
        public void Constructor_NegativeHeight_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(10, 20, 30, -40));
        }

        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            var rectangle = new Rectangle(10, 20, 30, 40);
            Assert.That(rectangle.ToString(), Is.EqualTo("Rectangle (10,20) width=30 height=40"));
        }
    }

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_ValidParameters_CreatesCircle()
        {
            var circle = new Circle(10, 20, 30);

            Assert.Multiple(() =>
            {
                Assert.That(circle.X, Is.EqualTo(10));
                Assert.That(circle.Y, Is.EqualTo(20));
                Assert.That(circle.Diameter, Is.EqualTo(30));
            });
        }

        [Test]
        public void Constructor_NegativeDiameter_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(10, 20, -30));
        }

        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            var circle = new Circle(10, 20, 30);
            Assert.That(circle.ToString(), Is.EqualTo("Circle (10,20) size=30"));
        }
    }

    [TestFixture]
    public class TextboxTests
    {
        [Test]
        public void Constructor_ValidParameters_CreatesTextbox()
        {
            var textbox = new Textbox(10, 20, 30, 40, "Hello");

            Assert.Multiple(() =>
            {
                Assert.That(textbox.X, Is.EqualTo(10));
                Assert.That(textbox.Y, Is.EqualTo(20));
                Assert.That(textbox.Width, Is.EqualTo(30));
                Assert.That(textbox.Height, Is.EqualTo(40));
                Assert.That(textbox.Text, Is.EqualTo("Hello"));
            });
        }

        [Test]
        public void Constructor_NullText_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Textbox(10, 20, 30, 40, null));
        }

        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            var textbox = new Textbox(10, 20, 30, 40, "Hello");
            Assert.That(textbox.ToString(), Is.EqualTo("Textbox (10,20) width=30 height=40 Text=\"Hello\""));
        }
    }
}