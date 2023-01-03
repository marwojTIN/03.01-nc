using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._01_Netcompany
{
    public class Tasks
    {
        static void Main(string[] args)
        {

        }

        public static bool ValidatePIN(string pin)
        {
            return Regex.IsMatch(pin, "^(\\d{4}|\\d{6})$");
        }

        public static bool IsNumberPalindrome(int num)
        {
            return num.ToString() == string.Concat(num.ToString().Reverse().ToArray());
        }

        public static bool IsWordIsogram(string word)
        {
            var letters = word.ToLower().ToCharArray();

            Array.Sort(letters, StringComparer.OrdinalIgnoreCase);

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (letters[i] == letters[i + 1])
                {
                    return false;
                }
            }

            return true;
            // word.ToLower().Distinct();
        }

        public static string ReverseCase(string str)
        {
            char[] str2 = str.ToCharArray();
            string reversed = "";
            for (int i = 0; i < str2.Length; i++)
            {
                if (Char.IsLower(str2[i]))
                    reversed += Char.ToUpper(str2[i]);
                else
                    reversed += Char.ToLower(str2[i]);
            }
            return reversed;
        }

        public static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n1, n2%n1);
            }
        }

        public static string Maskify(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length - 4; i++)
            {
                chars[i] = '#';
            }

            return new string(chars);
        }

    }
}
