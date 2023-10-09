namespace Yatzy;

public class YatzyScorer
{
    public int Chance(int[] diceRolls)
    {
        return diceRolls.Sum();
    }
}