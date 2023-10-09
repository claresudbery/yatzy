namespace Yatzy;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Chance()
    {
        // Arrange
        var diceRolls = new[] { 1, 1, 1, 1, 1 };
        var yatzyScorer = new YatzyScorer();
        
        // Act
        var result = yatzyScorer.Chance(diceRolls);
        
        // Assert
        Assert.AreEqual(5, result);
    }
}