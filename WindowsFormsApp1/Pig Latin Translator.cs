// Author : Marcus B
namespace TranslatorNS
{
    public class Pig_Latin_Translator : SuperTranslator, ITranslator
    {
        private readonly string latinVowel = "way";
        private readonly string latinConsonant = "ay";

        /// <summary>
        /// Implemented from the ITranslate interface, Translate will take English text an pass it to the next translate-like method.
        /// </summary>
        /// <param name="raw">The raw string will get translated by this method.</param>
        /// <returns></returns>
        public string Translate(string raw)
        {
            return TranslateRaw(raw, this.latinVowel, this.latinConsonant);
        }

    }
}