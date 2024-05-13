// This sample code shows a bug in the .NET marshaller.
// Native C++ functions returning a string (char*) sometimes
// are not marshalled correctly throwing an exception.
// This is the reason why the .NET wrapper converts
// the char-pointer manually into a .NET string.

using System;
using System.Text;
using System.Runtime.InteropServices;

public static class FreeImage
{
	private const string dllName = "FreeImage.dll";

	[DllImport(dllName, EntryPoint = "FreeImage_GetFormatFromFIF")]
	[return: MarshalAs(UnmanagedType.LPStr)]
	public static extern string GetFormatFromFIF(int format);

	[DllImport(dllName, EntryPoint = "FreeImage_GetFIFExtensionList")]
	[return: MarshalAs(UnmanagedType.LPStr)]
	public static extern string GetFIFExtensionList(int format);

	[DllImport(dllName, EntryPoint = "FreeImage_GetFIFDescription")]
	[return: MarshalAs(UnmanagedType.LPStr)]
	public static extern string GetFIFDescription(int format);

	[DllImport(dllName, EntryPoint = "FreeImage_GetFIFRegExpr")]
	[return: MarshalAs(UnmanagedType.LPStr)]
	public static extern string GetFIFRegExpr(int format);

	[DllImport(dllName, EntryPoint = "FreeImage_GetFIFMimeType")]
	[return: MarshalAs(UnmanagedType.LPStr)]
	public static extern string GetFIFMimeType(int format);

	[DllImport(dllName, EntryPoint = "FreeImage_GetFIFCount")]
	public static extern int GetFIFCount();
}

public class Program
{
	public static bool[,] getmatrix(int fifCount)
	{
		bool[,] matrix = new bool[5, fifCount];

		int j = 0;

		for (int i = 0; i < fifCount; i++)
		{
			bool success = true;
			try
			{
				FreeImage.GetFormatFromFIF(i);
			}
			catch
			{
				success = false;
			}
			matrix[j, i] = success;
		}
		j++;

		for (int i = 0; i < fifCount; i++)
		{
			bool success = true;
			try
			{
				FreeImage.GetFIFExtensionList(i);
			}
			catch
			{
				success = false;
			}
			matrix[j, i] = success;
		}
		j++;

		for (int i = 0; i < fifCount; i++)
		{
			bool success = true;
			try
			{
				FreeImage.GetFIFDescription(i);
			}
			catch
			{
				success = false;
			}
			matrix[j, i] = success;
		}
		j++;

		for (int i = 0; i < fifCount; i++)
		{
			bool success = true;
			try
			{
				FreeImage.GetFIFRegExpr(i);
			}
			catch
			{
				success = false;
			}
			matrix[j, i] = success;
		}
		j++;

		for (int i = 0; i < fifCount; i++)
		{
			bool success = true;
			try
			{
				FreeImage.GetFIFMimeType(i);
			}
			catch
			{
				success = false;
			}
			matrix[j, i] = success;
		}

		return matrix;
	}

	public static void Main()
	{
		int fifCount = FreeImage.GetFIFCount();
		bool[,] matrix = getmatrix(fifCount);

		Console.Clear();
		Console.WriteLine("1: GetFormatFromFIF");
		Console.WriteLine("2: GetFIFExtensionList");
		Console.WriteLine("3: GetFIFDescription");
		Console.WriteLine("4: GetFIFRegExpr");
		Console.WriteLine("5: GetFIFMimeType");
		Console.Write(Environment.NewLine);

		Console.Write("FIF:\t");
		for (int x = 1; x < 6; x++)
			Console.Write("{0}:\t", x);

		Console.Write(Environment.NewLine);

		for (int k = 0; k < fifCount; k++)
		{
			Console.Write("{0}:\t", k);
			for (int l = 0; l < 5; l++)
			{
				Console.Write(matrix[l, k] ? "1\t" : "0\t");
			}
			Console.Write(Environment.NewLine);
		}
	}
}