using Xunit;

namespace WordRepeatCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_thequickbrownfox_dog_0()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(0, c.CountRepeats("the quick brown fox", "dog"));
    }
    [Fact]
    public void RepeatCounter_thequickbrownfox_fox_1()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(1, c.CountRepeats("the quick brown fox", "fox"));
    }
    [Fact]
    public void RepeatCounter_thequickbrownfoxfox_fox_2()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(2, c.CountRepeats("the quick brown fox fox", "fox"));
    }
    [Fact]
    public void RepeatCounter_thequickbrownfoxFOXfOx_fox_3()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(3, c.CountRepeats("the quick brown fox FOX fOx", "fox"));
    }
    [Fact]
    public void RepeatCounter_thequickbrownfoxdoesthefoxtrot_fox_1()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(1, c.CountRepeats("the quick brown fox does the foxtrot", "fox"));
    }
    [Fact]
    public void RepeatCounter_thequickbrownfoxperiod_fox_1()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(1, c.CountRepeats("the quick brown fox.", "fox"));
    }
  }
}
