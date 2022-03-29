using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Assessment_1
{
    
    public class Input
    {
        //Handles the text input for Assessment 1

        public static string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            //Loop to ensure the user inputs the correct information.
            while (true)
            {
                //Here the user can input thier words and it will check if an astericks is at the end of their word/s.
                Console.WriteLine("Enter text via the keyboard, type * at the end when finished: ");
                string UserData = Console.ReadLine();
                if (UserData.EndsWith("*"))
                {
                    text = UserData;
                    return text;
                }
                else
                {
                    //This will reject any words that do not finsh with an astericks.
                    Console.WriteLine("You have not finished off your words with *. Please type it in again!");

                }
            }
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput(string fileName)
        {
            while(true)
            {
                //Opens and reads file line by line.
                string[] lines = File.ReadAllLines(fileName);
                foreach (string Line in File.ReadAllLines(fileName))
                {
                    //Checks the file being read has an astericks at the end of the words.
                    if (Line.EndsWith("*"))
                    {
                        //This will print out what is in the file up to the astericks.
                        Console.WriteLine(Line);
                        return text;
                    }
                    else
                    {
                        //Once again this will check the file has an astericks, if not it will simply be the end of the program.
                        Console.WriteLine("This file doesnt contain a * to designate the end of your words! Please check file!");

                    }

                }

            }
        }
    }
}
