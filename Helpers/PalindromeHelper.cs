using PalindromeDetector.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDetector.Helpers
{
    public class PalindromeHelper 
    {
        private readonly IPalindrome _palindrome;

        public PalindromeHelper(IPalindrome palindrome)
        {
            _palindrome = palindrome;
        }
      

        public bool CheckPalindrome(string str)
        {
            var result = _palindrome.IsPalindrome(str);
            return result;
        }
    }
}
