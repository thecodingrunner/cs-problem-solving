using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Sections.Extras
{
    public class Triangle
    {
        public List<int> sides;

        public Triangle(int a, int b, int c) => sides = [a, b, c];

        public override string ToString()
        {
            return String.Join(',', sides);
        }
    }
}
