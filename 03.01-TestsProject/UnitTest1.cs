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

        [Test]
        [TestCase(32, 8, ExpectedResult = 8)]
        [TestCase(8, 12, ExpectedResult = 4)]
        [TestCase(17, 13, ExpectedResult = 1)]
        [TestCase(14, 7, ExpectedResult = 7)]
        [TestCase(32, 16, ExpectedResult = 16)]
        [TestCase(17, 100, ExpectedResult = 1)]
        [TestCase(55, 20, ExpectedResult = 5)]
        [TestCase(55, 22, ExpectedResult = 11)]
        public static int gcd(int n1, int n2)
        {
            return Tasks.gcd(n1, n2);
        }

        [Test]
        [TestCase("4556364607935616", ExpectedResult = "############5616")]
        [TestCase("64607935616", ExpectedResult = "#######5616")]
        [TestCase("1", ExpectedResult = "1")]
        [TestCase("", ExpectedResult = "")]
        [TestCase("tBy>L/cMe+?<j:6n;C~H", ExpectedResult = "################;C~H")]
        [TestCase("12", ExpectedResult = "12")]
        [TestCase("8Ikhlf6yoxPOwi5cB014eWbRumj7vJ", ExpectedResult = "##########################j7vJ")]
        [TestCase("123", ExpectedResult = "123")]
        [TestCase(")E$aCU=e\"_", ExpectedResult = "######=e\"_")]
        [TestCase("2673951408", ExpectedResult = "######1408")]
        [TestCase("1234", ExpectedResult = "1234")]
        public static string MaskifyTests(string str)
        {
            return Tasks.Maskify(str);
        }
    }
}