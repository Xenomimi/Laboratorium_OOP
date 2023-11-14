namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle 
            { 
                Y = 0,
                X = 0,
                Height = 4,
                Width = 5
            };

            Circle circle = new Circle
            {
                Y = 10,
                X = 0,
                Height = 4,
                Width = 5
            };

            Triangle triangle = new Triangle
            {
                Y = 20,
                X = 0,
                Height = 4,
                Width = 5
            };

            List<Shape> shapes = new List<Shape>();

            shapes.Add(rectangle);
            shapes.Add(circle);
            shapes.Add(triangle);

            foreach (var item in shapes)
            {
                item.Draw();
            }
        }
    }
}