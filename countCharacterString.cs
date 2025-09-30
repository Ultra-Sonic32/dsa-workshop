using System;

namespace DSAWorkshop
{
    public static class countCharacterString
    {
        public static Dictionary<char, int> countAlphanumericCharacters(string input)
        {
            //2. Parse the string to lowercase as we dont want uppercase
            //1. Check if string is not emepty
            //4. Hashmap key value parses new Dictionary<string, int> Characters
            //3. Remove all spaces as we dont want them also
            //5. Dont count ., ? ! enc
            //6.. Return a object like a: 5, p: 10, 1: 7,


            if (string.IsNullOrEmpty(input)) return new Dictionary<char, int>();

            string parsedInput = string.Concat(input.ToLower().Where(c => !char.IsWhiteSpace(c)));

            Dictionary<char, int> charactersCount = new Dictionary<char, int>();

            foreach (var c in parsedInput)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    if (charactersCount.ContainsKey(c))

                    {
                        charactersCount[c]++;
                    }
                    else
                    {
                        charactersCount[c] = 1;
                    }
                }
               
            }

            return charactersCount;

        }

    }
}