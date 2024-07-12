using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Test
{  
    public class Test<TIn, TOut>
    {
        public TIn Input { get; set; }        
        public TOut Output { get; set; }

        public Func<TIn, TOut> Function { get; set; }               
                       
        public Test(TIn input, TOut output, Func<TIn, TOut> function)
        {
            this.Input = input;            
            this.Output = output;
            this.Function = function;
        }
    }
}
