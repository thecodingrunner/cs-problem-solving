using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Test
{  
    public class BiTest<TIn1, TIn2, TOut>
    {
        public TIn1 Input1 { get; set; }
        public TIn2 Input2 { get; set; }
        public TOut Output { get; set; }

        public Func<TIn1, TIn2, TOut> Function { get; set; }

        public BiTest(TIn1 input1, TIn2 input2, TOut output, Func<TIn1, TIn2, TOut> function)
        {
            this.Input1 = input1;
            this.Input2 = input2;
            this.Output = output;
            this.Function = function;
        }
    }
}
