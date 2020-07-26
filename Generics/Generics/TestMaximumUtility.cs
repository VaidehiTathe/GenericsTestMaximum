using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Generics
{
    public class TestMaximumUtility<E> where E : IComparable
    {
        E firstNumber;
        E secondNumber;
        E thirdNumber;
        E[] values;
        E maximumElement;

        public TestMaximumUtility()
        {
        }
        public TestMaximumUtility(E firstNumber, E secondNumber, E thirdNumber, [Optional] E[] values)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
            this.values = values;
        }
        public E findMaximum(E firstNumber, E secondNumber, E thirdNumber, params object[] values)  
        {
            List<object> myList = new List<object>();
            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);
            List<object> list = values.ToList();

            myList.Sort();
            foreach (E value in myList)
            {
                this.maximumElement = value;
            }

            return this.maximumElement;
        }
    }
}
