namespace SnakeLadder;
public class SnakeLadderuc3
{
   public int PLAYER1_POS = 10;
    public int DICE;
    public int DICE_ROLLED = 0;
    public int PLAYCHECK=0;
    public static void Main(string[] args)
    {
        SnakeLadderuc3 obj = new();
        obj.Dice();
        obj.playcheck();

        
    }
    public void playcheck()
    {
        Random playcheck = new();
        int PLAYCHECK = Convert.ToInt32(playcheck.Next(0, 3));
        switch (PLAYCHECK)
        {
            case 0:
                //No Play
                PLAYER1_POS++;
                DICE_ROLLED++;
                Console.WriteLine("DICE ROLLED"+DICE_ROLLED);
                Console.WriteLine("DICE " + DICE);
                Console.WriteLine("NO PLAY");
                Console.WriteLine("NO PLAY" + PLAYER1_POS);

                break;
            case 1:
                //Ladder
                PLAYER1_POS += DICE;
                DICE_ROLLED++;
                Console.WriteLine("DICE ROLLED" + DICE_ROLLED);
                Console.WriteLine("DICE " + DICE);
                Console.WriteLine("LADDER");
                Console.WriteLine("LADDER"+PLAYER1_POS);
                break;
            case 2:
                //snake
                PLAYER1_POS -= DICE;
                DICE_ROLLED++;
                Console.WriteLine("DICE ROLLED" + DICE_ROLLED);
                Console.WriteLine("DICE " + DICE);
                Console.WriteLine("SNAKE");
                Console.WriteLine("SNAKE" + PLAYER1_POS);
                break;

        }
    }
    public void Dice()
    {
        Random dice = new();
        DICE = dice.Next(1, 7);

    }
    
}