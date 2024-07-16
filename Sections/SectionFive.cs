using cs_problem_solving.Sections.Extras;
using cs_problem_solving.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Sections
{
    public class SectionFive
    {
        public static bool AreItemsConsecutive(int[] integers, Tuple<int, int> candidates)
        {
            /* TODO:
            *    You are given an array of unique integers, along with an object 
            *    which contains two integers a and b.
                
                Your task is to find out whether or not a and b appear consecutively in the array, 
                and return a boolean value (true if a and b are consecutive, false otherwise).

                 NOTE: It is guaranteed that a and b are both present in the array.  */
            return false;
        }

        public static int CountCarrotCrop(NestedArray<string> garden)
        {
            /* TODO:
            *     Spring came, the desire to have a veggie garden overwhelmed you 
            *     and so you planted some seeds. Now they are all grown, how many are carrots?

               You are given a garden patch represented by a nested array. 
                Count the total number of carrots found, and return it.

    *          NOTE: Each element in the NestedArray will either be a String or another NestedArray.
    *                For example:
    *                   [["carrot", "carrot"], "carrot", [["carrot", "carrot"], "carrot"]]
    *                In this array:
    *                   1. The first element is another NestedArray, which contains two strings.
    *                   2. The second element is just a string.
    *                   3. The third element is another NestedArray, which contains:
    *                       3a: A NestedArray, which contains two strings.
    *                       3b: A string
    *               It contains 6 "carrot", so the answer would be 6 for this array.
    *
    *               NOTE: Some gardens contain other plants than carrots!
    *
    *               HINT: The `is` operator can tell you if an object is a string or a nested array
                  */
            return -1;
        }

        /************************* Do not modify below this line ******************************/
        public static void RunTests()
        {
            /* Do not modify this method */

            /* You may temporarily comment out some tests for convenience, but don't forget to enable them all again when you're finished! */
            RunConsecutiveItemsTests();
            RunCarrotCropTests();
        }

        static void RunCarrotCropTests()
        {
            var onlyCarrots = new List<Test<NestedArray<string>, int>>
            {
                new(new NestedArray<string>(["carrot"]), 1, CountCarrotCrop),
                new(new NestedArray<string>(["carrot", "carrot"]), 2, CountCarrotCrop),
                new(new NestedArray<string>(
                [
                    "carrot",
                    new object[]{"carrot", "carrot"}
                    ]), 3, CountCarrotCrop),
                new(new NestedArray<string>(["carrot", "carrot", new object[] { "carrot", new object[] { "carrot", "carrot" } }]), 5, CountCarrotCrop),
                new(new NestedArray<string>(["carrot", "carrot", new object[] { "carrot", new object[] { "carrot", "carrot" } }, "carrot", "carrot"]), 7, CountCarrotCrop)
            };

            TestApi.TryTests("CountCarrotCrop() counts the carrots when there are only carrots present", onlyCarrots);

            var mixedVeg = new List<Test<NestedArray<string>, int>>
            {
                new(new NestedArray<string>(["carrot", "cabbage"]), 1, SectionFive.CountCarrotCrop),
                new(new NestedArray<string>(["carrot", "carrot", "radish", "beetroot"]), 2, CountCarrotCrop),
                new(new NestedArray<string>(
                [
                    "carrot", "broccoli",
                    new object[]{"carrot", "potato", "carrot"}
                    ]), 3, SectionFive.CountCarrotCrop),
                new(new NestedArray<string>(["beans", "carrot", "carrot", new object[] { "carrot", "artichoke", new object[] { "carrot", "beans", "carrot" } }]), 5, CountCarrotCrop),
                new(new NestedArray<string>(["radish", "carrot", "beans", "carrot", new object[] { "carrot", new object[] { "carrot", "radish", "radish", "carrot" } }, "radish", new object[] { "carrot", "potato" }, new object[] { "potato", new object[] { "carrot" } }, "potato"]), 7, CountCarrotCrop)
            };

            TestApi.TryTests("CountCarrotCrop() counts the carrots given a mixed veg patch", mixedVeg);
        }

        static void RunConsecutiveItemsTests()
        {
            /* Do not modify this method */

            // consecutive
            var consecutive = new List<BiTest<int[], Tuple<int, int>, bool>>
            {
                new([1, 2, 3, 4], new Tuple<int, int>(1, 2), true, AreItemsConsecutive),
                new([1, 2, 3, 4], new Tuple<int, int>(2, 3), true, AreItemsConsecutive),
                new([11, -12, 4, 11, -111, 58, -111, 3], new Tuple<int, int>(-111, 3), true, AreItemsConsecutive)
            };

            TestApi.TryBiTests("ConsecutiveItems() returns true when the given numbers are consecutive in the input array", consecutive);

            // not consecutive
            var notConsecutive = new List<BiTest<int[], Tuple<int, int>, bool>>
            {
                new BiTest<int[], Tuple<int, int>, bool>([1, 2, 3, 4], new Tuple<int, int>(1, 3), false, AreItemsConsecutive),
                new BiTest<int[], Tuple<int, int>, bool>([1, 16, -7, 90, -8], new Tuple<int, int>(16, -8), false, AreItemsConsecutive)
            };

            TestApi.TryBiTests("ConsecutiveItems() returns false when the given numbers are not consecutive in the input array", notConsecutive);
        }
    }

}
