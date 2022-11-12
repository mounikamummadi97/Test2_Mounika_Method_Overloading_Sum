using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Mounika_Method_Overloading_Sum
{
    public class SumCalculation
    {
        public  void Calculation(int _firstNumber, int _secondNumber)
        {
            int sum = _firstNumber + _secondNumber;
            Console.WriteLine("Sum of Two numbers :"+ sum);
        }
        public  void Calculation(int _firstNumber, int _secondNumber,int _thirdNumber)
        {
            int sum = _firstNumber + _secondNumber + _thirdNumber;
            Console.WriteLine("Sum of Three numbers :" + sum);
        }
    }
    
}
