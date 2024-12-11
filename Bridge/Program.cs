using Bridge;

class Program
{
    static void Main(string[] args)
    {
        IRenderer vectorRenderer = new VectorRenderer();
        Shape circle = new Circle(vectorRenderer, 5);
        circle.Draw();
        circle.Resize(2);
        circle.Draw();

        Console.WriteLine();

        IRenderer rasterRenderer = new RasterRenderer();
        circle = new Circle(rasterRenderer, 3);
        circle.Draw();
        circle.Resize(1.5f);
        circle.Draw();
    }
}