using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Generics
{
    public class TestMaximumUtility<E> where E:IComparable
    {
        E firstNumber;
        E secondNumber;
        E thirdNumber;
        public TestMaximumUtility(E firstNumber, E secondNumber, E thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }
        public E findMaximum()  
        {
            E max = firstNumber;
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
    }
}
