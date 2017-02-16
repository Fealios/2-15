using System;
using System.Collections.Generic;

namespace Palindrome.Objects
{
  public class Pali
  {
    private string _inputString;

    public Pali(string input)
    {
      _inputString = input;
    }

    public bool PalindromeResult()
    {
      if (GetInput().Substring(0, 1).ToLower() == GetInput().Substring(GetInput().Length - 1).ToLower())
      {
        string[] holder = GetInput().ToLower().Split(null);
        string concat = String.Join("", holder);
        char[] letterArray = concat.ToCharArray();
        for(var i = 0; i<letterArray.Length; i++)
        {
          if(letterArray[i] != letterArray[letterArray.Length - i - 1])
          {
            return false;
          }
        }
        return true;
      }
      else
      {
        return false;
      }
    } //end palindrom check

    public string Reverse()
    {
      string reverse = "";
      for(var r=GetInput().Length-1; r >= 0; r--)
      {
        reverse += (GetInput().Substring(r, 1));
      }

      return reverse;
    }

    public string GetInput()
    {
      return _inputString;
    }

    public void SetInput(string input)
    {
      _inputString = input;
    }
  }
}
