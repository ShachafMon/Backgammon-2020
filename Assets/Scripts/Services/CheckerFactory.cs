namespace Assets
{
    public class CheckerFactory
    {
        public static Checker CreateChecker(PlayerColor color)
        {
            return new Checker(color);
        }
    }
}
