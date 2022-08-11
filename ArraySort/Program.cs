using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class Sort
{
    public static void arraySorting(int[] array)
    {
        int newValue;
        int currentValue;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        

        for (int i = 0; i < array.Length; i++)
        {
            currentValue = array[i];
            newValue = (int)Math.Floor(Math.Log10(currentValue) + 1);
            if (newValue == 1)
            {
                count1++;
            }
            if (newValue > 1 && newValue < 3)
            {
                count2++;
            }
            if (newValue > 2 && newValue < 4)
            {
                count3++;

            }

        }
        if (count1 > count2 && count1 > count3)
        {
            Console.WriteLine("The longest consecutive elements sequence of 1 digit is " + count1);
        }
        if (count2 > count1 && count2 > count3)
        {
            Console.WriteLine("The longest consecutive elements sequence of 2 digits are " + count2);
        }
        if (count3 > count2 && count3 > count1)
        {
            Console.WriteLine("The longest consecutive elements sequence of 3 digits are " + count3);
        }
        else
        {
            Console.WriteLine("Maximum 3 digits number");
        }
        Console.Read();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Enter the Integers : ");
        input = Console.ReadLine();
        Convert(input);


    }

    public static int[] Convert(string stringToIntArray)
    {
        int[] convert = null;
        Regex regex = new Regex(@"^[\d ]+$");
        if (regex.IsMatch(stringToIntArray))
        {
            if (stringToIntArray.Contains(" ") == true)
            {
                try
                {
                    int[] array = stringToIntArray.Split(' ').Select(int.Parse).ToArray();
                    convert = array;
                    Sort.arraySorting(array);
                }
                catch (Exception)
                {
                    Console.WriteLine("Format is not correct, to find longest consecutive elements sequence length is at least 2 numbers");
                    //throw new FormatException("Format is not correct, to find longest consecutive elements sequence length is at least 2 numbers");
                }

                //return array;
            }
            else
            {
                Console.WriteLine("Please enter the right input, spaces are missing");
            }
        }
        else
        {
            Console.WriteLine("Please enter the only positive integers");
        }
        return convert;
    }
}
