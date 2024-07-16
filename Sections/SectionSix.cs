using cs_problem_solving.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Sections
{
    public class SectionSix
    {
        public static bool CalculateJump(string[] locations, int jumpLength)
        {
            /* TODO:
            *   You will be given an array containing string representations of the locations 
            *   of a cat and a mouse.
                You will also be given a positive integer which represents how far the cat 
                can jump.

                Your task is to calculate if the cat can jump far enough to catch the mouse.
                Each space "x" in the array expends 1 from the cat's movement.
                It does not matter if the cat is before or after the mouse in the array.*/
            return false;
        }

        public static bool CalculateJumpWithWalls(string[] locations, int jumpLength)
        {
            /* TODO:
            *   You will be given an array containing string representations of the 
            *   locations of a cat and a mouse. 
            *   The array may also contains walls represented by "W".
                You will also be given a positive integer which represents 
                how far the cat can jump.

            Your task is to calculate if the cat can jump far enough to catch the mouse.

            Each space "x" expends 1 of the cat's movement, and each wall "W" expends 2.
            It does not matter if the cat is before or after the mouse in the array.
            * */
            return false;
        }

        public static int CalculateCatchManyMice(string[] locations, int jumpLength)
        {
            /* TODO:
            *   You will be given an array containing string representations of the 
            *   locations of a cat and multiple mice.

            * You will also be given a positive integer which represents how far the cat can jump.

              Your task is to calculate how many, if any, mice can the cat catch in one jump.

                Each space "x" expends 1 of the cat's movement.
                The cat will always go for the highest number of mice it can catch 
                if there are mice before and after it in the array.
            * */
            return -1;
        }

        public static bool CalculateMouseEscape(string[] locations, int jumpLength)
        {
            /* TODO:
            *   You will be given an array containing string representations 
            *   of the locations of a cat and multiple mice. 
            *   Hiding holes for mice are represented by "O".
                You will also be given a positive integer which represents 
            how far the cat can jump. Use this same number for the mouse movement as well.

                Your task is to determine if the cat can catch the mouse before it hides.

                Each space "x" expends 1 of the cat's and mouse's movement.
                The cat and mouse move at the same time, so the cat has to 
                catch the mouse before the mouse would go over to a hole "O".
            * */
            return false;
        }

        /************************* Do not modify below this line ******************************/
        public static void RunTests()
        {
            /* Do not modify this method */

            /* You may temporarily comment out some tests for convenience, but don't forget to enable them all again when you're finished! */
            RunJumpTests();
            RunWallTests();
            RunManyMiceTests();
            RunEscapeTests();
        }

        static void RunEscapeTests()
        {
            var catchesMouse = new List<BiTest<string[], int, bool>>
            {
                new(["cat", "mouse", "x", "O"], 5, true, CalculateMouseEscape),
                new(["cat", "x", "x", "mouse", "x", "x", "x", "O"], 3, true, CalculateMouseEscape),
                new(["O", "x", "x", "mouse", "x", "cat"], 3, true, CalculateMouseEscape)
            };

            TestApi.TryBiTests("CalculateMouseEscape() cat catches the mouse when it's closer to it than the mouse to the escape", catchesMouse);

            var mouseEscapes = new List<BiTest<string[], int, bool>>
            {
                new(["x", "cat", "x", "mouse", "O"], 2, false, CalculateMouseEscape),
                new(["cat", "x", "x", "O", "x", "x", "mouse"], 3, false, CalculateMouseEscape)
            };

            TestApi.TryBiTests("CalculateMouseEscape() cat fails to catch the mouse when the mouse is closer, or same distance to escape", mouseEscapes);
        }

        static void RunManyMiceTests()
        {
            var closeJump = new List<BiTest<string[], int, int>>
            {
                new(["cat", "x", "mouse"], 5, 1, CalculateCatchManyMice),
                new(["cat", "mouse", "x", "mouse"], 3, 2, CalculateCatchManyMice),
                new(["cat", "mouse", "x", "mouse", "x", "x", "x", "mouse"], 3, 2, CalculateCatchManyMice),
                new(["mouse", "mouse", "mouse", "x", "cat"], 3, 2, CalculateCatchManyMice)
            };

            TestApi.TryBiTests("CalculateCatchManyMice() cat catches mice when they are in one direction in the array", closeJump);

            var mostMice = new List<BiTest<string[], int, int>>
            {
                new(["mouse", "cat", "mouse", "mouse"], 2, 2, CalculateCatchManyMice),
                new(["mouse", "x", "mouse", "cat", "x", "x", "mouse"], 3, 2, CalculateCatchManyMice)
            };

            TestApi.TryBiTests("CalculateCatchManyMice() cat goes for the most mice it can catch", mostMice);
        }

        static void RunWallTests()
        {
            var closeJump = new List<BiTest<string[], int, bool>>
            {
                new(["cat", "W", "mouse"], 5, true, CalculateJumpWithWalls),
                new(["cat", "x", "x", "mouse"], 3, true, CalculateJumpWithWalls),
                new(["x", "mouse", "W", "x", "cat"], 4, true, CalculateJumpWithWalls)
            };

            TestApi.TryBiTests("CalculateJumpWithWalls() cat catches the mouse when it's closer than the jump length", closeJump);

            var failJump = new List<BiTest<string[], int, bool>>
            {
                new(["cat", "W", "mouse"], 2, false, CalculateJumpWithWalls),
                new(["x", "cat", "x", "x", "mouse"], 2, false, CalculateJumpWithWalls),
                new(["mouse", "x", "W", "x", "W", "cat"], 5, false, CalculateJumpWithWalls)
            };

            TestApi.TryBiTests("CalculateJumpWithWalls() cat fails to catch the mouse when jump length is smaller than distance", failJump);
        }

        static void RunJumpTests()
        {
            var closeJump = new List<BiTest<string[], int, bool>>
            {
                new(["cat", "mouse"], 5, true, CalculateJump),
                new(["cat", "x", "x", "mouse"], 3, true, CalculateJump),
                new(["x", "mouse", "x", "x", "cat"], 4, true, CalculateJump)
            };

            TestApi.TryBiTests("CalculateJump() cat catches the mouse when it's closer than the jump length", closeJump);

            var smallJump = new List<BiTest<string[], int, bool>>
            {
                new(["cat", "x", "mouse"], 1, false, CalculateJump),
                new(["x", "cat", "x", "x", "mouse"], 2, false, CalculateJump),
                new(["mouse", "x", "x", "x", "x", "cat"], 3, false, CalculateJump)
            };

            TestApi.TryBiTests("CalculateJump() cat fails to catch the mouse when jump length is smaller than distance", smallJump);
        }
    }

}
