public class SetupGameCommand : ICommand
{
    public void Execute()
    {
        App.screenManager.Show<InGameScreen>();
        App.screenManager.Show<WaveSetupScreen>();
        App.levelManager.Init();
    }

}
