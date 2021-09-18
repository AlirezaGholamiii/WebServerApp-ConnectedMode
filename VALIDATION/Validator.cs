using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Lab1_ASPNetConnectedMode.VALIDATION
{
    public class Validator
    {

        public static bool IsValidId(string input)
        {
            if (!(Regex.IsMatch(input, @"^\d{4}$")))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidId(string input, int size)
        {
            if (!(Regex.IsMatch(input, @"^\d{" + size + "}$")))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidName(string input)
        {

            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]) && (!Char.IsWhiteSpace(input[i])))
                {
                    return false;
                }

            }

            return true;
        }

        public static bool IsEmpty(string input)
        {
            if (input.Length == 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsAWord(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    return true;
                }
            }
                return false;
        }

    }
}