using System;
using System.Collections.Generic;

namespace SearchAndDestroy.Objects
{
  public class Replace
  {
    private string _inputString;
    private string _targetStuff;
    private string _newString;

    public Replace(string inputString, string targetStuff, string newString)
    {
      _inputString = inputString;
      _targetStuff = targetStuff;
      _newString = newString;
    }

    public string GetInput()
    {
      return _inputString;
    }

    public string GetTargetString()
    {
      return _targetStuff;
    }

    public string GetNewString()
    {
      return _newString;
    }

    public void SetInputString(string input)
    {
      _inputString = input;
    }
    //End getters and setters

    public string FindAndReplace()
    {
      string[] inputArr = GetInput().Split(' ');
      for (int i = 0; i < inputArr.Length; i++)
      {
        if (GetTargetString() == inputArr[i])
        {
          inputArr[i] = GetNewString();
        }
        else
        {    
          if(inputArr[i].Length < GetTargetString().Length)
          {      
            continue;
          }
          else
          {      
            for(var j = 0; j<=(inputArr[i].Length - GetTargetString().Length); j++)
            {        
              if(inputArr[i].Substring(j, GetTargetString().Length) == GetTargetString())
              {                              
                inputArr[i] = (inputArr[i].Substring(0, j) + GetNewString() + inputArr[i].Substring(j + GetTargetString().Length));
              }
              else
              {                              
                continue;
              }
            }
          }
        }
      }
      SetInputString(String.Join(" ", inputArr));

      return GetInput();
    }
  } //end class
} //end namespace
