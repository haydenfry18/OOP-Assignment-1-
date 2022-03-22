using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1
{
    public class Analyse
    {
        public static List<int> values = new List<int>();
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //This will assign all the important variables for the analysis.
            int Sentences = 0, Vowels = 0, Consonants = 0, UpperCase = 0, LowerCase = 0, Individual = 0;

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            
            
            //Analyses the text until it reaches the end of the string.
            for (int i = 0; i < input.Length; i++)
            {
                //Keeps track of total amount of letters.
                Individual++;

                //This counts how many full stops there are in the string, meaning how many sentences there are.
                if (input[i] == '.')
                {
                    Sentences++;
                }

                //This will detect lower and upper case vowels and increment the counter.
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    Vowels++;
                }

                //This will detect lower and upper case consonants there are and increment the counter.
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    Consonants++;
                }

                //These will detect any upper and lower character and increment them respectively.
                if (char.IsUpper(input[i]))
                {
                    UpperCase++;
                }
                if (char.IsLower(input[i]))
                {
                    LowerCase++;
                }
            }
            
            //Inserts each of the variables into the list so it can be displayed in Report.cs.
            values.Insert(0, Sentences);
            values.Insert(1, Vowels);
            values.Insert(2, Consonants);
            values.Insert(3, UpperCase);
            values.Insert(4, LowerCase);
            values.Insert(5, Individual);


            return values;
        }
    }
}
