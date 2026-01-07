using ShapeFactoryApp.Factories;

namespace ShapeFactoryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shape Factory ...");

            App app = new App();
            app.RegisterFactory<CircleFactory>();
            app.RegisterFactory<SquareFactory>();
            app.RegisterFactory<RectangleFactory>();
            app.RegisterFactory<TriangleFactory>();

            app.EnumerateRegisteredFactories(); // Optional for debug
            app.Run();
        }
    }
}
