namespace Builder
{
    public class House
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string Describe()
        {
            return "House parts: " + string.Join(", ", _parts);
        }
    }
}
