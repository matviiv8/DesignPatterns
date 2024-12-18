namespace Command
{
    public class TextEditor
    {
        private string _text = "";

        public void AddText(string newText)
        {
            _text += newText;
            Console.WriteLine($"Text added: \"{newText}\"");
        }

        public void RemoveText(int length)
        {
            if (length > _text.Length)
            {
                length = _text.Length;
            }
            string removed = _text.Substring(_text.Length - length);
            _text = _text.Substring(0, _text.Length - length);
            Console.WriteLine($"Text removed: \"{removed}\"");
        }

        public void ShowText()
        {
            Console.WriteLine($"Current text: \"{_text}\"");
        }
    }
}
