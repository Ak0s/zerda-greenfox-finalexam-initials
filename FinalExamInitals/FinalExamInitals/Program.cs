using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a function that takes a list of strings and a letter and returns a string
// where the strings are joined with the given letter like: ["ab", "cde", "fg"] and " " becomes "ab cde fg"

namespace FinalExamInitals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "ab", "cde", "fg", "hi", "jk", "lmn"};

            string output1 = concatListWithDelimeterUsingLINQ(strings, '|');
            string output2 = concatListWithDelimeterUsingForeach(strings, '|');
            string output3 = concatListWithDelimeterUsingFor(strings, '|');
            string output4 = concatListWithDelimeterUsingWhile(strings, '|');

            Console.WriteLine(output1 + "\n" + output2 + "\n" + output3 + "\n" + output4);
        }

        static string concatListWithDelimeterUsingLINQ(List<string> listOfStrings, char letter)
        {
            return listOfStrings.Aggregate((i, j) => i + letter + j);
        }

        static string concatListWithDelimeterUsingForeach(List<string> listOfStrings, char letter)
        {
            string output = "";
            foreach(string element in listOfStrings)
            {
                output += !element.Equals(listOfStrings.Last()) ? element + letter : element;
            }
            return output;
        }

        static string concatListWithDelimeterUsingFor(List<string> listOfStrings, char letter)
        {
            string output = "";
            for (int i = 0; i < listOfStrings.Count; ++i)
            {
                output += i != listOfStrings.Count - 1 ? listOfStrings[i] + letter : listOfStrings[i];
            }
            return output;
        }

        static string concatListWithDelimeterUsingWhile(List<string> listOfStrings, char letter)
        {
            string output = "";
            int i = 0;
            while (i != listOfStrings.Count)
            {
                output += i != listOfStrings.Count - 1 ? listOfStrings[i] + letter : listOfStrings[i];
                ++i;
            }
            return output;
        }
    }
}
