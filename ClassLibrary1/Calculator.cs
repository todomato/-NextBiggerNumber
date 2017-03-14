using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Calculator
    {
        public object number(int num)
        {
            var intAry = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            //for loop 消除 magic number
            for (int index = intAry.Count - 1; index > 0; index--)
            {
                if (intAry[index] > intAry[index-1])
                {
                    var temp = intAry[index - 1];
                    intAry[index - 1] = intAry[index];
                    intAry[index] = temp;

                    return GetNewNumber(intAry);
                }
            }
            
            return  -1;
        }

        private int GetNewNumber(List<int> intAry)
        {
            var count = intAry.Count;

            var result = intAry.Select((x, index) => x * (Math.Pow(10, count - index - 1))).Sum();

            return Convert.ToInt32(result);
        }
    }
}