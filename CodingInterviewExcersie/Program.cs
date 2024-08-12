// See https://aka.ms/new-console-template for more information
using CodingInterviewExcersie.Ankit_Sharma_Blog;

Console.WriteLine("Hello, World!");
Dictionary<string, string> questionAnswers = new Dictionary<string, string>();

//Question-1
string que1 = "Hello";
var reverseString = que1.ReverseString();
questionAnswers.Add("Reverse the string: " + que1, reverseString);

//Question-2
string que2 = "step on no pets";
var isPalindrom = que2.CheckIfInputIsPalindrome();
questionAnswers.Add("Is the string palidrome: " + que2, reverseString);

//Question-3
string que3 = "Hello World!";
var reverseSentence = que3.ReverseTheWords();
questionAnswers.Add("Reverse the Sentence: " + que3, reverseSentence);

//Question-4
string que4 = "Never judge a book by cover";
var reverseSentenceWithReversedAlphabets = que4.ReverseWordsReverseEachAlphabets();
questionAnswers.Add("Reverse the Sentence with Reversed alphabet: " + que4, reverseSentenceWithReversedAlphabets);

//Question-5
string que5 = "Never judge a book by cover";
var countOfEachLetters = que5.CountEachAlphabetsInString();
questionAnswers.Add("Count of each letters : " + que5, countOfEachLetters);

//Question-6
string que6 = "ManchesterUnited";
var removedDuplicateChars = que6.RemoveDuplicateCharactersFromString();
questionAnswers.Add("Removed duplicate chars in string : " + que6, removedDuplicateChars);

//Question-7
string que7 = "abcd";
var possibleSubstrings = que6.RemoveDuplicateCharactersFromString();
questionAnswers.Add("All possible substrings of string : " + que7, possibleSubstrings);

//Question-8
string que8 = "Left circular shift of 1,2,3,4,5";
int[] inputArray = [1, 2, 3, 4, 5];
int[] outputArray = inputArray.LeftCircularShiftOfArray();
questionAnswers.Add("All possible substrings of string : " + que8, string.Join(",", outputArray));


//Print all the questions and answers...
foreach (var item in questionAnswers)
{
    Console.WriteLine($"Question : {item.Key}");
    Console.WriteLine($"Answer : {item.Value}");
    Console.WriteLine($"----------------------------------------------------------------------");
}