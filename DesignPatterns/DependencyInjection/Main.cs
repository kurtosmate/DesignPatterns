namespace DesignPatterns.DependencyInjection
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Inject dependency in constructor
            Game game1 = new Game(new KeyboardGamepad());
            game1.HowToMoveUp();

            Game game2 = new Game(new XboxGamepad());
            game2.HowToMoveUp();
        }
    }
}
