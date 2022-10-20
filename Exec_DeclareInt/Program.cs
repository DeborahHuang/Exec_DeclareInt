using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareInt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//第一題:計算1+(2+2)*3-1
			int count = 1 + (2 + 2) * 3 - 1;
			Console.WriteLine(count);

			//第二題:求120/7的商及餘數各是多少
			int num1 = 120 / 7;
			int num2 = 120 % 7;
			Console.WriteLine(num1);
			Console.WriteLine(num2);

			//第三題:判斷9,202個別是奇數或偶數
			//布林值寫法
			int value = 9;
			bool IsEvenInt = value % 2 == 0;
			string reslut = IsEvenInt ? $"{value}偶數" : $"{value}為奇數";
			Console.WriteLine(reslut);
			
			int value2 = 202;
			string reslut2= IsEvenInt ? $"{value2}偶數" : $"{value2}為奇數" ;
			Console.WriteLine(reslut2);
			

			//if寫法
			if (value % 2 == 0)
			{
				Console.WriteLine($"{value}為偶數");
			}
			else
			{
				Console.WriteLine($"{value}為奇數");
			}


			if (value2 % 2 == 0)
			{
				Console.WriteLine($"{value2}為偶數");
			}
			else
			{
				Console.WriteLine($"{value2}為奇數");
			}

			//第四題:根據兩個變數的大小 視需要對調兩個變數的值
			int begin = 50; 
			int end = 20;

			var temp=begin;
			begin = end;
			end = temp;

			Console.WriteLine($"{begin} ~ {end}");
		}
	}
}
