namespace Bridge
{
    public abstract class Shape
    {
        protected IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
