// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.Libssh2
{
	[NativeName(NativeNameType.StructOrClass, "_LIBSSH2_USERAUTH_KBDINT_PROMPT")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Libssh2UserauthKbdintPrompt
	{
		[NativeName(NativeNameType.Field, "text")]
		[NativeName(NativeNameType.Type, "unsigned char*")]
		public unsafe byte* Text;
		[NativeName(NativeNameType.Field, "length")]
		[NativeName(NativeNameType.Type, "size_t")]
		public ulong Length;
		[NativeName(NativeNameType.Field, "echo")]
		[NativeName(NativeNameType.Type, "unsigned char")]
		public byte Echo;

		public unsafe Libssh2UserauthKbdintPrompt(byte* text = default, ulong length = default, byte echo = default)
		{
			Text = text;
			Length = length;
			Echo = echo;
		}


	}

}
