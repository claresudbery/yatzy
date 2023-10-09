namespace Yatzy;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(5, 1, 1, 1, 1, 1)]
    public void Chance(int expected, int die1, int die2, int die3, int die4, int die5)
    {
        // Arrange
        var diceRolls = new[] { die1, die2, die3, die4, die5 };
        var yatzyScorer = new YatzyScorer();
        
        // Act
        var result = yatzyScorer.Chance(diceRolls);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}