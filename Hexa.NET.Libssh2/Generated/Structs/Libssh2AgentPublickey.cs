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
	[NativeName(NativeNameType.StructOrClass, "libssh2_agent_publickey")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Libssh2AgentPublickey
	{
		/// <summary>
		/// magic stored by the library <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "magic")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Magic;

		/// <summary>
		/// handle to the internal representation of key <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "node")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* Node;

		/// <summary>
		/// public key blob <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "blob")]
		[NativeName(NativeNameType.Type, "unsigned char*")]
		public unsafe byte* Blob;

		/// <summary>
		/// length of the public key blob <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "blob_len")]
		[NativeName(NativeNameType.Type, "size_t")]
		public ulong BlobLen;

		/// <summary>
		/// comment in printable format <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "comment")]
		[NativeName(NativeNameType.Type, "char*")]
		public unsafe byte* Comment;


		public unsafe Libssh2AgentPublickey(uint magic = default, void* node = default, byte* blob = default, ulong blobLen = default, byte* comment = default)
		{
			Magic = magic;
			Node = node;
			Blob = blob;
			BlobLen = blobLen;
			Comment = comment;
		}


	}

}
