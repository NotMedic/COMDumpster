using System;
using System.Runtime.InteropServices;
namespace SharpCOMDumpster
{
	public static class ComSvcs
	{
		[DllImport("comsvcs.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		public static extern bool MiniDumpW(
			IntPtr Dummy1,
			IntPtr Dummy2,
			string lpArg
		);
	}
	public static class Kernel32
	{
		[DllImport("kernel32.dll")]
		public static extern uint GetLastError();
	}
}