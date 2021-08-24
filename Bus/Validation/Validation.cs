using System;

namespace Validation
{
    public class Validation
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        public static bool IsIntValid(string value)
        {
            int i;
            return Int32.TryParse(value, out i);
        }
        public static bool IsMobileNoValid(string value)
        {
            if (value.Substring(0, 3) == "019" || value.Substring(0, 3) == "016" || value.Substring(0, 3) == "018" || value.Substring(0, 3) == "017")
            {
                if (value.Length == 11) return true;
                else return false;
            }
            else return false;    
        }
        public static bool IsAgeValid(string value)
        {
            int i = Int32.Parse(value);
            if (i < 8 || i > 70)
            {
                return false;
            }
            else return true;
        }
        public static bool IsValid(params bool[] Result)
        {

            for(int i=0;i<Result.Length;i++)
            {
                if (Result[i] == false) return false;
            }
            return true;
        }
        public static bool count(int value)
        {
            if (value > 5) return true;
            else return false;
        }
    }
}
