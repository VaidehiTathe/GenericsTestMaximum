using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Generics
{
    public class TestMaximumUtility
    {
        public int findMaximum(int firstNumber,int secondNumber ,int thirdNumber)
        {
            int max = firstNumber;
            if (secondNumber.CompareTo(max) > 0)
            {
                max = secondNumber;
            }
            if (thirdNumber.CompareTo(max) > 0)
            {
                max = thirdNumber;
            }
            return max;
        }

        public float findMaximum(float firstNumber, float secondNumber, float thirdNumber)
        {
            float max = firstNumber;
            if (secondNumber.CompareTo(max) > 0)
            {
                max = secondNumber;
            }
            if (thirdNumber.CompareTo(max) > 0)
            {
                max = thirdNumber;
            }
            return max;
        }

        public  string findMaximum(string firstString, string secondString, string thirdString)
        {
            string max = firstString;
            if (secondString.CompareTo(max)>0)
            {
                max = secondString;
            }
            if (thirdString.CompareTo(max)>0)
            {
                max = thirdString;
            }
                return max;
        }


    }
}
