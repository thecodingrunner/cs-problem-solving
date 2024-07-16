using cs_problem_solving.Sections.Extras;
using cs_problem_solving.Test;


namespace cs_problem_solving.Sections { 

public class SectionThree
{
    public static int CountValidTriangles(List<Triangle> triangles)
    {
        /* TODO:
        *   This function that takes an array of triangles.
            Each triangle is represented as an array 
            e.g. [10, 12, 22] 
            where the three numbers are the sides of the triangle.
            The function should return the count of triangles that are valid.
            To be a valid triangle, the sum of any two sides must be larger 
            than the remaining side
        */
        return -1;
    }

    public static List<string> CounterSpy(List<string> names)
    {
        /* TODO:
        *   This function takes an array of names.
            The function should return an array containing the names of the people who aren't spies.

            Recent intelligence has revealed that all spies codenames include the letters 's', 'p' or 'y'.
            You can't afford to take any chances, and all names that include those letters should be removed.

            IMPORTANT: 
            Also, our spy admin team have asked that the names come back in alphabetical order, 
            for spy filing purposes.
            So if you could do that you'd really be saving them a lot of work. Thanks.
        */
        return new List<string>();
    }

    public static string EncodeAlphabet(string input)
    {
        /* TODO:
        *   This function that accepts a string of any length, 
        *   and replaces each letter within each word with the corresponding index 
        *   that that letter has in the alphabet.
            You must have a space between each index number, and do NOT need to account 
            extra for spaces between words.
        */
        return "";
    }

    public static char? FindMissingLetter(List<char> input)
    {
        /* TODO:
        *   In this function, you need to find out which letter is missing 
        *   from a consecutive sequence of letters. 
        *   But you can't use a reference lookup table 
        *   (i.e. no array or object with the whole alphabet in it) 
        *   so you will have think outside the box!
        *
        *  This function needs to take a list and needs to return the letter it is missing.
        *  You will always get a sorted array of consecutive letters, 
        *  and it will always have exactly one letter missing. 
        *  The length of the array will always be at least 2. 
        *  The array will always contain letters in only one case.
        *
        *  If no character is missing, return null
        */
        return null;
    }

    public static string ConvertTimeString(string input)
    {
        /* TODO:
         *   This function should take a string representing a time with hours 
         *   and minutes separated by a colon e.g. "13:25"
             Some of the times are written in the 24-hour clock format
             This function should return the time written in the 12-hour clock format
         */
        return null;
    }

    public static int ComputePasswordScore(string input)
    {
        /* TODO:
            This function marks passwords out of 7 using the scores below.
            Invalid inputs should return 0.

            Score	Criteria	                                    Example
            1       Less than four characters	                    e.g. bob
            2	    Less than nine characters	                    e.g. bobbybob
            3	    More than eight characters and all letters	    e.g. bobbobbob
            4	    More than eight characters includes a number	e.g. bobbobbob1
            5	    More than eight characters includes a number and special character
                                                                    e.g. bobbob1#2$
            6	    More than twelve characters includes a number	e.g. bobbobbobbob123
            7	    More than twelve characters includes a number and special character
                                                                    e.g. bobbobbob1!2@3#

            Special characters: ! @ £ # $ % ^ & *
        */
        return -1;
    }

    public static List<int> GetUniqueAndOrdered(List<int> input)
    {
            /* TODO:
                Implement a function which takes as an argument a sequence 
                and returns a list of items without any elements with the same value 
                next to each other while preserving the original order of elements.

                In other words, the new list should contain items from the original sequence.
                If there are consecutive elements in the original sequence 
                that have the same value, only the first one should be included in the new list.
                The order of elements in the new list should be the same as in the original sequence.
            */
            return null;
    }

    public static List<int> FoldArray(List<int> input, int n)
    {
        /* TODO:  This function folds an array in the middle n number of times.

        If the list has a odd length, then fold on the middle index 
        (the middle number therefore won't change).
        Otherwise, fold across the 'gap' between the two middle integers 
        and so all integers are folded.

        To 'fold' the numbers add them together.

        For example:

        Fold 1-times:
        [1,2,3,4,5] -> [6,6,3]
        First, we add the 1st with the last. Then the second with the 4th.
        As the input array is odd in length, the middle index is not folded.

        */
        return null;
    }

