namespace Bridge
{
    class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using Vector Renderer.");
        }
    }
}
