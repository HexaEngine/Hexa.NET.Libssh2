namespace Hexa.NET.Libssh2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public unsafe struct Libssh2Socket
    {
        private int Value;

        public Libssh2Socket(int value)
        {
            Value = value;
        }

        public Libssh2Socket(uint value)
        {
            Value = *(int*)&value;
        }

        public uint UIntValue
        {
            readonly get
            {
                var value = Value;
                return *(uint*)&value;
            }
            set
            {
                Value = *(int*)&value;
            }
        }

        public int IntValue
        {
            readonly get
            {
                return Value;
            }
            set
            {
                Value = value;
            }
        }

        public static implicit operator int(Libssh2Socket value)
        {
            return value.Value;
        }

        public static implicit operator uint(Libssh2Socket value)
        {
            return *(uint*)&value.Value;
        }
    }
}