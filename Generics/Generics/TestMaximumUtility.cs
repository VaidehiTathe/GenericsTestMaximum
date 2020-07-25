using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Generics
{
    public class TestMaximumUtility
    {
        public E findMaximum<E>(E firstNumber, E secondNumber, E thirdNumber) where E : IComparable<E> 
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
