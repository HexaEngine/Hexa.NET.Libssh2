using HexaGen.Runtime;

#if NET7_0_OR_GREATER
[assembly: System.Runtime.CompilerServices.DisableRuntimeMarshalling]
#endif

[assembly: NativeLibrary("libssh2", TargetPlatform.Windows)]
[assembly: NativeLibrary("libssh2", TargetPlatform.Linux)]
[assembly: NativeLibrary("libssh2", TargetPlatform.Android)]
[assembly: NativeLibrary("libssh2", TargetPlatform.OSX)]