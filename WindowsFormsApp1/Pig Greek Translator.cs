namespace TranslatorNS
{
    public class Pig_Greek_Translator : SuperTranslator, ITranslator
    {
        private readonly string greekVowel = "oi";
        private readonly string greekConsonant = "omatos";

        /// <summary>
        /// Implemented from the ITranslate interface, Translate will take English text an pass it to the next translate-like method.
        /// </summary>
        /// <param name="raw">The raw string will get translated by this method.</param>
        /// <returns></returns>
        public string Translate(string raw)
        {
            return TranslateRaw(raw, this.greekVowel, this.greekConsonant);
        }
    }
}