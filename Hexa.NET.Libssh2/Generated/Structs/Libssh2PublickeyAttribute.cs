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
	[NativeName(NativeNameType.StructOrClass, "_libssh2_publickey_attribute")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Libssh2PublickeyAttribute
	{
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* Name;
		[NativeName(NativeNameType.Field, "name_len")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint NameLen;
		[NativeName(NativeNameType.Field, "value")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* Value;
		[NativeName(NativeNameType.Field, "value_len")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint ValueLen;
		[NativeName(NativeNameType.Field, "mandatory")]
		[NativeName(NativeNameType.Type, "char")]
		public byte Mandatory;

		public unsafe Libssh2PublickeyAttribute(byte* name = default, uint nameLen = default, byte* value = default, uint valueLen = default, byte mandatory = default)
		{
			Name = name;
			NameLen = nameLen;
			Value = value;
			ValueLen = valueLen;
			Mandatory = mandatory;
		}


	}

}
