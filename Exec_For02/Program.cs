using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_For02
			//等腰三角形
			//做出一個共五排，由上而下依序遞增的等腰三角形
			
			
			for (int i = 0; i <= 5; i++)
			{
				int countOfStar =  2 * i + 1;
				int countOfSpace = 5 - i;
				string result = new string(' ', countOfSpace) + new string('*', countOfStar);
				Console.WriteLine(result);

			}
		}
	}
}
