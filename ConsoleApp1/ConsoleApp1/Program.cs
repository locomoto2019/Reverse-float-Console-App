using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse1("1234.56.78"));
            Console.WriteLine(Reverse2("1234.56.78"));
            Console.ReadLine();
        }

        static string Reverse2(string str)
        {
            int strLen = str.Length, elem = strLen - 1;
            char[] charA = new char[strLen];

            for (int i = 0; i < strLen; i++)
            {
                charA[elem] = str[i];
                elem--;
            }

            return new string(charA);
        }

        static string Reverse1(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length / 2; i++)
            {
                int tmp = charArray[i];
                charArray[i] = charArray[charArray.Length - i - 1];
                charArray[charArray.Length - i - 1] = (char)tmp;
            }
            return new string(charArray);
        }
    }
}
