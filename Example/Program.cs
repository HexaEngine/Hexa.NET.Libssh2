// See https://aka.ms/new-console-template for more information
using Hexa.NET.Libssh2;
using System.Net.Sockets;
using System.Runtime.InteropServices;

internal unsafe class Program
{
    private static void Main(string[] args)
    {
        int result = Libssh2.Init(0);
        if (result != 0)
        {
            Console.WriteLine("Failed to initialize libssh2");
            return;
        }

        Libssh2Session* session = Libssh2.SessionInitEx(null, null, null, null);
        if (session == null)
        {
            Console.WriteLine("Failed to initialize session");
            return;
        }

        string server = "";
        int port = 22;

        Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(server, port);

        result = Libssh2.SessionHandshake(session, new((int)socket.Handle));
        if (result != 0)
        {
            Console.WriteLine("Failed to handshake");
            return;
        }

        string username = "";
        string password = "";

        result = Libssh2.UserauthPasswordEx(session, username, (uint)username.Length, password, (uint)password.Length, null);
        if (result != 0)
        {
            Console.WriteLine("Failed to authenticate");
            return;
        }

        // Open a channel
        var channel = Libssh2.ChannelOpenEx(session, "session", 7, 1024, 1024, (byte*)null, 0);
        if (channel == null)
        {
            Console.WriteLine("Failed to open channel");
            return;
        }

        int execResult = Libssh2.ChannelProcessStartup(channel, "exec", 4, "ls -l", 5);
        if (execResult != 0)
        {
            Console.WriteLine("Failed to execute command");
            return;
        }

        byte* buffer = stackalloc byte[1024];
        nint n = 0;
        while ((n = Libssh2.ChannelReadEx(channel, 0, buffer, 1024)) > 0)
        {
            Console.Write(Marshal.PtrToStringAnsi((IntPtr)buffer, (int)n));
        }

        Libssh2.ChannelClose(channel);

        Libssh2.ChannelFree(channel);

        Libssh2.SessionDisconnectEx(session, Libssh2.SSH_DISCONNECT_BY_APPLICATION, "Bye", "en");

        Libssh2.SessionFree(session);

        socket.Close();
        socket.Dispose();

        Libssh2.Exit();
    }
}