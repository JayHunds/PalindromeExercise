using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            // Convert the word to lowercase to ignore case sensitivity
            word = word.ToLower();

            // Initialize pointers for the start and end of the word
            int left = 0;
            int right = word.Length - 1;

            // Traverse the word from both ends towards the middle
            while (left < right)
            {
                // Skip non-alphanumeric characters
                if (!char.IsLetterOrDigit(word[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(word[right]))
                {
                    right--;
                    continue;
                }

                // If characters at left and right pointers don't match, it's not a palindrome
                if (word[left] != word[right])
                {
                    return false;
                }

                // Move pointers towards the middle
                left++;
                right--;
            }

            // If the loop completes without finding any mismatch, it's a palindrome
            return true;
        }
    }
}
