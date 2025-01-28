namespace demobranching;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    [Fact]
    public void FalseFsFalseAndStringIsEmpty()
    {
        Assert.False(true);
        Assert.Empty("");
    }
}