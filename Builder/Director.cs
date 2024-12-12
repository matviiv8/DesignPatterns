namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSimpleHouse()
        {
            _builder.BuildWalls();
            _builder.BuildRoof();
        }

        public void BuildFullHouse()
        {
            _builder.BuildWalls();
            _builder.BuildFloor();
            _builder.BuildRoof();
        }
    }

}
