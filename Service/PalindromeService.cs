using PalindromeDetector.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDetector.Service
{
    public class PalindromeService : IPalindrome
    {
        public bool IsPalindrome(string str)
        {
            // clean data by removing whitespace and digits
            string validateStr = new string(str.Where(char.IsLetterOrDigit).ToArray());

            // Convert to lowercase
            validateStr = validateStr.ToLower();

            // Compare to reverse
            return validateStr == new string(validateStr.Reverse().ToArray());
        }

        
    }
}
