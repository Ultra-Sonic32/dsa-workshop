using System;

namespace DSAWorkshop {

    public static class ReverseString
    {
        //Method 1: Using built in Array Reverse
        public static string RerverseWithArray(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


