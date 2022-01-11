public class ShowScreenCommand : ICommand
{
    public void Execute()
    {
        App.screenManager.Show<MenuScreen>();
    }
}