    /************************* Do not modify below this line ******************************/
    public static void RunTests()
    {
        /* Do not modify this method */

        /* You may temporarily comment out some tests for convenience, but don't forget to enable them all again when you're finished! */

        RunTriangleTests();
        RunSpyTests();
        RunAlphabetTests();
        RunMissingLetterTests();
        RunConvertTimeTests();
        RunPasswordTests();
        RunUniqueAndOrderedTests();
        RunFoldTests();
    }

    static void RunUniqueAndOrderedTests()
    {
        /* Do not modify this method */
                
        List<Test<List<int>, List<int>>> one =
        [
            new Test<List<int>, List<int>>(new List<int>([1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 1, 1]), new List<int>([1, 2, 3, 1]), SectionThree.GetUniqueAndOrdered),
            new Test<List<int>, List<int>>(new List<int>([2, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 1, 1]), new List<int>([2, 1, 2, 3, 1]), SectionThree.GetUniqueAndOrdered),
            new Test<List<int>, List<int>>(new List<int>([4, 4, 5, 5, 6, 7, 8, 8]), new List<int>([4, 5, 6, 7, 8]), SectionThree.GetUniqueAndOrdered),
        ];

        TestApi.TryTests("GetUniqueAndOrdered() returns unique ordered numbers from an array", one);
    }

    static void RunFoldTests()
    {
        /* Do not modify this method */

        // even, 1
        List<BiTest<List<int>, int, List<int>>> evenOnce =
        [
            new BiTest<List<int>, int, List<int>>(new List<int>([1, 2]), 1, new List<int>([3]), SectionThree.FoldArray),
            new BiTest<List<int>, int, List<int>>(new List<int>([1, 2, 3, 10, 34, 100]), 1, new List<int>([101, 36, 13]), SectionThree.FoldArray),
        ];

        TestApi.TryBiTests("FoldArray() folds an even length array once", evenOnce);

        // odd, 1
        List<BiTest<List<int>, int, List<int>>> oddOnce =
        [
            new BiTest<List<int>, int, List<int>>(new List<int>([1, 2, 3]), 1, new List<int>([4, 2]), SectionThree.FoldArray),
        ];

        TestApi.TryBiTests("FoldArray() folds an odd length array once", oddOnce);

        // even, mult
        List<BiTest<List<int>, int, List<int>>> evenMultiple =
        [
            new BiTest<List<int>, int, List<int>>(new List<int>([1, 2, 3, 10, 34, 100]), 2, new List<int>([114, 36]), SectionThree.FoldArray),
        ];

        TestApi.TryBiTests("FoldArray() folds an even length array multiple times", evenMultiple);

        // toSingleValue
        List<BiTest<List<int>, int, List<int>>> toSingleValue =
        [
            new BiTest<List<int>, int, List<int>>(new List<int>([1, 2, 3, 10, 34, 100]), 3, new List<int>([150]), SectionThree.FoldArray),
        ];

        TestApi.TryBiTests("FoldArray() folds an array to a single value", toSingleValue);

            // repeatedFolds
            List<BiTest<List<int>, int, List<int>>> repeatedFolds =
            [
                new BiTest<List<int>, int, List<int>>(new List<int>([1, 2, 3, 10, 34, 100]), 4, new List<int>([150]), SectionThree.FoldArray),
            ];

        TestApi.TryBiTests("FoldArray() folds an array with repeated folds remaining the same", repeatedFolds);
    }


