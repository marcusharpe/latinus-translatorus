// Author : Marcus B
namespace TranslatorNS
{
    public abstract partial class SuperTranslator
    {
        /////////////////////////////////////////////////////////
        // // // // // // // // // Bools  // // // // // // // //
        /////////////////////////////////////////////////////////

        public bool StartWithVowel(string word)
        {
            bool bol = false;
            foreach (char vowel in vowels)
            {
                if (word.StartsWith(vowel.ToString()))
                {
                    bol = true;
                    break;
                }
            }
            return bol;

        }

        public bool BeginsWithQuotations(string word)
        {
            if (word.Substring(0, 1).Equals("\"")) return true;
            return false;
        }

        public bool ContainsSpecial(string word)
        {
            bool contains = false;
            for (int i = 0; i < numbersAndSymbols.Length; i++)
            {
                if (word.Contains(numbersAndSymbols[i]))
                {
                    contains = true;
                    break;
                }

            }
            return contains;
        }

        public bool ContainsPunctuation(string word)
        {
            bool contains = false;
            for (int i = 0; i < punct.Length; i++)
            {
                if (word.Contains(punct[i]))
                {
                    contains = true;
                    break;
                }

            }
            return contains;
        }

        public bool IsAllCaps(string word) // check for casing before translation
        {
            if (word.ToUpper().Equals(word)) return true;

            return false;
        }

        public bool ContainsVowels(string word)
        {
            bool contains = false;
            for (int v = 0; v < vowels.Length; v++)
            {
                if (word.Contains(vowels[v].ToString()))
                {
                    contains = true;
                    break;

                }
                else if (v != 0)
                {
                    if (word.Substring(1).Contains("y") || word.Substring(1).Contains("Y"))
                    {
                        contains = true;
                        break;
                    }
                }

            }
            return contains;
        }

        //public bool ContainsUpper(string word)
        //{
        //    bool bol = false;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (i == 0) continue;
        //        if (word[i].ToString() == word[i].ToString().ToUpper())
        //        {
        //            bol = true;
        //            break;
        //        }
        //    }
        //    return bol;
        //}
    }
}