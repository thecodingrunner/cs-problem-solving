using cs_problem_solving.Test;
using System.Linq.Expressions;

namespace cs_problem_solving.Sections
{
    public class SectionTwo
    {
        public static bool CheckSameFinalCharacter(string a, string b)
        {
            /* TODO: This function should take two strings as arguments and return true 
             * if their final character is the same or false if not */
            return a[a.Length - 1] == b[b.Length - 1];
        }

        public static bool IsAllUpperCase(string input)
        {
            /* TODO: This function should take a string as an argument and return true 
             * if every letter is upper case and false if at least one character is not */
            foreach (char c in input)
            {
                if (Char.IsLower(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static string CollectTheVowels(string input)
        {
            /* TODO: This function should take a string as its argument and return a string 
             * consisting of all vowels found in the input (retaining the order) */
            string vowels = "";
            foreach (char c in input)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    vowels += c;
                }
            }
            return vowels;
        }

        public static string AccessItem(List<string> input, int index)
        {
            /* TODO: This function should take two arguments, a list and an index, 
             * and return the element at that specified index. The index provided 
             * may be equal to or greater than the length of the given list. 
             * In this case, rather than counting past the end of the list where 
             * there are no values, the indexing should "loop back around" and 
             * continue from the start of the list.
            */
            return input[index%input.Count];
        }

        public static string FindDayOfTheWeek(int number)
        {
            /* TODO: This function should take a number from 1 to 7 inclusive, 
             * and return a string of the corresponding day of the week */
            switch (number)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Not a week day";
            }
        }

        public static string CreatePercentage(int a, int b)
        {
            /* TODO: This function should take two numbers, a and b, and return 
             * a string representing the value of a as a percentage of b in the form "--%"
                - you must round the percentages to the nearest whole number
                - single-digit percentages require the leading zero
             */
            float aFloat = (float)a;
            float bFloat = (float)b;
            double percentage = Math.Round((aFloat / bFloat) * 100);
            if (percentage < 10)
            {
                return "0" + percentage.ToString() + "%";
            }
            return percentage.ToString() + "%";
        }

        public static int ExtractNumber(string input)
        {
            /* TODO: This function should take a string containing a number 
             * wrapped in a pair of round brackets and return said number */
            string[] array = input.Split('(', ')');
            return Int32.Parse(array[1]);
        }




        /************************* Do not modify below this line ******************************/
        public static void RunTests()
        {
            /* Do not modify this method */


            testCheckSameFinalCharacter();

            testIsAllUpperCase();

            testCollectTheVowels();

            testAccessItem();

            testAccessItemLoop();

            testFindDayOfTheWeek();

            testCreatePercentage();

            testExtractNumber();
        }

        private static void testExtractNumber()
        {
            var extractNumberTests = new List<Test<string, int>>
            {
                new("lasjdasasj(123)asljdlajk", 123, ExtractNumber),
                new("qwasdaoyer(44687)iuwyeibasdahgsd", 44687, ExtractNumber),
                new("qwasdasdfsyer(19827)iusdfsdfsd", 19827, ExtractNumber),
                new("qwasdasdfsyer(5601)iusd5602sdfsd", 5601, ExtractNumber),
                new("qwasdas27dfs28yer(29)ius3dfsdf0sd", 29, ExtractNumber)
            };

            TestApi.TryTests("extractNumber() should return the number buried inside a string", extractNumberTests);
        }

        private static void testCreatePercentage()
        {
            var createPercentageTests = new List<BiTest<int, int, string>>
            {
                new(1, 2, "50%", CreatePercentage),
                new(50, 100, "50%", CreatePercentage),
                new(2, 3, "67%", CreatePercentage),
                new(3, 4, "75%", CreatePercentage),
                new(1, 7, "14%", CreatePercentage),
                new(3, 100, "03%", CreatePercentage)
            };

            TestApi.TryBiTests("createPercentage() creates a percentage string in the form \"--%\"", createPercentageTests);
        }

        private static void testFindDayOfTheWeek()
        {
            var findDayOfTheWeekTests = new List<Test<int, string>>
            {
                new(2, "Tuesday", FindDayOfTheWeek),
                new(3, "Wednesday", FindDayOfTheWeek),
                new(1, "Monday", FindDayOfTheWeek),
                new(6, "Saturday", FindDayOfTheWeek),
                new(7, "Sunday", FindDayOfTheWeek)
            };

            TestApi.TryTests("findDayOfTheWeek() returns the day of the week given a passed number", findDayOfTheWeekTests);
        }

        private static void testAccessItemLoop()
        {
            var accessItemLoopTests = new List<BiTest<List<string>, int, string>>
            {
                new(["a", "b", "c", "d"], 4, "a", AccessItem),
                new(["a", "b", "c", "d"], 6, "c", AccessItem),
                new(["a", "b", "c", "d"], 10, "c", AccessItem),
                new(["a", "b", "c", "d"], 11, "d", AccessItem)
            };

            TestApi.TryBiTests("accessItem() can access an item inside in a list with an index equal to or above the list length", accessItemLoopTests);
        }

        private static void testAccessItem()
        {
            var accessItemSimpleTests = new List<BiTest<List<string>, int, string>>
            {
                // simple
                new(["a", "b", "c", "d"], 2, "c", AccessItem),
                new(["a", "b", "c", "d"], 0, "a", AccessItem),
                new(["a", "b", "c", "d"], 3, "d", AccessItem)
            };

            TestApi.TryBiTests("accessItem() can access an item inside in a list with a given index below the list length", accessItemSimpleTests);
        }

        private static void testCollectTheVowels()
        {
            var collectTheVowelsTests = new List<Test<string, string>>
            {
                new("a", "a", CollectTheVowels),
                new("bcd", "", CollectTheVowels),
                new("bcdepiaouk", "eiaou", CollectTheVowels),
                new("hello world", "eoo", CollectTheVowels)
            };

            TestApi.TryTests("collectTheVowels() takes a string of many letters and returns a string containing those vowels in correct order", collectTheVowelsTests);
        }

        private static void testIsAllUpperCase()
        {
            var isAllUpperCaseTests = new List<Test<string, bool>>
            {
                new("hello", false, IsAllUpperCase),
                new("YEAH", true, IsAllUpperCase),
                new("Well HELLO!", false, IsAllUpperCase),
                new("GOOD MORNING", true, IsAllUpperCase)
            };

            TestApi.TryTests("isAllUpperCase() checks if every letter is upper case", isAllUpperCaseTests);
        }

        private static void testCheckSameFinalCharacter()
        {
            var checkSameFinalCharacterTests = new List<BiTest<string, string, bool>>
            {
                new("hello", "hello", true, CheckSameFinalCharacter),
                new("goodbye!", "goodbye?", false, CheckSameFinalCharacter),
                new("north", "coders", false, CheckSameFinalCharacter),
                new("what", "did you expect", true, CheckSameFinalCharacter)
            };

            TestApi.TryBiTests("checkSameFinalCharacter() checks if two strings end with the same character", checkSameFinalCharacterTests);
        }
    }
}
