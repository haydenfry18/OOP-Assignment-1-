using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = false;
            bool FileChoice = false;
            //string file;

            //string FileName = @"C:\Users\hayde\OneDrive\Desktop\TestWords.txt";
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            while(choice == false)
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
                    while (FileChoice == false)
                    {
                        //takes user input of file directory 
                        Console.WriteLine("please enter the directory of the file you would like to use");
                        string fileName = Console.ReadLine();

                        //This try statement will run this section if the file path is correct.
                        try
                        {
                            //This will create a new object to open a file with pre-set words and do a count of those words.
                            Input wordchecker = new Input();
                            wordchecker.FileTextInput(fileName);

                            //Closes the loops.
                            FileChoice = true;
                            choice = true;
                            break;
                        }
                        //If the file path is incorrect then this message will display and the path can be typed in again.
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("file not found, please try again");
                        }

                    }
                }
                else
                {
                    //This will handle any errors, ensuring only T or P are entered.
                    Console.WriteLine("That was an invalid input! Please enter your choice again!");
                }
            }



            //Receive a list of integers back
            //Report the results of the analysis
            Report WordReport = new Report();
            WordReport.OutputData(Analyse.values);

            //TO ADD: Get the frequency of individual letters?
            // ~ Added amount of total letters.
        }
    }
}
