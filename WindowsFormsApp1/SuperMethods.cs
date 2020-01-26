namespace TranslatorNS
{
    public abstract partial class SuperTranslator
    {
        /////////////////////////////////////////////////////////
        // // // // // // // // //Methods // // // // // // // //
        /////////////////////////////////////////////////////////
        public string[] ToArray(string raw) // split into array, if raw has " " at the end, remove it
        {
            if (raw.Contains(" "))
            {// if last char is not " "
                if (!raw.Substring(raw.Length - 1).Equals(" "))
                {
                    return raw.Split(' ');
                }
                else
                {// if last char is " " remove it and then send to array
                    raw = raw.Substring(0, raw.LastIndexOf(" "));
                    if (raw.Contains(" "))
                    {
                        return raw.Split(' ');
                    }
                    else
                    {
                        string[] oneWord = { raw };
                        return oneWord;
                    }
                }
            }
            else
            {
                string[] oneWord = { raw };
                return oneWord;
            }
        }

        public string RemoveBeginningQuotations(string word)
        {
            return word.Substring(1);
        }

        public string AddV(string word, string ending) // adds the speified ending to vowel starting words
        {
            return word + ending;
        }

        public string AddC(string word, string ending, int x = 1) // adds the speified ending to consonant starting words
        {
            if (x == 1)
            {
                string consonants = "";
                for (int i = 0; i < word.Length; i++)
                {
                    for (int v = 0; v < vowels.Length; v++)
                    {
                        if (vowels[v] == word[i])
                        {
                            consonants += word.Substring(i);
                            consonants += word.Substring(0, i);
                            consonants += ending;
                            return consonants;
                        }
                        else if (vowels[v] != word[i]) // index[i] is a consonant
                        {
                            if (i != 0) // skip first iteration of for/ skip the first character
                            {// check for "y" inside the word
                                if (word[i].Equals('Y'))
                                {
                                    consonants += word.Substring(i);
                                    consonants += word.Substring(0, i);
                                    consonants += ending;
                                    return consonants;
                                }
                                else if (word[i].Equals('y'))
                                {
                                    consonants += word.Substring(i);
                                    consonants += word.Substring(0, i);
                                    consonants += ending;
                                    return consonants;
                                }
                            }
                        }
                    }

                }
            }
            return null;

        }

        public string ToPunctuation(string word) // Keep all punctuation at the end of the translated word.
        {// change to move all consonants before first vowel
            string x = "null";
            int i = 0;
            while (i < punct.Length)
            {
                if (word.Contains(punct[i]))
                {
                    x = word.Substring(0, word.IndexOf(punct[i]));  // get chars untill the punct

                    x += word.Substring(word.IndexOf(punct[i]) + 1);// get chars untill the punct, excluding th epunct
                    x += word.Substring(word.IndexOf(punct[i]), 1); // add the punct at the end
                    break;
                }
                else x = word.Substring(1) + word.Substring(0, 1);
                i++;
            }

            return x;
        }

        //public string ToPunctuationV(string word, string ending)
        //{
        //    string x = "null";
        //    int i = 0;
        //    while (i < punct.Length)
        //    {
        //        if (word.Contains(punct[i]))
        //        {
        //            x = word.Substring(0, word.Length - 1); // remove punctuation
        //            x += ending;
        //            x += word.Substring(word.Length - 1);
        //            //x = word.Substring(1, word.Length - 1) + word.Substring(0, 1) + ending + word.Substring(word.Length - 1, 1);
        //            //x = x.Substring(0, x.IndexOf(this.Punct[i])) + x.Substring(x.IndexOf(this.Punct[i]) + 1);
        //            break;
        //        }
        //        else x = word.Substring(1) + word.Substring(0, 1) + ending;
        //        i++;
        //    }
        //    return x;
        //}// If a word starts with a consonant,

        // move the consonants before the first vowel to the end of the word and add ending
    }
}