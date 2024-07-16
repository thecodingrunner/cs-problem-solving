using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_problem_solving.Sections.Extras
{
    public class NestedArray<T>
    {
        private readonly object[] values;

        public NestedArray(object[] input)
        {
            this.values = input;
        }

        public object[] GetContent()
        {
            return values;
        }

        public override string ToString()
        {
            StringBuilder result = new("[");
            bool isFirstItem = true;

            foreach (object item in values)
            {
                if (item.GetType().IsArray)
                {
                    if (!isFirstItem)
                    {
                        result.Append(", ");
                    }
                    result.Append(ArrayToString((object[])item));
                }
                else
                {
                    if (!isFirstItem)
                    {
                        result.Append(", ");
                    }
                    result.Append(item.ToString());
                }
                isFirstItem = false;
            }

            result.Append(']');
            return result.ToString();
        }

        private string ArrayToString(object[] array)
        {
            StringBuilder result = new("[");
            bool isFirstItem = true;

            foreach (object item in array)
            {
                if (item is object[] v)
                {
                    if (!isFirstItem)
                    {
                        result.Append(", ");
                    }
                    result.Append(ArrayToString(v));
                }
                else
                {
                    if (!isFirstItem)
                    {
                        result.Append(", ");
                    }
                    result.Append(item.ToString());
                }
                isFirstItem = false;
            }

            result.Append(']');
            return result.ToString();
        }
    }

}
