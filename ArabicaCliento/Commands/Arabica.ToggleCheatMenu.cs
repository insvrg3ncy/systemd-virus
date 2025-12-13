using ArabicaCliento.Systems;
using ArabicaCliento.UI;
using Content.Shared.Administration;
using Robust.Client.UserInterface;
using Robust.Shared.Console;

namespace ArabicaCliento.Commands;

[AnyCommand]
public class ToggleCheatMenuCommand: IConsoleCommand
{
    public string Command => "systemd.toggle_menu";
    public string Description => "Эта команда переключает меню";
    
    public string Help => "systemd.toggle_menu";
    
    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        IoCManager.Resolve<IUserInterfaceManager>().GetUIController<ArabicaCheatMenuUiController>().ToggleMenu();
    }
}