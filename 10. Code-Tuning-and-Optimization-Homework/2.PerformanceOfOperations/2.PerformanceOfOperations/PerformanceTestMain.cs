using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.PerformanceOfOperations
{
    public static class PerformanceTestMain
	{
		private static readonly Stopwatch stopwatch = new Stopwatch();

		const int Int1 = int.MinValue;
		const int Int2 = int.MaxValue;

		const long Long1 = long.MaxValue;
		const long Long2 = long.MinValue;

		const double Double1 = double.MaxValue;
		const double Double2 = double.MinValue;

		const decimal Decimal1 = 0M;
		const decimal Decimal2 = 100M;

		public static void Main()
		{
			TestOperation(SimpleMathOperations.AddInt, Int1, Int2);
			TestOperation(SimpleMathOperations.AddLong, Long1, Long2);
			TestOperation(SimpleMathOperations.AddDouble, Double1, Double2);
			TestOperation(SimpleMathOperations.AddDecimal, Decimal1, Decimal2);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.SubtractInt, Int1, Int2);
			TestOperation(SimpleMathOperations.SubtractLong, Long1, Long2);
			TestOperation(SimpleMathOperations.SubtractDouble, Double1, Double2);
			TestOperation(SimpleMathOperations.SubtractDecimal, Decimal1, Decimal2);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.IncrementPrefixInt, Int1);
			TestOperation(SimpleMathOperations.IncrementPrefixLong, Long1);
			TestOperation(SimpleMathOperations.IncrementPrefixDouble, Double1);
			TestOperation(SimpleMathOperations.IncrementPrefixDecimal, Decimal1);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.IncrementPostfixInt, Int1);
			TestOperation(SimpleMathOperations.IncrementPostfixLong, Long1);
			TestOperation(SimpleMathOperations.IncrementPostfixDouble, Double1);
			TestOperation(SimpleMathOperations.IncrementPostfixDecimal, Decimal1);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.IncrementByOneInt, Int1);
			TestOperation(SimpleMathOperations.IncrementByOneLong, Long1);
			TestOperation(SimpleMathOperations.IncrementByOneDouble, Double1);
			TestOperation(SimpleMathOperations.IncrementByOneDecimal, Decimal1);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.MultiplyInt, Int1, Int2);
			TestOperation(SimpleMathOperations.MultiplyLong, Long1, Long2);
			TestOperation(SimpleMathOperations.MultiplyDouble, Double1, Double2);
			TestOperation(SimpleMathOperations.MultiplyDecimal, Decimal1, Decimal2);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.DivideInt, Int1, Int2);
			TestOperation(SimpleMathOperations.DivideLong, Long1, Long2);
			TestOperation(SimpleMathOperations.DivideDouble, Double1, Double2);
			TestOperation(SimpleMathOperations.DivideDecimal, Decimal1, Decimal2);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.SqrtDouble, Double1);
			TestOperation(SimpleMathOperations.SqrtDecimal,  Decimal1);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.LogDouble, Double1);
			TestOperation(SimpleMathOperations.LogDecimal, Decimal1);

			Console.WriteLine();
			TestOperation(SimpleMathOperations.SinDouble, Double1);
			TestOperation(SimpleMathOperations.SinDecimal, Decimal1);
		}

		private static void TestOperation<T>(Action<T, T> operation, params T[] parameters)
		{
			double[] testResults = new double[TestValues.NumberOfTestsForAveraging];

			for (int i = 0; i < TestValues.NumberOfTestsForAveraging; i++)
			{
				var firstParam = parameters[0];
				var secondParam = parameters[1];

				stopwatch.Restart();
				operation.Invoke(firstParam, secondParam);
				stopwatch.Stop();

				testResults[i] = stopwatch.Elapsed.TotalMilliseconds;
			}

			double averageMs = testResults.Average();
		    string description = operation.GetMethodInfo().Name;
			PrintAverageMs(description, averageMs);
		}

		private static void TestOperation<T>(Action<T> operation, params T[] parameters)
		{
			double[] testResults = new double[TestValues.NumberOfTestsForAveraging];

			for (int i = 0; i < TestValues.NumberOfTestsForAveraging; i++)
			{
				var firstParam = parameters[0];

				stopwatch.Restart();
				operation.Invoke(firstParam);
				stopwatch.Stop();

				testResults[i] = stopwatch.Elapsed.TotalMilliseconds;
			}

			double averageMs = testResults.Average();
		    string description = operation.GetMethodInfo().Name;
			PrintAverageMs(description, averageMs);
		}

		private static void PrintAverageMs(string description, double averageMs)
		{
			Console.WriteLine(description + " derived from " + TestValues.NumberOfTestsForAveraging + " tests: " + string.Format("{0:f3} ms",averageMs));
		}
	}
}