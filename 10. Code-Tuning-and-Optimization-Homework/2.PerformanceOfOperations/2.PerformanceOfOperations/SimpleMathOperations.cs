using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PerformanceOfOperations
{
    public static class SimpleMathOperations
    {
        public static void AddInt(int num1, int num2)
        {
            int result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 + num2;
            }
        }

        public static void AddLong(long num1, long num2)
        {
            long result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 + num2;
            }
        }

        public static void AddDouble(double num1, double num2)
        {
            double result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 + num2;
            }
        }

        public static void AddDecimal(decimal num1, decimal num2)
        {
            decimal result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 + num2;
            }
        }

        public static void SubtractInt(int num1, int num2)
        {
            int result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 - num2;
            }
        }

        public static void SubtractLong(long num1, long num2)
        {
            long result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 - num2;
            }
        }

        public static void SubtractDouble(double num1, double num2)
        {
            double result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 - num2;
            }
        }

        public static void SubtractDecimal(decimal num1, decimal num2)
        {
            decimal result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 - num2;
            }
        }

        public static void IncrementPrefixInt(int num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                ++num;
            }
        }

        public static void IncrementPrefixLong(long num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                ++num;
            }
        }

        public static void IncrementPrefixDouble(double num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                ++num;
            }
        }

        public static void IncrementPrefixDecimal(decimal num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                ++num;
            }
        }

        public static void IncrementPostfixInt(int num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num++;
            }
        }

        public static void IncrementPostfixLong(long num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num++;
            }
        }

        public static void IncrementPostfixDouble(double num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num++;
            }
        }

        public static void IncrementPostfixDecimal(decimal num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num++;
            }
        }

        public static void IncrementByOneInt(int num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num += 1;
            }
        }

        public static void IncrementByOneLong(long num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num += 1;
            }
        }

        public static void IncrementByOneDouble(double num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num += 1;
            }
        }

        public static void IncrementByOneDecimal(decimal num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                num += 1;
            }
        }

        public static void MultiplyInt(int num1, int num2)
        {
            int result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 * num2;
            }
        }

        public static void MultiplyLong(long num1, long num2)
        {
            long result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 * num2;
            }
        }

        public static void MultiplyDouble(double num1, double num2)
        {
            double result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 * num2;
            }
        }

        public static void MultiplyDecimal(decimal num1, decimal num2)
        {
            decimal result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 * num2;
            }
        }

        public static void DivideInt(int num1, int num2)
        {
            int result;

            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 / num2;
            }
        }

        public static void DivideLong(long num1, long num2)
        {
            long result;

            for (long i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 / num2;
            }
        }

        public static void DivideDouble(double num1, double num2)
        {
            double result;

            for (double i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 / num2;
            }
        }

        public static void DivideDecimal(decimal num1, decimal num2)
        {
            decimal result;

            for (decimal i = 0; i < TestValues.NumberOfTests; i++)
            {
                result = num1 / num2;
            }
        }

        public static void SqrtDouble(double num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                Math.Sqrt(num);
            }
        }

        public static void SqrtDecimal(decimal num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                Math.Sqrt((double)num);
            }
        }

        public static void LogDouble(double num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                Math.Log(num);
            }
        }

        public static void LogDecimal(decimal num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                Math.Log((double)num);
            }
        }

        public static void SinDouble(double num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                Math.Sin(num);
            }
        }

        public static void SinDecimal(decimal num)
        {
            for (int i = 0; i < TestValues.NumberOfTests; i++)
            {
                Math.Sin((double)num);
            }
        }
    }
}
