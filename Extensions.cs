using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ZeroMQ
{
	internal static class Extensions
	{
		public static bool IsNullOrWhiteSpace(string value) {
			if (value == null) return true;
			return string.IsNullOrEmpty(value.Trim());
		}

		public static void CopyTo(this Stream from, Stream to) {
			byte[] buffer = new byte[81920];
			int read;
			while ((read = from.Read(buffer, 0, buffer.Length)) != 0)
				to.Write(buffer, 0, read);
		}

		public static void ThreadYield() {
			SwitchToThread();
		}

		[DllImport("kernel32")]
		static extern int SwitchToThread();
	}
}
