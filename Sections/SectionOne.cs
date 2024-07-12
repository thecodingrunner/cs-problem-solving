using cs_problem_solving.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Sections
{
    internal class SectionOne
    {
        public static string ConnectStrings(List<string> input)
        {
            /* TODO: This function should take 2 strings and join them together with a space in between
                     and return the newly created string */
            return "";
        }

        public static bool CheckWordEndsWithIng(string input)
        {
            /* TODO: take a string as an argument and return a boolean based on whether the word given ends with 'ing' */
            return false;
        }

        public static string AddMissingPunctuation(string input)
        {
            /* TODO: take a string as an argument
                     each string may end with a full-stop, exclamation mark, or question mark
                     if the string doesn't end with punctuation, return the string with a full-stop added at the end.
                     Otherwise, return the string unchanged
     */
            return "";
        }

        public static int GetRemainder(int a, int b)
        {
            /* TODO: This function should take two arguments a and b, and return the remainder of the division of a / b
             */
            return -1;
        }

        public static List<string> MakeAllWordsBold(List<string> input)
        {
            /* TODO: In markdown files (e.g. 'README.md') we can denote words as bold by putting two asterisks on either side of them, such as: **hello**
                This function should take an array of strings as an argument and return an array consisting of the same strings but in bold - ie with two asterisks either side of them
             */
            return [];
        }

        public static List<int> GetPositiveNumbers(List<int> input)
        {
            /* TODO: This function should take an array of numbers as an argument and return an array containing all positive numbers from the input (retaining the order)
             */
            return [];
        }








        /************************* Do not modify below this line ******************************/
        public static void RunTests()
        {
            /* Do not modify this method */
            testConnectStrings();

            testCheckWordEndsIng();

            testAddMissingPunctuation();

            testGetRemainder();

            testMakeAllWordsBold();

            testGetPositiveNumbers();
        }

        private static void testConnectStrings()
        {
            List<Test<List<string>, string>> connectStringTests =
            [
                new Test<List<string>, string>(["hello", "world"], "hello world", SectionOne.ConnectStrings),
                new Test<List<string>, string>(["paul", "rogerson"], "paul rogerson", SectionOne.ConnectStrings),
                new Test<List<string>, string>(["blue", "sky"], "blue sky", SectionOne.ConnectStrings),
            ];

            TestApi.TryTests("connectstrings() can join 2 strings together", connectStringTests);
        }

        private static void testCheckWordEndsIng()
        {
            List<Test<string, bool>> checkWordEndsIngTests =
            [
                    new Test<string, bool>("doing", true, SectionOne.CheckWordEndsWithIng),
                    new Test<string, bool>("eating", true, SectionOne.CheckWordEndsWithIng),
                    new Test<string, bool>("bang", false, SectionOne.CheckWordEndsWithIng),
                    new Test<string, bool>("singer", false, SectionOne.CheckWordEndsWithIng)
            ];

            TestApi.TryTests("checkWordEndsWithIng() can return true/false for a single word", checkWordEndsIngTests);
        }

        private static void testAddMissingPunctuation()
        {
            List<Test<string, string>> addMissingPunctuationTests =
            [
                new Test<string, string>("Hello there!", "Hello there!", SectionOne.AddMissingPunctuation),
                new Test<string, string>("How's it going?", "How's it going?", SectionOne.AddMissingPunctuation),
                new Test<string, string>("Yeah I'm good", "Yeah I'm good.", SectionOne.AddMissingPunctuation),
                new Test<string, string>("Nice.", "Nice.", SectionOne.AddMissingPunctuation)
            ];

            TestApi.TryTests("addMissingPunctuation() returns the string with accurate punctuation", addMissingPunctuationTests);
        }

        private static void testGetRemainder()
        {
            List<BiTest<int, int, int>> getRemainderTests =
            [
                new BiTest<int, int, int>(10, 2, 0, SectionOne.GetRemainder),
                new BiTest<int, int, int>(119, 10, 9, SectionOne.GetRemainder),
                new BiTest<int, int, int>(50, 6, 2, SectionOne.GetRemainder)
            ];

            TestApi.TryBiTests("getRemainder() returns the correct remainder", getRemainderTests);
        }

        private static void testMakeAllWordsBold()
        {
            List<Test<List<string>, List<string>>> makeAllWordsBoldTests =
            [
                new Test<List<string>, List<string>>(["hello", "there", "world"], ["**hello**", "**there**", "**world**"], SectionOne.MakeAllWordsBold),
                new Test<List<string>, List<string>>(["I", "love", "coding"], ["**I**", "**love**", "**coding**"], SectionOne.MakeAllWordsBold)
            ];

            TestApi.TryTests("makeAllWordsBold() can convert all strings to be surrounded by double asterisks", makeAllWordsBoldTests);
        }

        private static void testGetPositiveNumbers()
        {
            List<Test<List<int>, List<int>>> getPositiveNumbersTests =
            [
                new Test<List<int>, List<int>>([1, -1, 2, -2, 3, -3], [1, 2, 3], SectionOne.GetPositiveNumbers),
                new Test<List<int>, List<int>>([-80, 9, 100, 13, 20, -7], [9, 100, 13, 20], SectionOne.GetPositiveNumbers),
                new Test<List<int>, List<int>>([-1, -50, -999], [], SectionOne.GetPositiveNumbers)
            ];

            TestApi.TryTests("getPositiveNumbers() can get all the positive numbers from an array of numbers", getPositiveNumbersTests);
        }
    }
}
