using PalindromeDetector.Helpers;
using PalindromeDetector.Service;

Console.WriteLine("Hello, World!, welcome to my Palindrome checker");



Console.WriteLine("Please Enter a Word or Phrase To Check if it is a Palindrome");

string theWordToCheck = Console.ReadLine();
if(theWordToCheck == null|| theWordToCheck.Length == 0)
{
    Console.WriteLine("No input was entered");
    Environment.Exit(0);
}


var palindromeTxt = new PalindromeService();
var checker = new PalindromeHelper(palindromeTxt);
var chkResult = checker.CheckPalindrome(theWordToCheck);
if (chkResult)
{
    Console.WriteLine($"The check of {theWordToCheck} is Palindrome and result is : {chkResult}");
}
else
{
    Console.WriteLine($"The check of {theWordToCheck} is not a Palindrome. Therefore result : {chkResult}");
}
Console.WriteLine("Press any key to exit this check");

Console.ReadKey();
