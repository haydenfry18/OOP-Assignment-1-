using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"C:\Users\hayde\OneDrive\Desktop\TestWords.txt";
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            while (true)
            {
                //Allows user to decide if they want a file to print out or type in words to be counted.
                Console.WriteLine("1.Do you want to enter text via the keyboard?");
                Console.WriteLine("2.Do you want to read in the text from a file?");
                string UserChoice = Console.ReadLine();
                if (UserChoice == "1")
                {
                    //This will create a new object to allow the user to input their words.
                    Input wordchecker = new Input();
                    wordchecker.manualTextInput();
                    break;
                }
                else if (UserChoice == "2")
                {
                    //This will create a new object to open a file with pre-set words and do a count of those words.
                    Input wordchecker = new Input();
                    wordchecker.FileTextInput(FileName);
                    break;
                }
                else
                {
                    //This will handle any errors, ensuring only T or P are entered.
                    Console.WriteLine("That was an invalid input! Please enter your choice again!");
                }
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            
            Analyse WordAnalyser = new Analyse();
            WordAnalyser.analyseText(Input.text);

            //Receive a list of integers back
            //Report the results of the analysis
            Report WordReport = new Report();
            WordReport.OutputData(Analyse.values);

            //TO ADD: Get the frequency of individual letters?
            // ~ Added amount of total letters.
        }
    }
}
