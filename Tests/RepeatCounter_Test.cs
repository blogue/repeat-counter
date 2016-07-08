using Xunit;

namespace WordRepeatCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_thequickbrownfox_0()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(0, c.CountRepeats("the quick brown fox", "dog"));
    }
  }
}
