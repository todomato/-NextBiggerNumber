using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Calculator
    {
        public object number(int num)
        {
            var intAry = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            if (intAry.Count == 1)
            {
                return -1;
            }

            if (intAry[1] > intAry[0])
            {
                var temp = intAry[0];
                intAry[0] = intAry[1];
                intAry[1] = temp;
            }
           

            int result = GetNewNumber(intAry);
            return result == num ? -1 : result;
        }

        private int GetNewNumber(List<int> intAry)
        {
            var count = intAry.Count;

            var result = intAry.Select((x, index) => x * (Math.Pow(10, count - index - 1))).Sum();

            return Convert.ToInt32(result);
        }
    }
}
