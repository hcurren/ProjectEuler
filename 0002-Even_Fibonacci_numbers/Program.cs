﻿using System;
using System.Diagnostics;

using StaticClasses;

namespace _0002_Even_Fibonacci_numbers
{
    class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
			 * By starting with 1 and 2, the first 10 terms will be:
			 * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
			 * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
			 * find the sum of the even-valued terms.
			 */
			Stopwatch timer = new Stopwatch();

			const int MAX = 4000000;

			timer.Start();
			int[] numberSequence = Sequences.GetFibonacciSequenceTo( MAX );
			timer.Stop();

			Console.WriteLine("Fibonacci Sequence generation time: {0}", timer.Elapsed);
			timer.Reset();

			int sum = 0;

			timer.Start();
			for (int i = 0; i < numberSequence.Length; i++)
			{
				if (numberSequence[i] % 2 == 0)
					sum += numberSequence[i];
			}
			timer.Stop();

			Console.WriteLine("Fibonacci Sequence filter time: {0}", timer.Elapsed);

			Console.WriteLine("The total is: {0}", sum);
			Console.ReadLine();
		}//end Main
	}//end Program
}
