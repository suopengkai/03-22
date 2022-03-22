using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			new Number().GetNumber();
			Console.ReadLine();
		}
		class Number {

			public int GetNumber()
			{
				int[] arr = new int[] { 0, 1, 2 };
				int n = 0;
				try
				{
					 n= arr[2];
					Console.WriteLine(n);
				}
				catch (Exception ex)
				{
					//记录 
					// 日志的帮助类  能做处理的 你就处理了  处理不了  
					// 404 的界面 
					// 报黄页
					Console.WriteLine(ex);
				}
				return n;
			}
		}
	}
}
