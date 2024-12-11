namespace Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using Raster Renderer.");
        }
    }
}
