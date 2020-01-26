// Author : Marcus B
namespace TranslatorNS
{
    public abstract partial class SuperTranslator
    {
        private static readonly string vowels = "AEIOUaeiou";
        private static readonly string[] punct = { ".", ",", "?", "!", ";", ":", "-", "\"", "..." };
        private static readonly string[] numbersAndSymbols = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "@", "#", "(", ")" };

        /// <summary>
        /// The parent method that calls all the other ones
        /// after checking bools
        /// </summary>
        /// <param name="raw">Is the "raw" input from the user</param>
        /// <param name="vowelEnding">Depending on what translator class calls this funcion
        /// pass in the appropriate ending for a vowel begining word</param>
        /// <param name="constEnding">Depending on what translator class calls this funcion
        /// pass in the appropriate ending for a consonant begining word</param>
        /// <returns></returns>

        public string TranslateRaw(string raw, string vowelEnding, string constEnding) // called by pig classes,
        {
            string formatedString = "";

            foreach (string word in ToArray(raw))   // Do checks and then run formatting methods
            {
                if (word == "")// handeling too much white space
                {
                    continue; // if split resulted in 0lenght words, skip
                }
                else if (BeginsWithQuotations(word))
                {
                    // Add the quotation back
                    formatedString += "\"" + TranslateRaw(RemoveBeginningQuotations(word), vowelEnding, constEnding);
                }
                else
                {
                    if (StartWithVowel(word) && !(ContainsPunctuation(word)) && !(ContainsSpecial(word))) /* index 0 is vowel, no punctuation,
                    no specia chars  , index 0 is vowel, no punctuation, no specia chars*/
                    {
                        if (IsAllCaps(word))
                        {
                            formatedString += AddV(word, vowelEnding.ToUpper()) + " ";
                        }
                        else formatedString += AddV(word, vowelEnding) + " ";
                    }
                    else if (StartWithVowel(word) && ContainsPunctuation(word)) // vowel with punct
                    {
                        if (IsAllCaps(word)) formatedString += ToPunctuation(AddV(word, vowelEnding.ToUpper())) + " ";
                        else formatedString += ToPunctuation(AddV(word, vowelEnding)) + " ";

                    }
                    else if (ContainsPunctuation(word)) // consonant with punct
                    {
                        if (!StartWithVowel(word))
                        {
                            if (!ContainsVowels(word))
                            {
                                formatedString += word + " ";
                            }
                            else
                            {
                                if (IsAllCaps(word)) formatedString += ToPunctuation(AddC(word, constEnding.ToUpper())) + " ";
                                else formatedString += ToPunctuation(AddC(word, constEnding)) + " ";
                            }
                        }
                    }
                    else if (ContainsSpecial(word)) // contains special chars
                    {
                        formatedString += word + " ";
                    }
                    else if (!StartWithVowel(word)) // consonant
                    {
                        if (!ContainsPunctuation(word))
                        {
                            if (!(ContainsSpecial(word)))
                            {
                                if (IsAllCaps(word)) formatedString += AddC(word, constEnding.ToUpper()) + " ";
                                else
                                {
                                    if (!ContainsVowels(word))
                                    {
                                        formatedString += word + " ";
                                    }
                                    else formatedString += AddC(word, constEnding) + " ";
                                }
                            }
                        }

                    }

                }

            }
            return formatedString;
        }
    }
}