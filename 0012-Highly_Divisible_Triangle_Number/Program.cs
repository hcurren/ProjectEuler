﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StaticClasses;

namespace _0012_Highly_Divisible_Triangle_Number
{
	class Program
	{
		static void Main ( string[] args )
		{
			/*
			The sequence of triangle numbers is generated by adding the natural numbers. 
			So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. 
			
			The first ten terms would be:
			1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

			Let us list the factors of the first seven triangle numbers:

			 1: 1
			 3: 1,3
			 6: 1,2,3,6
			10: 1,2,5,10
			15: 1,3,5,15
			21: 1,3,7,21
			28: 1,2,4,7,14,28
			We can see that 28 is the first triangle number to have over five divisors.

			What is the value of the first triangle number to have over five hundred divisors?
			Answer:	76576500
			*/
			Stopwatch timer = new Stopwatch();

			Console.WriteLine( "Find the first Triangular Number with at least the specified number of divisors." );
			Console.WriteLine( "--------------------------------------------------------------------------------" );
			Console.WriteLine();
			Console.Write( "How many divisors do you want? " );
			uint divisorsWanted = uint.Parse( Console.ReadLine() );
			uint triangularNumber = 3;
			uint triangularNumberValue = 0;
			uint divisors = 0;
			bool hasRequiredDivisors = false;
			uint mostDivisors = 0;



			timer.Start();
			while ( !hasRequiredDivisors )
			{
				triangularNumber++;
				triangularNumberValue = TriangularNumbers.GetNthTriangular(triangularNumber);

				divisors = (uint)Factors.GetAllFactors(triangularNumberValue).Length;

				if ( divisors > mostDivisors )
				{
					mostDivisors = divisors;
				}

				if ( divisors >= divisorsWanted )
				{
					hasRequiredDivisors = true;
				}
			}
			timer.Stop();

			Console.WriteLine( "The first Triangular Number with {0} divisors is ({1}) {2}", 
				divisorsWanted, triangularNumber, triangularNumberValue);
			Console.WriteLine( timer.Elapsed );

			Console.ReadLine();
		}
	}
}