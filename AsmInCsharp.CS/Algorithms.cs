using System.Runtime.InteropServices;

namespace AsmInCsharp.CS
{
	public class Algorithms
	{
		[DllImport(@"C:\Programowanie\AsmInCsharp\x64\Debug\AsmInCsharp.Asm.dll")]
		public static extern int Example(ulong[] data);
	}
}