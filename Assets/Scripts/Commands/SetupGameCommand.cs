public class SetupGameCommand : ICommand
{
    public void Execute()
    {
        App.screenManager.Show<InGameScreen>();
        App.levelManager.Init();
    }

}
