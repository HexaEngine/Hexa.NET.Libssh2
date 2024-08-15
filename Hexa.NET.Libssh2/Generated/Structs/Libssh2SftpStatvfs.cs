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
	[NativeName(NativeNameType.StructOrClass, "_LIBSSH2_SFTP_STATVFS")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Libssh2SftpStatvfs
	{
		/// <summary>
		/// file system block size <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_bsize")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FBsize;

		/// <summary>
		/// fragment size <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_frsize")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FFrsize;

		/// <summary>
		/// size of fs in f_frsize units <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_blocks")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FBlocks;

		/// <summary>
		/// # free blocks <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_bfree")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FBfree;

		/// <summary>
		/// # free blocks for non-root <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_bavail")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FBavail;

		/// <summary>
		/// # inodes <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_files")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FFiles;

		/// <summary>
		/// # free inodes <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_ffree")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FFfree;

		/// <summary>
		/// # free inodes for non-root <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_favail")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FFavail;

		/// <summary>
		/// file system ID <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_fsid")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FFsid;

		/// <summary>
		/// mount flags <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_flag")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FFlag;

		/// <summary>
		/// maximum filename length <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "f_namemax")]
		[NativeName(NativeNameType.Type, "libssh2_uint64_t")]
		public ulong FNamemax;


		public unsafe Libssh2SftpStatvfs(ulong fBsize = default, ulong fFrsize = default, ulong fBlocks = default, ulong fBfree = default, ulong fBavail = default, ulong fFiles = default, ulong fFfree = default, ulong fFavail = default, ulong fFsid = default, ulong fFlag = default, ulong fNamemax = default)
		{
			FBsize = fBsize;
			FFrsize = fFrsize;
			FBlocks = fBlocks;
			FBfree = fBfree;
			FBavail = fBavail;
			FFiles = fFiles;
			FFfree = fFfree;
			FFavail = fFavail;
			FFsid = fFsid;
			FFlag = fFlag;
			FNamemax = fNamemax;
		}


	}

}
