namespace Builder
{
    public class HouseBuilder : IBuilder
    {
        private House _house = new House();

        public HouseBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _house = new House();
        }

        public void BuildWalls()
        {
            _house.Add("Walls");
        }

        public void BuildRoof()
        {
            _house.Add("Roof");
        }

        public void BuildFloor()
        {
            _house.Add("Floor");
        }

        public House GetResult()
        {
            House result = _house;
            Reset();
            return result;
        }
    }
}