        static void RunPasswordTests()
        {
            /* Do not modify this method */

            // one
            List<Test<string, int>> one =
            [
                new Test<string, int>("bob", 1, SectionThree.ComputePasswordScore),
                new Test<string, int>("a", 1, SectionThree.ComputePasswordScore),
                new Test<string, int>("xyz", 1, SectionThree.ComputePasswordScore),
            ];

            TestApi.TryTests("passwordScore() scores 1 for less than four characters", one);


            // two
            List<Test<string, int>> two =
            [
                new Test<string, int>("bobbybob", 2, SectionThree.ComputePasswordScore),
                new Test<string, int>("aaaaa", 2, SectionThree.ComputePasswordScore),
                new Test<string, int>("xyzxyz", 2, SectionThree.ComputePasswordScore),
            ];

            TestApi.TryTests("passwordScore() scores 2 for less than nine characters", two);

            // three
            List<Test<string, int>> three =
            [
                new Test<string, int>("bobbobbob", 3, SectionThree.ComputePasswordScore),
                new Test<string, int>("aaaaaaaaa", 3, SectionThree.ComputePasswordScore),
                new Test<string, int>("xyzxyzxyz", 3, SectionThree.ComputePasswordScore),
            ];

            TestApi.TryTests("passwordScore() scores 3 for more than eight characters and all letters", three);

            // four
            List<Test<string, int>> four =
            [
                new Test<string, int>("bobbobbob1", 4, SectionThree.ComputePasswordScore),
                new Test<string, int>("aaaaaaaaa4", 4, SectionThree.ComputePasswordScore),
                new Test<string, int>("xyzxyzxyz6", 4, SectionThree.ComputePasswordScore),
            ];
            
            TestApi.TryTests("passwordScore() scores 4 for more than eight characters includes a number", four);

            // five
            List<Test<string, int>> five =
            [
                new Test<string, int>("bobbob1#2$", 5, SectionThree.ComputePasswordScore),
                new Test<string, int>("aaaaaaa!aa4", 5, SectionThree.ComputePasswordScore),
                new Test<string, int>("xyzxyzx*yz6", 5, SectionThree.ComputePasswordScore),
            ];

            TestApi.TryTests("passwordScore() scores 5 for more than eight characters includes a number and special character", five);

            // six
            List<Test<string, int>> six =
            [
                new Test<string, int>("bobbobbobbob123", 6, SectionThree.ComputePasswordScore),
                new Test<string, int>("boaaobbobbob128", 6, SectionThree.ComputePasswordScore),
                new Test<string, int>("bobbozzobbob723", 6, SectionThree.ComputePasswordScore),
            ];

            TestApi.TryTests("passwordScore() scores 6 for more than twelve characters includes a number", six);

            // seven
            List<Test<string, int>> seven =
            [
                new Test<string, int>("bobbobbob1!2@3#", 7, SectionThree.ComputePasswordScore),
                new Test<string, int>("boa!aobbobbob128", 7, SectionThree.ComputePasswordScore),
                new Test<string, int>("bobbo%zzobbob723", 7, SectionThree.ComputePasswordScore),
            ];

            TestApi.TryTests("passwordScore() scores 7 for more than twelve characters includes a number and special character", seven);


        }
        static void RunConvertTimeTests()
        {
            /* Do not modify this method */

            // unchangedTests
            List<Test<string, string>> unchangedTests = [new Test<string, string>("06:28", "06:28", SectionThree.ConvertTimeString)];

            TestApi.TryTests("convertTimeString() returns the string unchanged if already within the right format", unchangedTests);

            // afternoonTests
            List<Test<string, string>> afternoonTests = [new Test<string, string>("16:07", "04:07", SectionThree.ConvertTimeString)];

            TestApi.TryTests("convertTimeString() converts an afternoon time to the 12 hour format", afternoonTests);

            // midnightTests
            List<Test<string, string>> midnightTests =
            [
                new Test<string, string>("00:56", "12:56", SectionThree.ConvertTimeString),
                new Test<string, string>("00:00", "12:00", SectionThree.ConvertTimeString),
            ];

            TestApi.TryTests("convertTimeString() converts times in the hour after midnight to the 12 hour format", midnightTests);

        }

        static void RunMissingLetterTests()
        {
            /* Do not modify this method */

            // validInputTest
            List<Test<List<char>, char?>> validInputTest = new()
            {
                { new Test<List<char>, char?>(['A', 'B', 'C', 'D', 'E'], null, SectionThree.FindMissingLetter) }
            };
;
            TestApi.TryTests("FindMissingLetter() returns null if no letters are missing", validInputTest);

            // missingCapital
            List<Test<List<char>, char?>> missingCapital = new()
            {
                { new Test<List<char>, char?>(['A', 'B', 'C', 'E'], 'D', SectionThree.FindMissingLetter) }
            };
                        

            TestApi.TryTests("FindMissingLetter() returns a missing capital letter", missingCapital);

            // missingCapital
            List<Test<List<char>, char?>> missingLower = new()
            {
                { new Test<List<char>, char?>(['e', 'f', 'g', 'i'], 'h', SectionThree.FindMissingLetter) }
            };
                        

            TestApi.TryTests("FindMissingLetter() returns a missing lowercase letter", missingLower);
        }

