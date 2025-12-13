using Content.Shared.Administration;
using Robust.Client.Player;
using Robust.Shared.Console;

namespace ArabicaCliento.Commands;

[AnyCommand]
public class ArabicaPlayerList : IConsoleCommand
{
    public string Command => "systemd.player_list";
    public string Description => "Вывести список игроков";
    public string Help => "systemd.player_list";

    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        var man = IoCManager.Resolve<IPlayerManager>();
        foreach (var ses in man.Sessions)
        {
            shell.WriteLine(ses.Name);
        }
    }
}