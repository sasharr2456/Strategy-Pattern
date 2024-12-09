using Strategy_Pattern;

public interface IWeapon
{
    void UseWeapon();
}


class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}