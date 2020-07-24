using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class TestMaximumUtility
    {
        public int findMaximum(int firstNumber,int secondNumber ,int thirdNumber)
        {
            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }

        public float findMaximum(float firstNumber, float secondNumber, float thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
    }
}
