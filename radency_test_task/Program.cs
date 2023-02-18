// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;

public class StringChecker
{
	public static bool Check(string s, string p1, string p2)
	{
		int p1Index = -1;
		int p2Index = -1;
		string newP1, newP2;
		if (p1.Length != p2.Length)
		{
			newP1 = p1.Length > p2.Length ? p1 : p2;
			newP2 = p1.Length < p2.Length ? p1 : p2;
		}
		else
		{
			newP1 = p1;
			newP2 = p2;
		}

		char[] chars = new char[s.Length];
		int i = 0;
		foreach (char c in s)
		{
			bool found = false;
			if (p1Index < newP1.Length - 1 && newP1[p1Index + 1] == c)
			{
				p1Index++;
				found = true;
				chars[i++] = c;
			}
			else if (p2Index < newP2.Length - 1 && newP2[p2Index + 1] == c)
			{
				p2Index++;
				found = true;
				chars[i++] = c;
			}

			if (!found)
			{
				return false;
			}
		}

		if (p1Index == newP1.Length - 1 && p2Index == newP2.Length - 1)
		{
			return true;
		}
		return false;
	}
}

public class Check
{
	public static void Main(string[] args)
	{
		const string s = "q9APM  oWK 84e18PW2";
		const string p1 = "APMoq9  W";
		const string p2 = "K 84e18PW2";
		const string s2 = "w27y7";
		const string p3 = "27";
		const string p4 = "w7y";
		Console.WriteLine(StringChecker.Check(s2, p3, p4));
	}
}

