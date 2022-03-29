using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP_Assessment_1
{
    class LongWordList
    {
        public void LongWord(string text)
        {
            //This will create an array to add ecah of the words.
            string[] words = text.Split(' ');

            //This will then create a list of the long words.
            List<string> LongWords = new List<string>();


            //It will cycle through the array of words, checking if any word is greater than 7, if so its added to the list.
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 7)
                {
                    LongWords.Add(words[i]);
                }
            }

            //Sets the file path to this location.
            string path = @"MyTest.txt";


            //This will create a file at the given file path.
            using (StreamWriter FinalWords = File.CreateText(path))
            {

                //This for loop will go through the word list again and write each element to the list.
                for (int i = 0; i < LongWords.Count; i++)
                {
                    FinalWords.WriteLine(LongWords[i]);
                }
            }
        }
    }
}
