namespace SemLib.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.IO;
	using SemLib;

    public class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				//Note: you will have to supply your own text files
				Console.Write("text-1: ");
				var t1 = Console.ReadLine();

				Console.Write("text-2: ");
				var t2 = Console.ReadLine();

				var ka = new KeywordAnalyzer();

				var t1Analysis = ka.Analyze(t1);
				var t2Analysis = ka.Analyze(t2);

				Console.WriteLine("text-1");
				foreach (var key in t1Analysis.Keywords)
				{
					Console.WriteLine("   key: {0}, rank: {1}", key.Word, key.Rank);
				}

				Console.WriteLine("text-2");
				foreach (var key in t2Analysis.Keywords)
				{
					Console.WriteLine("   key: {0}, rank: {1}", key.Word, key.Rank);
				}

				Console.WriteLine("text-1");
				var t1Keywords = (from n in t1Analysis.Keywords select n);
				foreach (var key in t1Keywords)
				{
					Console.WriteLine("   {0}", key.Word);
				}

				Console.WriteLine("text-2");
				var t2Keywords = (from n in t2Analysis.Keywords select n);
				foreach (var key in t2Keywords)
				{
					Console.WriteLine("   {0}", key.Word);
				}

				Console.WriteLine("--------------------------------------------------");
			}
		}
	}
}
