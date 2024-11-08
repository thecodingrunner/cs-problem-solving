using cs_problem_solving.Test;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace cs_problem_solving.Sections
{

    public class SectionFour
    {
        public static string CollectLikeTerms(string expression)
        {
            /* TODO:
            *    Implement a function collectLikeTerms which takes an expression in a string 
            *    like 'a + a + a' and then returns a string with a simplified algebraic expression,
            *    which in the previous case would be 3a.
                    
                 The characters should be in alphabetical order by default.
                 You can assume that the only operation connecting the terms is addition.   * */


            /* Split the string into an array of individual components
             * For each component, add to a dictionary
             * If a component contains a number, multiply the number by the remainder of the statement
             * Otherwise just add one 
             */

            expression = expression.ToLower();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int multiplier = 1;

            string[] array = expression.Split(' ');
            array = array.Where(val => val != "+").ToArray();
            Console.WriteLine(array);
            foreach (string s in array)
            {
                if (Regex.IsMatch(s, @"^[a-zA-Z]+$"))
                {
                    multiplier = 1;
                } else
                {
                    multiplier = Int32.Parse(Regex.Match(s, @"\d+").Value);
                }
                Console.WriteLine(multiplier);

                if (!dict.ContainsKey(s))
                {
                    dict.Add(s, multiplier);
                }
                else
                {
                    dict[s] += multiplier;
                }
            }

            string finalExpression = "";
            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (pair.Value == 1)
                {
                    finalExpression += $"{pair.Key} + ";
                } else
                {
                    finalExpression += $"{pair.Value}{pair.Key} + ";
                }
            }
            return finalExpression.Remove(finalExpression.Length - 3, 3);
        }

        public static string ConvertToBinary(int number)
        {
            /* TODO:
            *   Implement a function which takes any decimal number and converts it into binary 
            *   format.
                
                The return value of the function should always be a string of "O"s and "1"s 
                representing the binary number

                Do not use a built-in C# string format for this problem! This is the functionality you're aiming to replicate :) */
            return null;
        }

        public static string EncodeTimes(int[] number)
        {
            /* TODO: The statements below list the times someone spent awake / asleep 
             * over the course of a 60 minute period:

                At minute 0, someone wakes up
                At minute 5, someone falls asleep
                At minute 25, someone wakes up
                At minute 30, someone falls asleep
                At minute 55, someone wakes up

                These times can be represented by the following array:
                [0, 5, 25, 30, 55]

                And now we can use a . character to represent a minute spent awake
                And now we can use a # character to represent a minute spent asleep

                So we could represent the data above by a string in the following way:
                ".....####################.....#########################....."

                Implement a function that will take an array of time intervals 
                for being awake/asleep over 60 mins and will generate a string encoding 
                this information with a series of . and #

             */
            return null;
        }

        public static string[][] CreatePowerSet(string[] input)
        {
            /* TODO:
            *   You will need to implement a function createPowerSet

                It will need to return an array of all possible sub-arrays 
                given some starting array

                For example,
                createPowerSet(['a', 'b', 'c']) should return

                [[], ['a'], ['b'], ['c'], ['a', 'b'], ['b', 'c'] ,['a', 'c'], ['a', 'b', 'c'] ]

                All the possible sub-arrays that can be constructed from 3 distinct elements
                There should be 2**3 = 8 different subsets in total
                (2**3 is "2 to the power of 3")

                CHALLENGE:
                * You will need to write your own test for this task to prove your function is working correctly.
                * Implement `runPowerSetTests()` below to provide your tests.
                * The example from above has been implemented for you
                * HINT: don't make your input arrays big or you'll have to write a LOT of outputs..!

    */
            return null;
        }

        static void RunCreatePowerSetTests()
        {
            /* TODO: implement tests using the example below */

            List<Test<string[], string[][]>> tests =
            [                
                // EXAMPLE TEST - the example input given above
                new Test<string[], string[][]>(
                    // input
                    ["a", "b", "c"], 
                    // expected output, an array of arrays
                    [
                        [],
                        ["a"],
                        ["b"],
                        ["c"],
                        ["a", "b"],
                        ["b", "c"],
                        ["a", "c"],
                        ["a", "b", "c"]
                    ], CreatePowerSet),

                // INSERT ADDITIONAL TESTS BELOW FOLLOWING A SIMILAR FORMAT:                
                new Test<string[], string[][]>(
                    [/* TODO: ADD INPUT HERE */],
                    [/* TODO: ADD OUTPUT array-of-arrays HERE */],
                CreatePowerSet),
            ];

            TestApi.TryTests("CreatePowerSet() returns an array of all possible sub-arrays", tests);

            /***** DO NOT MODIFY */
            List<Test<string[], string[][]>> emptyTest =
            [
                new Test<string[], string[][]>([], [], CreatePowerSet),
            ];

            TestApi.TryTests("CreatePowerSet() returns an array including empty array when passed an empty array", emptyTest);
        }

        /************************* Do not modify below this line ******************************/
        public static void RunTests()
        {
            /* Do not modify this method */

            /* You may temporarily comment out some tests for convenience, but don't forget to enable them all again when you're finished! */

            RunLikeTermsTests();
            RunConvertToBinaryTests();
            RunEncodeTimesTests();
            RunCreatePowerSetTests();
        }

        static void RunEncodeTimesTests()
        {
            /* Do not modify this method */

            // times
            List<Test<int[], string>> times =
            [
                new Test<int[], string>([0, 5, 25, 30, 55 ], ".....####################.....#########################.....", EncodeTimes),
                new Test<int[], string>([0, 40, 50], "........................................##########..........", EncodeTimes),
                new Test<int[], string>([0, 24, 29 ], "........................#####...............................", EncodeTimes),
                new Test<int[], string>([0, 45, 55 ], ".............................................##########.....", EncodeTimes),
            ];

            TestApi.TryTests("EncodeTimes() can encode a series of times into a time string", times);
        }

        static void RunConvertToBinaryTests()
        {
            /* Do not modify this method */

            // singleDigit
            List<Test<int, string>> singleDigit =
            [
                new Test<int, string>(0, "0", ConvertToBinary),
                new Test<int, string>(1, "1", ConvertToBinary),
                new Test<int, string>(2, "10", ConvertToBinary),
                new Test<int, string>(3, "11", ConvertToBinary),
                new Test<int, string>(4, "100", ConvertToBinary),
                new Test<int, string>(5, "101", ConvertToBinary),
                new Test<int, string>(6, "110", ConvertToBinary),
                new Test<int, string>(7, "111", ConvertToBinary),
            ];

            TestApi.TryTests("convertToBinary() can convert a single digit decimal number to binary", singleDigit);

            List<Test<int, string>> multipleDigit =
            [
                new Test<int, string>(10, "1010", ConvertToBinary),
                new Test<int, string>(23, "10111", ConvertToBinary),
                new Test<int, string>(55, "110111", ConvertToBinary),
            ];

            TestApi.TryTests("ConvertToBinary() can convert a multiple digit decimal number to binary", singleDigit);
        }

        static void RunLikeTermsTests()
        {
            /* Do not modify this method */

            // singleLetter
            List<Test<string, string>> singleLetter =
            [
                new Test<string, string>("a", "a", CollectLikeTerms),
                new Test<string, string>("b", "b", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() returns a letter when passed an expression with a single letter", singleLetter);

            // alreadySimplified
            List<Test<string, string>> alreadySimplified =
            [
                new Test<string, string>("2a", "2a", CollectLikeTerms),
                new Test<string, string>("3b", "3b", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() returns the expression if it is already simplified (not starting with a 1)", alreadySimplified);

            // startsWithOne
            List<Test<string, string>> startsWithOne =
            [
                new Test<string, string>("1a", "a", CollectLikeTerms),
                new Test<string, string>("1b", "b", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() simplifies 1x to just x", startsWithOne);

            // two duplicated letters
            List<Test<string, string>> twoDuplicates =
            [
                new Test<string, string>("a + a", "2a", CollectLikeTerms),
                new Test<string, string>("c + c", "2c", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() can simplify two duplicated letters added together", twoDuplicates);

            // multipleDuplicates  letters
            List<Test<string, string>> multipleDuplicates =
            [
                new Test<string, string>("a + a + a", "3a", CollectLikeTerms),
                new Test<string, string>("c + c + c + c", "4c", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() can simplify multiple duplicated letters added together", multipleDuplicates);

            // two distinct
            List<Test<string, string>> twoDistinct =
            [
                new Test<string, string>("a + b", "a + b", CollectLikeTerms),
                new Test<string, string>("b + a", "a + b", CollectLikeTerms),
            ];

            TestApi.TryTests("collectLikeTerms() can simplify two distinct letters (in alphabetical order)", twoDistinct);

            // mult distinct duplicate
            List<Test<string, string>> multDistinctDuplicate =
            [
                new Test<string, string>("a + b + b", "a + 2b", CollectLikeTerms),
                new Test<string, string>("b + a + a + a", "3a + b", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() can simplify multiple distinct (with some duplicate) letters being added together", twoDistinct);

            // multTerms
            List<Test<string, string>> multTerms =
            [
                new Test<string, string>("ab + ab", "2ab", CollectLikeTerms),
                new Test<string, string>("ab + ab + ab", "3ab", CollectLikeTerms),
            ];

            TestApi.TryTests("CollectLikeTerms() can simplify multiple distinct terms, terms consist of multiple letters together", multTerms);
        }
    }
}



