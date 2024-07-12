
using System.Collections;


namespace cs_problem_solving.Test
{

    /* 
     
    This is a bit crude! But in the absence of using a "proper" testing framework like NUnit, 
    there's a *little* bit of sophistication here.

    Feel free to read/explore this code if you wish, but don't worry if you don't understand it yet.
     
     */

    public class TestApi
    {
        // colour codes, to make the terminal output a little prettier
        public const string ANSI_RESET = "\u001B[0m";
        public const string ANSI_BLACK = "\u001B[30m";
        public const string ANSI_RED = "\u001B[31m";
        public const string ANSI_GREEN = "\u001B[32m";
        public const string ANSI_YELLOW = "\u001B[33m";
        public const string ANSI_BLUE = "\u001B[34m";
        public const string ANSI_PURPLE = "\u001B[35m";
        public const string ANSI_CYAN = "\u001B[36m";
        public const string ANSI_WHITE = "\u001B[37m";

        public static void TryTests<TIn, TOut>(string testName, List<Test<TIn, TOut>> tests)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(ANSI_BLUE + " TEST: " + testName + ANSI_RESET);
            foreach (var test in tests)
            {
                tryInput(test.Input, test.Output, test.Function);
            }
        }

        public static void TryBiTests<TInOne, TInTwo, TOut>(string testName, List<BiTest<TInOne, TInTwo, TOut>> tests)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(ANSI_BLUE + " TEST: " + testName + ANSI_RESET);
            foreach (var test in tests)
            {
                tryBiInput(test);
            }
        }

        private static void tryInput<TIn, TOut>(TIn input, TOut expectedOutput, Func<TIn, TOut> function)
        {
            TOut result = function(input);
            if (Equals(result, expectedOutput))
            {
                Console.WriteLine(ANSI_GREEN + $"    ✅ SUCCESS for input: {ToSafeString(input)}" + ANSI_RESET);
            }
            else
            {
                Console.WriteLine(ANSI_RED + $"    ❌ FAILED for input: {ToSafeString(input)}" + ANSI_RESET);
                Console.WriteLine(ANSI_RED + $"             expected: {ToSafeString(expectedOutput)}" + ANSI_RESET);
                Console.WriteLine(ANSI_RED + $"                  got: {ToSafeString(result)}" + ANSI_RESET);
            }
        }

        private static void tryBiInput<TInOne, TInTwo, TOut>(BiTest<TInOne, TInTwo, TOut> test)
        {
            TOut result = test.Function(test.Input1, test.Input2);
            if (Equals(result, test.Output))
            {
                Console.WriteLine(ANSI_GREEN + $"   ✅ SUCCESS for inputs: {ToSafeString(test.Input1)}, {ToSafeString(test.Input2)}" + ANSI_RESET);
            }
            else
            {
                Console.WriteLine(ANSI_RED + $"    ❌ FAILED for inputs: {ToSafeString(test.Input1)}, {ToSafeString(test.Input2)}" + ANSI_RESET);
                Console.WriteLine(ANSI_RED + $"              expected: {ToSafeString(test.Output)}" + ANSI_RESET);
                Console.WriteLine(ANSI_RED + $"                   got: {ToSafeString(result)}" + ANSI_RESET);
            }
        }

        public static string ToSafeString<T>(T obj)
        {
            if (obj == null) return "(null)";

            if (obj is Array array)
            {
                return array switch
                {
                    object[] objectArray => string.Join(", ", objectArray.Select(ToSafeString)),
                    int[] intArray => string.Join(", ", intArray),
                    byte[] byteArray => string.Join(", ", byteArray),
                    _ => "☹️ Can't display this array type... Northcoders have made a mistake!"
                };
            }

            if (obj is IList list)
            {
                var items = list.Cast<object>().Select(ToSafeString);
                return "[" + string.Join(", ", items) + "]";
            }

            return obj.ToString() ?? "(null)";
        }
    }

}
