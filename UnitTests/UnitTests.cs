using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorNS;

namespace UnitTests
{
    [TestClass]
    public class UnitTests

    {
        private Pig_Latin_Translator latinoPigu = new Pig_Latin_Translator();
        private Pig_Greek_Translator grekoPigu = new Pig_Greek_Translator();

        [TestMethod]
        public void Test_LongString()
        {
            Assert.IsTrue(latinoPigu.Translate("\"AWAY away\"     apple.    APPLE. test. TEST. television TELEVISION tv test @gmail.com")
                == "\"AWAYWAY awayway\" appleway. APPLEWAY. esttay. ESTTAY. elevisiontay ELEVISIONTAY tv esttay ailcom@gmay. ");

            Assert.IsTrue(grekoPigu.Translate("away") == "awayoi ");
            Assert.IsTrue(grekoPigu.Translate("tv.") == "tv. ");

        }

        [TestMethod]
        public void ToArray_Test()
        {
            string[] oneWord = latinoPigu.ToArray("away");
            Assert.IsTrue(oneWord.Length == 1);
            string[] oneWordWithSpace = latinoPigu.ToArray("away ");
            Assert.IsTrue(oneWordWithSpace[0] == "away");
            string[] twoWordsWithSpaceEnd = { "one", "two" };
            Assert.IsTrue(latinoPigu.ToArray("one two ")[0] == twoWordsWithSpaceEnd[0]
                && latinoPigu.ToArray("one two ")[1] == twoWordsWithSpaceEnd[1]);
        }

        [TestMethod]
        public void ContainsVowelsY()
        {
            Assert.IsTrue(latinoPigu.ContainsVowels("why"));
        }

        [TestMethod]
        public void ContainsSpeciaTest()
        {
            Assert.IsTrue(latinoPigu.ContainsSpecial("@"));
            Assert.IsTrue(grekoPigu.Translate("@") == "@ ");
        }

        [TestMethod]
        public void AddCTest()
        {
            Assert.IsTrue(latinoPigu.AddC("why", "ay", 1) == "ywhay");
            Assert.IsTrue(latinoPigu.AddC("whY", "ay", 1) == "Ywhay");
            Assert.IsTrue(latinoPigu.AddC("whY", "ay", 2) == null);

        }

    }
}