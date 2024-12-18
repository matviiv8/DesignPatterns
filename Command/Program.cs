using Command;

class Program
{
    static void Main(string[] args)
    {
        var editor = new TextEditor();
        var manager = new CommandManager();

        Console.WriteLine("=== Start Editing ===");
        manager.ExecuteCommand(new AddTextCommand(editor, "Hello"));
        manager.ExecuteCommand(new AddTextCommand(editor, " World"));
        editor.ShowText();

        Console.WriteLine("\n=== Undo Last Action ===");
        manager.UndoLastCommand();
        editor.ShowText();

        Console.WriteLine("\n=== Undo Last Action ===");
        manager.UndoLastCommand();
        editor.ShowText();

        Console.WriteLine("\n=== Undo Last Action ===");
        manager.UndoLastCommand();
    }
}