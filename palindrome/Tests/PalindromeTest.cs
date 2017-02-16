using Xunit;
using System.Collections.Generic;

namespace Palindrome.Objects
{
  public class PaliTest
  {
    [Fact]
    public void Pali_ReturnEnteredString_true()
    {
      Pali testPali = new Pali("word");
      Assert.Equal("word", testPali.GetInput());
    }

    [Fact]
    public void Pali_CheckIfFirstLetterIsLast_true()
    {
      Pali testPali = new Pali("wow");
      Assert.Equal(true, testPali.PalindromeResult());
    }

    [Fact]
    public void Pali_CheckSingleWordPali_true()
    {
      Pali testPali = new Pali("wow");
      Assert.Equal(true, testPali.PalindromeResult());
    }

    [Fact]
    public void Pali_CheckSingleWordPali_false()
    {
      Pali testPali = new Pali("word");
      Assert.Equal(false, testPali.PalindromeResult());
    }

    [Fact]
    public void Pali_CheckSentencePaliSpaceIrrelevent_true()
    {
      Pali testPali = new Pali("sore was i ere i saw eros");
      Assert.Equal(true, testPali.PalindromeResult());
    }

    [Fact]
    public void Pali_CheckSentencePaliSpaceIrreleventCaseIrrelevent_true()
    {
      Pali testPali = new Pali("Sore was I ere I saw Eros");
      Assert.Equal(true, testPali.PalindromeResult());
    }

    [Fact]
    public void Pali_CheckPalindromeCaseAndSpaceInsensitive_true()
    {
      Pali testPali = new Pali("Euston saw I was not Sue");
      Assert.Equal(true, testPali.PalindromeResult());
    }

    [Fact]
    public void Pali_CheckPalindromeCaseAndSpaceInsensitiveAlsoNumber_true()
    {
      Pali testPali = new Pali("1Euston saw I was not Sue1");
      Assert.Equal(true, testPali.PalindromeResult());
    }
  }
}
