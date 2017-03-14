using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Calculator
    {
        public object Next(int num)
        {
            var intAry = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            //for loop 消除 magic number
            for (int index = intAry.Count - 1; index > 0; index--)
            {
                if (intAry[index] > intAry[index - 1])
                {
                    var r = intAry.GetRange(index, intAry.Count - index);  //.Skip(index).Take(intAry.Count - index).ToList();
                    var l = intAry.GetRange(0, index); //.Take(index).ToList(); //包含t

                    Swap(intAry, index, r, l);

                    l.AddRange(r.OrderBy(x => x));
                    return GetNewNumber(l);
                }
            }
            
            return  -1;
        }

        private static void Swap(List<int> intAry, int index, List<int> r, List<int> l)
        {
            for (int i = r.Count - 1; i >= 0; i--)
            {
                if (r[i] > intAry[index - 1])
                {
                    l[index - 1] = r[i];
                    r[i] = intAry[index - 1];
                    break;  //找到第一個swap的, 就是比t大的最小值
                }
            }
        }

        private int GetNewNumber(List<int> intAry)
        {
            var count = intAry.Count;

            var result = intAry.Select((x, index) => x * (Math.Pow(10, count - index - 1))).Sum();

            return Convert.ToInt32(result);
        }
    }
}