using System;

namespace TestApp1
{
    internal struct SomeStruct
    {
        private readonly int _id;

        public SomeStruct(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return _id.ToString();
        }
    }

    internal static class Program
    {
        private static readonly SomeStruct[] SomeStructs =
        {
            new SomeStruct(1)
        };

        private static ref readonly SomeStruct GetRef()
        {
            return ref SomeStructs[0];
        }

        private static void TryToChangeRef(ref SomeStruct f)
        {
            f = new SomeStruct(2);
        }

        public static void Main()
        {
            var f = GetRef();
            TryToChangeRef(ref SomeStructs[0]);
            Console.WriteLine(SomeStructs[0].ToString());
            Console.WriteLine(f.ToString());
        }
    }
}
