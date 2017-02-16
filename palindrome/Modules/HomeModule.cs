using Nancy;
using Palindrome.Objects;
using System.Collections.Generic;
using System;

namespace Palindrome
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
              return View["index.cshtml"];
            };

            Post["/submit"] = _ =>
            {
              Pali newPalindrome = new Pali(Request.Form["input"]);
              if(newPalindrome.PalindromeResult())
              {
                return View["success.cshtml", newPalindrome];
              }
              else
              {
                return View["fail.cshtml", newPalindrome];
              }
            };

        }
    }
}
