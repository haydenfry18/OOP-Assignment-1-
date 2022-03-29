using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_1
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        
        public void OutputData(List<int> values)
        {

            //This will join a string with each number in the list according to what it means.
            Console.WriteLine("Numbers of sentences:" + values[0]);
            Console.WriteLine("Numbers of vowels:" + values[1]);
            Console.WriteLine("Numbers of consonants:" + values[2]);
            Console.WriteLine("Numbers of upper case letters:" + values[3]);
            Console.WriteLine("Numbers of lower case letters:" + values[4]);
            Console.WriteLine("Numbers of total letters:" + values[5]);

        }
    }
}