        static void RunAlphabetTests()
        {
            /* Do not modify this method */

            // singleWordTests
            List<Test<string, string>> singleWordTests = [new Test<string, string>("code", "3 15 4 5", SectionThree.EncodeAlphabet)];

            TestApi.TryTests("EncodeAlphabet() replaces the letters in a single word with codes", singleWordTests);

            // caseInsensitiveTests
            List<Test<string, string>> caseInsensitiveTests =
            [
                new Test<string, string>("Northcoders", "14 15 18 20 8 3 15 4 5 18 19", SectionThree.EncodeAlphabet),
            ];

            TestApi.TryTests("EncodeAlphabet() is case-insensitive", caseInsensitiveTests);


            // spaceTests
            List<Test<string, string>> spaceTests =
            [
                new Test<string, string>("expert programming", "5 24 16 5 18 20 16 18 15 7 18 1 13 13 9 14 7", SectionThree.EncodeAlphabet),
            ];

            TestApi.TryTests("EncodeAlphabet() ignores spaces between words", spaceTests);
        }

        static void RunSpyTests()
        {
            /* Do not modify this method */

            // emptySpyTests
            List<Test<List<string>, List<string>>> emptySpyTests =
            [
                new Test<List<string>, List<string>>([], [], SectionThree.CounterSpy),
            ];

            TestApi.TryTests("CounterSpy() returns an empty array if no people are supplied", emptySpyTests);

            // oneSpyTests
            List<Test<List<string>, List<string>>> oneSpyTests =
            [
                new Test<List<string>, List<string>>(new (
                        ["Daryl"]
                ), [], SectionThree.CounterSpy),
            ];

            TestApi.TryTests("CounterSpy() returns an empty array if the only person is a spy", oneSpyTests);

            // spiesRemovedTests
            List<Test<List<string>, List<string>>> spiesRemovedTests =
            [
                new Test<List<string>, List<string>>(
                        ["Daryl", "Harriet", "James"],
                        ["Harriet"],
                        CounterSpy),
                new Test<List<string>, List<string>>(
                        ["Chris", "Daryl", "Harriet", "James", "Mauro", "Sam"], 
                        ["Harriet", "Mauro"], CounterSpy),
            ];

            TestApi.TryTests("CounterSpy() returns an array with all spies removed", spiesRemovedTests);


            // spiesRemovedTests
            List<Test<List<string>, List<string>>> alphabeticalTests = new()
            {
                {
                    new Test<List<string>, List<string>>(
                    ["Sam", "Harriet", "Adrian", "Mauro"],
                    ["Adrian", "Harriet", "Mauro"],
                    CounterSpy)
                }
            };
;

            TestApi.TryTests("CounterSpy() returns an array with names in alphabetical order", alphabeticalTests);
        }

        static void RunTriangleTests()
        {
            /* Do not modify this method */

            // emptyValidTriangleTests
            List<Test<List<Triangle>, int>> emptyValidTriangleTests = [new Test<List<Triangle>, int>([], 0, CountValidTriangles)];

            TestApi.TryTests("CountValidTriangles() returns 0 when passed no triangles []", emptyValidTriangleTests);

            // noValidTriangleTests
            List<Test<List<Triangle>, int>> noValidTriangleTests =
            [
                new Test<List<Triangle>, int>(
                        [new Triangle(5, 10, 25)]
                , 0, CountValidTriangles),
            ];

            TestApi.TryTests("CountValidTriangles() returns 0 when passed an array with no valid triangles", noValidTriangleTests);

            // singleValidTriangleTests
            List<Test<List<Triangle>, int>> singleValidTriangleTests =
            [
                new Test<List<Triangle>, int>(
                        [new Triangle(5, 4, 5)]
                , 1, CountValidTriangles),
            ];

            TestApi.TryTests("CountValidTriangles() returns 1 when passed an array with a single valid triangle", singleValidTriangleTests);


            // twoValidTriangleTests
            List<Test<List<Triangle>, int>> twoValidTriangleTests =                 
            [
                new Test<List<Triangle>, int>(
                        [new Triangle(5, 10, 25),
                            new Triangle(5, 4, 5),
                            new Triangle(542, 586, 419)]
                , 2, CountValidTriangles),
            ];

            TestApi.TryTests("validTriangles() returns 2 when passed an array with 2 valid and 1 invalid triangle", twoValidTriangleTests);
        }
    }
    

}