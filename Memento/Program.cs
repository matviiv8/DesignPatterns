using Memento;

class Program
{
    static void Main(string[] args)
    {
        var player = new Player(100, 1, "Start");
        var saveManager = new SaveManager();

        player.ShowStatus();

        saveManager.SaveGame(player.Save());

        player.UpdateState(80, 2, "Forest");
        saveManager.SaveGame(player.Save());

        player.UpdateState(50, 3, "Dungeon");

        Console.WriteLine("\nRolling back...\n");

        player.Restore(saveManager.LoadLastSave());
        player.ShowStatus();

        player.Restore(saveManager.LoadLastSave());
        player.ShowStatus();
    }
}