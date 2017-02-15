using Xunit;
using System.Collections.Generic;

namespace SearchAndDestroy.Objects
{
  public class ReplaceTest
  {
    [Fact]
    public void GetInput_ReturnsSameInput_true()
    {
      Replace testSearch = new Replace("Hello", "Hello", "Hello");
      Assert.Equal("Hello", testSearch.GetInput());
    }

    [Fact]
    public void FindAndReplace_ReplacesSingleWord_true()
    {
      Replace testSearch = new Replace("Hello", "Hello", "World");
      Assert.Equal("World", testSearch.FindAndReplace());
    }

    [Fact]
    public void FindAndReplace_ReplacesSingleWordInSentence_true()
    {
      Replace testSearch = new Replace("Hello World my old friend", "World", "Darkness");
      Assert.Equal("Hello Darkness my old friend", testSearch.FindAndReplace());
    }

    [Fact]
    public void GetInput_StringLengthPlus1_true()
    {
      Replace testSearch = new Replace("Hello", "ello", "text");
      Assert.Equal("Htext", testSearch.FindAndReplace());
    }

    [Fact]
    public void FindAndReplace_ReplacePartialStringWithTarget_True()
    {
      Replace testSearch = new Replace("Mellow bellow yellow jello fellow", "ello", "text");
      Assert.Equal("Mtextw btextw ytextw jtext ftextw", testSearch.FindAndReplace());
    }
  }
}
