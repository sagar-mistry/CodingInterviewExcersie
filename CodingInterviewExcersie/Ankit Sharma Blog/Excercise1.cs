using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExcersie.Ankit_Sharma_Blog
{
    public static class Excercise1
    {
        public static string ReverseString(this string input)
        {
            string result = string.Empty;
            try
            {
                char[] charArray = input.ToCharArray();
                int index = input.Length - 1;
                foreach (char alphabet in input)
                {
                    charArray[index] = alphabet;
                    index--;
                }
                result = new string(charArray);
            }
            catch (Exception ex)
            {
                Console.Write($"Exception occurred : {ex}");
            }
            return result;
        }

        public static string CheckIfInputIsPalindrome(this string input)
        {
            string result = "Palidrom";
            try
            {
                char[] inputArr = input.ToCharArray();
                int length = inputArr.Length - 1;
                foreach (var alphabet in input)
                {
                    if (alphabet != inputArr[length])
                    {
                        result = "Not Palidrom";
                        break;
                    }
                    length--;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public static string ReverseTheWords(this string input)
        {
            string result = string.Empty;
            try
            {
                string[] inputArr = input.Split(" ");
                string[] outputArr = new string[inputArr.Length];
                foreach (var word in inputArr)
                {
                    result = word + " " + result;
                }
            }
            catch (Exception ex)
            {
                result = $"Error : {ex.Message}";
            }
            return result;
        }

        public static string ReverseWordsReverseEachAlphabets(this string input)
        {
            string result = string.Empty;
            try
            {
                string[] inputArray = input.Split(" ");
                foreach (var word in inputArray)
                {
                    char[] wordArray = word.ToCharArray();
                    char[] reverseWordArray = new char[wordArray.Length];
                    int index = wordArray.Length - 1;
                    for (int i = 0; i < wordArray.Length; i++)
                    {
                        reverseWordArray[i] = wordArray[index];
                        index--;
                    }
                    string reversedWord = new string(reverseWordArray);
                    result = reversedWord + " " + result;
                }
            }
            catch (Exception ex)
            {

                result = $"Error :{ex.ToString()}";
            }
            return result;
        }

        public static string CountEachAlphabetsInString(this string input)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                Dictionary<char, int> countDictionary = new Dictionary<char, int>();
                foreach (var letter in input)
                {
                    if (char.IsWhiteSpace(letter))
                        continue;
                    if (countDictionary.ContainsKey(letter))
                    {
                        if (countDictionary.TryGetValue(letter, out int value))
                        {
                            value++;
                            countDictionary[letter] = value;
                        }
                    }
                    else
                    {
                        countDictionary.Add(letter, 1);
                    }
                }
                foreach (var item in countDictionary)
                {
                    result.AppendLine($"Letter : {item.Key} - Count :{item.Value}");
                }
            }
            catch (Exception ex)
            {
                result.Append($"Error : {ex}");
            }
            return result.ToString();
        }

        public static string RemoveDuplicateCharactersFromString(this string input)
        {
            string result = string.Empty;
            try
            {
                foreach (var letter in input)
                {
                    if (!result.Contains(letter))
                    {
                        result += letter;
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public static string FindAllPossibleSubstrings(this string input)
        {
            string result = string.Empty;
            try
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = i; j < input.Length; ++j)
                    {
                        builder.Append(input[j]);
                    }
                }
                result = builder.ToString();
            }
            catch (Exception)
            {

                return string.Empty;
            }
            return result;
        }

        // INPUT- 1,2,3,4,5
        //OUTPUT- 2,3,4,5,1
        public static int[] LeftCircularShiftOfArray(this int[] array)
        {
            int[] output = new int[array.Length];
            int firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                output[i] = array[i + 1];
            }
            output[array.Length - 1] = firstElement;
            return output;
        }
    }
}
