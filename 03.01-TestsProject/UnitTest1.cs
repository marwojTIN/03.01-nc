using _03._01_Netcompany;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace _03._01_TestsProject
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase("1234", ExpectedResult = true)]
        [TestCase("12345", ExpectedResult = false)]
        [TestCase("a234", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("%234", ExpectedResult = false)]
        [TestCase("`234", ExpectedResult = false)]
        [TestCase("@234", ExpectedResult = false)]
        [TestCase("#234", ExpectedResult = false)]
        [TestCase("$234", ExpectedResult = false)]
        [TestCase("*234", ExpectedResult = false)]
        [TestCase("5678", ExpectedResult = true)]
        [TestCase("^234", ExpectedResult = false)]
        [TestCase("(234", ExpectedResult = false)]
        [TestCase(")234", ExpectedResult = false)]
        [TestCase("123456", ExpectedResult = true)]
        [TestCase("-234", ExpectedResult = false)]
        [TestCase("_234", ExpectedResult = false)]
        [TestCase("+234", ExpectedResult = false)]
        [TestCase("=234", ExpectedResult = false)]
        [TestCase("?234", ExpectedResult = false)]
        public static bool FixedTest(string pin)
        {
            return Tasks.ValidatePIN(pin);
        }

        [Test]
        [TestCase(838, ExpectedResult = true)]
        [TestCase(77, ExpectedResult = true)]
        [TestCase(95159, ExpectedResult = true)]
        [TestCase(839, ExpectedResult = false)]
        [TestCase(4234, ExpectedResult = false)]
        [TestCase(13, ExpectedResult = false)]
        public static bool PalindromeTests(int num)
        {
            return Tasks.IsNumberPalindrome(num);
        }

        [Test]
        public static void IsogramTests()
        {
            Console.WriteLine("Algorism");
            Assert.True(Tasks.IsWordIsogram("Algorism"));
            Console.WriteLine("PasSword");
            Assert.False(Tasks.IsWordIsogram("PasSword"));
            Console.WriteLine("Dermatoglyphics");
            Assert.True(Tasks.IsWordIsogram("Dermatoglyphics"));
            Console.WriteLine("Cat");
            Assert.True(Tasks.IsWordIsogram("Cat"));
            Console.WriteLine("Filmography");
            Assert.True(Tasks.IsWordIsogram("Filmography"));
            Console.WriteLine("Consecutive");
            Assert.False(Tasks.IsWordIsogram("Consecutive"));
            Console.WriteLine("Bankruptcies");
            Assert.True(Tasks.IsWordIsogram("Bankruptcies"));
            Console.WriteLine("Unforgivable");
            Assert.True(Tasks.IsWordIsogram("Unforgivable"));
            Console.WriteLine("Unpredictably");
            Assert.True(Tasks.IsWordIsogram("Unpredictably"));
            Console.WriteLine("Moose");
            Assert.False(Tasks.IsWordIsogram("Moose"));

        }

        [Test]
        [TestCase("Happy Birthday", ExpectedResult = "hAPPY bIRTHDAY")]
        [TestCase("MANY THANKS", ExpectedResult = "many thanks")]
        [TestCase("sPoNtAnEoUs", ExpectedResult = "SpOnTaNeOuS")]
        [TestCase("eXCELLENT, yOuR mAJESTY", ExpectedResult = "Excellent, YoUr Majesty")]
        public static string ReverseCase(string str)
        {
            return Tasks.ReverseCase(str);
        }
    }
}