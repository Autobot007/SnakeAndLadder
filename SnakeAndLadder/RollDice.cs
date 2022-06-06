namespace SnakeLadder
{
    internal class RollDice
    {
        Random diceroll = new();
        public int rolldice()
        {
           int dice= diceroll.Next(1, 7);
            Console.WriteLine(dice);
            return dice;
        }
    }
}