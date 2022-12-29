using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var formated = string.Concat(word.Where(x => !char.IsPunctuation(x) && !char.IsSeparator(x) && !char.IsSymbol(x))).ToLower();
            return formated == string.Concat(formated.Reverse());

            //string reversedWord = "";

            //for (int i = word.Length - 1; i >= 0; i--) 
            //{
            //    reversedWord += word[i];
            //}
            //return (reversedWord.ToLower() == word.ToLower());            
        }
    }
}
